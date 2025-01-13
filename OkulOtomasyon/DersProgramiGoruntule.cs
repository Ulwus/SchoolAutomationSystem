using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using OkulOtomasyon.Models;

public partial class DersProgramiGoruntule : Form
{
    private DatabaseConnection dbConnection = DatabaseConnection.Instance;
    private string selectedSinif;

    public DersProgramiGoruntule()
    {
        InitializeComponent();

        this.Load += DersProgramiGoruntule_Load;
        btnFiltrele.Click += BtnFiltrele_Click;
        cmbSinif.SelectedIndexChanged += CmbSinif_SelectedIndexChanged;

        SetGridAppearance();
    }

    private void SetGridAppearance()
    {
        viewDersProgrami.Appearance.Row.BackColor = Color.FromArgb(45, 45, 45);
        viewDersProgrami.Appearance.Row.ForeColor = Color.White;
        viewDersProgrami.Appearance.HeaderPanel.BackColor = Color.FromArgb(55, 55, 55);
        viewDersProgrami.Appearance.HeaderPanel.ForeColor = Color.White;
        viewDersProgrami.OptionsView.EnableAppearanceEvenRow = true;
        viewDersProgrami.OptionsView.EnableAppearanceOddRow = true;
    }

    private void DersProgramiGoruntule_Load(object sender, EventArgs e)
    {
        SiniflariYukle();
        DersPrograminiGetir();
    }

    private void SiniflariYukle()
    {
        try
        {
            using (var connection = dbConnection.GetConnection())
            {
                string query = "SELECT sinifName FROM sinif ORDER BY sinifName";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbSinif.Properties.Items.Add(reader["sinifName"].ToString());
                }
            }
        }
        catch (Exception ex)
        {
            XtraMessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            dbConnection.CloseConnection();
        }
    }

    private void DersPrograminiGetir(string sinifFilter = "")
    {
        try
        {
            using (var connection = dbConnection.GetConnection())
            {
                string query = @"SELECT 
                         dp.gun as 'Gün',
                         TIME_FORMAT(dp.baslangicSaati,'%H:%i') as 'Başlangıç',
                         TIME_FORMAT(dp.bitisSaati,'%H:%i') as 'Bitiş',
                         d.dersIsmi as 'Ders',
                         CONCAT(o.ogretmenIsim,' ',o.ogretmenSoyisim) as 'Öğretmen',
                         s.sinifName as 'Sınıf'
                         FROM ders_programi dp 
                         JOIN ders d ON dp.dersID = d.dersID 
                         JOIN ogretmen o ON dp.ogretmenID = o.ogretmenID
                         JOIN sinif s ON dp.sinifID = s.sinifID";

                if (!string.IsNullOrEmpty(sinifFilter))
                {
                    query += " WHERE s.sinifName = @sinifName";
                }

                query += " ORDER BY dp.gun, dp.baslangicSaati";

                MySqlCommand cmd = new MySqlCommand(query, connection);

                if (!string.IsNullOrEmpty(sinifFilter))
                {
                    cmd.Parameters.AddWithValue("@sinifName", sinifFilter);
                }

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                gridDersProgrami.DataSource = dt;
                viewDersProgrami.Columns["Gün"].GroupIndex = 0;
                viewDersProgrami.BestFitColumns();
            }
        }
        catch (Exception ex)
        {
            XtraMessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            dbConnection.CloseConnection();
        }
    }

    private void BtnFiltrele_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(selectedSinif))
        {
            DersPrograminiGetir(selectedSinif);
        }
        else
        {
            DersPrograminiGetir();
        }
    }

    private void CmbSinif_SelectedIndexChanged(object sender, EventArgs e)
    {
        selectedSinif = cmbSinif.Text;
    }

    private void simpleButton1_Click(object sender, EventArgs e)
    {

        try
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "PDF dosyası (*.pdf)|*.pdf";
                saveDialog.FileName = $"Ders_Programi_{DateTime.Now:yyyyMMdd}.pdf";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    gridDersProgrami.ExportToPdf(saveDialog.FileName);
                    XtraMessageBox.Show("PDF dosyası başarıyla kaydedildi.", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        catch (Exception ex)
        {
            XtraMessageBox.Show("PDF oluşturulurken hata oluştu: " + ex.Message, "Hata",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


}