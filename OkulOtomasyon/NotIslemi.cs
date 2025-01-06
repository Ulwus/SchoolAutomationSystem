using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;

public partial class NotIslemi : Form
{
    private MySqlConnection connection;
    private int ogretmenID;

    public class DersItem
    {
        public int DersID { get; set; }
        public string DersIsmi { get; set; }
        public override string ToString() => DersIsmi;
    }

    public NotIslemi(int ogrID)
    {
        InitializeComponent();
        ogretmenID = ogrID;
        connection = new MySqlConnection("Server=localhost;Database=okulotomasyon;Uid=root;Pwd=ulwus123;");

        this.Load += NotIslemi_Load;
        cmbDersler.SelectedIndexChanged += cmbDersler_SelectedIndexChanged;
        cmbSiniflar.SelectedIndexChanged += cmbSiniflar_SelectedIndexChanged;
        btnKaydet.Click += btnKaydet_Click;

        viewOgrenciler.OptionsBehavior.Editable = true;
        viewOgrenciler.OptionsView.ShowGroupPanel = false;
    }

    private void NotIslemi_Load(object sender, EventArgs e)
    {
        LoadDersler();
        SetGridAppearance();
    }

    private void LoadDersler()
    {
        try
        {
            connection.Open();
            string dersQuery = @"SELECT DISTINCT d.dersID, d.dersIsmi
                               FROM ders_programi dp
                               INNER JOIN ders d ON dp.dersID = d.dersID
                               INNER JOIN ogretmen o ON dp.ogretmenID = o.ogretmenID
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
        catch (Exception ex)
        {
            XtraMessageBox.Show($"Dersler yüklenirken hata: {ex.Message}", "Hata",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            connection.Close();
        }
    }

    private void SetGridAppearance()
    {
        viewOgrenciler.Appearance.Row.BackColor = Color.FromArgb(45, 45, 45);
        viewOgrenciler.Appearance.Row.ForeColor = Color.White;
        viewOgrenciler.Appearance.HeaderPanel.BackColor = Color.FromArgb(55, 55, 55);
        viewOgrenciler.Appearance.HeaderPanel.ForeColor = Color.White;
        viewOgrenciler.Appearance.FocusedCell.BackColor = Color.FromArgb(70, 70, 70);
        viewOgrenciler.Appearance.FocusedCell.ForeColor = Color.White;
    }

    private void LoadOgrenciler()
    {
        if (cmbDersler.SelectedItem == null || cmbSiniflar.SelectedItem == null) return;

        try
        {
            connection.Open();
            string query = @"SELECT 
                           o.ogrenciID,
                           o.ogrenciIsmi as 'Ad',
                           o.ogrenciSoyismi as 'Soyad',
                           COALESCE(n.notDegeri, 0) as 'Sınav Notu'
                           FROM ders_programi dp
                           INNER JOIN sinif s ON dp.sinifID = s.sinifID
                           INNER JOIN ogrenci o ON s.sinifID = o.ogrenciSinif
                           LEFT JOIN notlar n ON o.ogrenciID = n.ogrenciID 
                               AND n.dersID = dp.dersID
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

                using (var da = new MySqlDataAdapter(cmd))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    gridOgrenciler.DataSource = dt;

                    var notColumn = viewOgrenciler.Columns["Sınav Notu"];
                    if (notColumn != null)
                    {
                        var riSpinEdit = new RepositoryItemSpinEdit();
                        riSpinEdit.MinValue = 0;
                        riSpinEdit.MaxValue = 100;
                        gridOgrenciler.RepositoryItems.Add(riSpinEdit);
                        notColumn.ColumnEdit = riSpinEdit;
                    }

                    viewOgrenciler.Columns["ogrenciID"].Visible = false;
                    viewOgrenciler.BestFitColumns();
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
            connection.Close();
        }
    }

    private void cmbDersler_SelectedIndexChanged(object sender, EventArgs e)
    {
        LoadOgrenciler();
    }

    private void cmbSiniflar_SelectedIndexChanged(object sender, EventArgs e)
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
            connection.Open();
            using (var transaction = connection.BeginTransaction())
            {
                try
                {
                    var dt = gridOgrenciler.DataSource as DataTable;
                    if (dt == null) return;

                    var selectedDers = cmbDersler.SelectedItem as DersItem;

                    foreach (DataRow row in dt.Rows)
                    {
                        string query = @"INSERT INTO notlar (ogrenciID, dersID, notDegeri, notTarihi)
                                       VALUES (@ogrID, @dersID, @notDegeri, @tarih)
                                       ON DUPLICATE KEY UPDATE
                                       notDegeri = @notDegeri,
                                       notTarihi = @tarih";

                        using (var cmd = new MySqlCommand(query, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@ogrID", row["ogrenciID"]);
                            cmd.Parameters.AddWithValue("@dersID", selectedDers.DersID);
                            cmd.Parameters.AddWithValue("@notDegeri", row["Sınav Notu"]);
                            cmd.Parameters.AddWithValue("@tarih", DateTime.Now);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    XtraMessageBox.Show("Notlar başarıyla kaydedildi.", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
        catch (Exception ex)
        {
            XtraMessageBox.Show($"Not kaydı sırasında hata: {ex.Message}", "Hata",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            connection.Close();
        }
    }

    private void cmbDersler_SelectedIndexChanged_1(object sender, EventArgs e)
    {

    }
}