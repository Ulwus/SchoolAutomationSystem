using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using OkulOtomasyon.Models;

public partial class DevamsizlikIslemi : Form
{
    private DatabaseConnection dbConnection = DatabaseConnection.Instance;
    private int ogretmenID;
    Account account;
    Teacher teacher;

    public class DersItem
    {
        public int DersID { get; set; }
        public string DersIsmi { get; set; }
        public override string ToString() => DersIsmi;
    }
    

    public DevamsizlikIslemi(Account account)
    {
        InitializeComponent();
        this.account = account;
        ogretmenID = account.UserAttachID;
        teacher = Teacher.GetById(ogretmenID);

        // Event handler'ları bağla
        this.Load += DevamsizlikIslemi_Load;
        cmbDersler.SelectedIndexChanged += cmbDersler_SelectedIndexChanged;
        cmbSiniflar.SelectedIndexChanged += cmbSiniflar_SelectedIndexChanged;
        dateDevamsizlik.EditValueChanged += dateDevamsizlik_EditValueChanged;
        btnKaydet.Click += btnKaydet_Click;
        
        // Grid'in düzenlenmesini etkinleştir
        viewOgrenciler.OptionsBehavior.Editable = true;
        viewOgrenciler.OptionsView.ShowGroupPanel = false;
    }

    private void DevamsizlikIslemi_Load(object sender, EventArgs e)
    {
        LoadDersler();
        SetGridAppearance();
        dateDevamsizlik.EditValue = DateTime.Now;
    }

    // ComboBox event handlers
    private void cmbDersler_SelectedIndexChanged(object sender, EventArgs e)
    {
        LoadOgrenciler();
    }

    private void cmbSiniflar_SelectedIndexChanged(object sender, EventArgs e)
    {
        LoadOgrenciler();
    }

    private void LoadDersler()
    {
        try
        {
            using (var connection = dbConnection.GetConnection())
            {
                string dersQuery = @"SELECT DISTINCT d.dersID, d.dersIsmi
                               FROM ders_programi dp
                               INNER JOIN ders d ON dp.dersID = d.dersID
                               WHERE dp.ogretmenID = @ogretmenID
                               ORDER BY d.dersIsmi";

                using (var cmd = new MySqlCommand(dersQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@ogretmenID", ogretmenID);

                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);

                        cmbDersler.Properties.Items.Clear();
                        foreach (DataRow row in dt.Rows)
                        {
                            cmbDersler.Properties.Items.Add(new DersItem
                            {
                                DersID = Convert.ToInt32(row["dersID"]),
                                DersIsmi = row["dersIsmi"].ToString()
                            });
                        }
                    }
                }

                // Öğretmenin sınıflarını getir
                string sinifQuery = @"SELECT DISTINCT s.sinifName
                                FROM ders_programi dp
                                INNER JOIN sinif s ON dp.sinifID = s.sinifID
                                WHERE dp.ogretmenID = @ogretmenID
                                ORDER BY s.sinifName";

                using (var cmd = new MySqlCommand(sinifQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@ogretmenID", ogretmenID);

                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);

                        cmbSiniflar.Properties.Items.Clear();
                        foreach (DataRow row in dt.Rows)
                        {
                            cmbSiniflar.Properties.Items.Add(row["sinifName"].ToString());
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            XtraMessageBox.Show($"Veriler yüklenirken hata: {ex.Message}", "Hata",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            dbConnection.CloseConnection();
        }
    }

    private void SetGridAppearance()
    {
        if (viewOgrenciler != null)
        {
            // Grid görünümünü ayarla
            viewOgrenciler.Appearance.Row.BackColor = Color.FromArgb(45, 45, 45);
            viewOgrenciler.Appearance.Row.ForeColor = Color.White;
            viewOgrenciler.Appearance.HeaderPanel.BackColor = Color.FromArgb(55, 55, 55);
            viewOgrenciler.Appearance.HeaderPanel.ForeColor = Color.White;
            viewOgrenciler.OptionsView.EnableAppearanceEvenRow = true;
            viewOgrenciler.OptionsView.EnableAppearanceOddRow = true;

            // Durum sütunu için özel görünüm
            viewOgrenciler.Appearance.FocusedCell.BackColor = Color.FromArgb(70, 70, 70);
            viewOgrenciler.Appearance.FocusedCell.ForeColor = Color.White;
        }
    }

    private void LoadOgrenciler()
    {
        if (cmbDersler.SelectedItem == null || cmbSiniflar.SelectedItem == null) return;

        try
        {
            using (var connection = dbConnection.GetConnection())
            {
                string query = @"SELECT DISTINCT
                       o.ogrenciID,
                       o.ogrenciIsmi as 'Ad',
                       o.ogrenciSoyismi as 'Soyad',
                       COALESCE(d.durum, 'Geldi') as 'Durum'
                       FROM ders_programi dp
                       INNER JOIN sinif s ON dp.sinifID = s.sinifID 
                       INNER JOIN ogrenci o ON s.sinifID = o.ogrenciSinif
                       LEFT JOIN devamsizlik d ON o.ogrenciID = d.ogrenciID 
                           AND d.dersID = dp.dersID
                           AND DATE(d.devamsizlikTarihi) = DATE(@tarih)
                       WHERE dp.ogretmenID = @ogretmenID
                       AND dp.dersID = @dersID
                       AND s.sinifName = @sinifName
                       ORDER BY o.ogrenciIsmi";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    var selectedDers = cmbDersler.SelectedItem as DersItem;
                    cmd.Parameters.AddWithValue("@dersID", selectedDers.DersID);
                    cmd.Parameters.AddWithValue("@ogretmenID", ogretmenID);
                    cmd.Parameters.AddWithValue("@sinifName", cmbSiniflar.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@tarih", Convert.ToDateTime(dateDevamsizlik.EditValue).Date);

                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);
                        gridOgrenciler.DataSource = dt;

                        // Repository ayarları
                        var durumColumn = viewOgrenciler.Columns["Durum"];
                        if (durumColumn != null)
                        {
                            var riCombo = new RepositoryItemComboBox();
                            riCombo.Items.AddRange(new string[] { "Geldi", "Gelmedi" });
                            gridOgrenciler.RepositoryItems.Add(riCombo);
                            durumColumn.ColumnEdit = riCombo;
                        }

                        viewOgrenciler.Columns["ogrenciID"].Visible = false;
                        viewOgrenciler.BestFitColumns();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            XtraMessageBox.Show($"Öğrenciler yüklenirken hata: {ex.Message}", "Hata",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            dbConnection.CloseConnection();
        }
    }

    private void dateDevamsizlik_EditValueChanged(object sender, EventArgs e)
    {
        LoadOgrenciler();
    }

    private void btnKaydet_Click(object sender, EventArgs e)
    {
        if (cmbDersler.SelectedItem == null || cmbSiniflar.SelectedItem == null)
        {
            XtraMessageBox.Show("Lütfen ders ve sınıf seçin!", "Uyarı",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            using (var connection = dbConnection.GetConnection())
            using (var transaction = connection.BeginTransaction())
            {
                var dt = gridOgrenciler.DataSource as DataTable;
                if (dt == null) return;

                var selectedDers = cmbDersler.SelectedItem as DersItem;
                var tarih = Convert.ToDateTime(dateDevamsizlik.EditValue).Date;

                try
                {
                    // Önce seçili tarih için tüm kayıtları sil
                    string deleteQuery = @"DELETE FROM devamsizlik 
                                         WHERE dersID = @dersID 
                                         AND DATE(devamsizlikTarihi) = DATE(@tarih)
                                         AND ogrenciID IN (SELECT ogrenciID FROM ogrenci WHERE ogrenciSinif = @sinifName)";

                    using (var cmd = new MySqlCommand(deleteQuery, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@dersID", selectedDers.DersID);
                        cmd.Parameters.AddWithValue("@tarih", tarih);
                        cmd.Parameters.AddWithValue("@sinifName", cmbSiniflar.SelectedItem.ToString());
                        cmd.ExecuteNonQuery();
                    }

                    // Yeni kayıtları ekle
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["Durum"].ToString() == "Gelmedi")
                        {
                            string insertQuery = @"INSERT INTO devamsizlik 
                                                 (ogrenciID, dersID, devamsizlikTarihi, durum)
                                                 VALUES 
                                                 (@ogrID, @dersID, @tarih, 1)";

                            using (var cmd = new MySqlCommand(insertQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@ogrID", row["ogrenciID"]);
                                cmd.Parameters.AddWithValue("@dersID", selectedDers.DersID);
                                cmd.Parameters.AddWithValue("@tarih", tarih);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    transaction.Commit();
                    XtraMessageBox.Show("Devamsızlık kayıtları başarıyla güncellendi.", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
        catch (Exception ex)
        {
            XtraMessageBox.Show($"Kayıt sırasında hata: {ex.Message}", "Hata",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            dbConnection.CloseConnection();
        }
    }

    private void cmbSiniflar_SelectedIndexChanged_1(object sender, EventArgs e)
    {

    }

    private void cmbDersler_SelectedIndexChanged_1(object sender, EventArgs e)
    {

    }
}