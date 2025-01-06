using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

public partial class HosGeldinOgretmen : Form
{
    private MySqlConnection connection;
    private int ogretmenID;

    public HosGeldinOgretmen(int ogrID)
    {
        InitializeComponent();
        ogretmenID = ogrID;
        connection = new MySqlConnection("Server=localhost;Database=okulotomasyon;Uid=root;Pwd=ulwus123;");
        this.Load += HosGeldinOgretmen_Load;

        // Grid görünüm ayarları
        SetGridAppearance();
    }

    private void SetGridAppearance()
    {
        foreach (GridView view in new[] { viewDersProgrami, viewSiniflar })
        {
            view.Appearance.Row.BackColor = Color.FromArgb(45, 45, 45);
            view.Appearance.Row.ForeColor = Color.White;
            view.Appearance.HeaderPanel.BackColor = Color.FromArgb(55, 55, 55);
            view.Appearance.HeaderPanel.ForeColor = Color.White;
            view.OptionsView.EnableAppearanceEvenRow = true;
            view.OptionsView.EnableAppearanceOddRow = true;
        }
    }

    private void HosGeldinOgretmen_Load(object sender, EventArgs e)
    {
        OgretmenBilgileriniGetir();
        DersProgramiGetir();
        SiniflarGetir();
    }

    private void OgretmenBilgileriniGetir()
    {
        try
        {
            connection.Open();
            string query = @"SELECT 
                         ogretmenIsim,
                         ogretmenSoyisim,
                         ogretmenBrans,
                         ogretmenID
                         FROM ogretmen 
                         WHERE ogretmenID = @ogretmenID";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ogretmenID", ogretmenID);

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lblOgretmenAd.Text = $"{reader["ogretmenIsim"]} {reader["ogretmenSoyisim"]}";
                lblBrans.Text = $"Branş: {reader["ogretmenBrans"]}";
                lblOgretmenNo.Text = $"Sicil No: {reader["ogretmenID"]}";
            }
            reader.Close();
        }
        catch (Exception ex)
        {
            XtraMessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            connection.Close();
        }
    }

    private void DersProgramiGetir()
    {
        try
        {
            connection.Open();
            string query = @"SELECT 
                         dp.gun as 'Gün',
                         TIME_FORMAT(dp.baslangicSaati,'%H:%i') as 'Başlangıç',
                         TIME_FORMAT(dp.bitisSaati,'%H:%i') as 'Bitiş',
                         d.dersIsmi as 'Ders',
                         s.sinifName as 'Sınıf'
                         FROM ders_programi dp 
                         JOIN ders d ON dp.dersID = d.dersID 
                         JOIN sinif s ON dp.sinifID = s.sinifID
                         WHERE dp.ogretmenID = @ogretmenID
                         ORDER BY dp.gun, dp.baslangicSaati";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ogretmenID", ogretmenID);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridDersProgrami.DataSource = dt;

            viewDersProgrami.Columns["Gün"].GroupIndex = 0;
            viewDersProgrami.BestFitColumns();
        }
        catch (Exception ex)
        {
            XtraMessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            connection.Close();
        }
    }

    private void SiniflarGetir()
    {
        try
        {
            connection.Open();
            string query = @"SELECT DISTINCT 
                         s.sinifName as 'Sınıf',
                         s.sinifStudentNumber as 'Öğrenci Sayısı',
                         s.sinifYear as 'Yıl'
                         FROM ders_programi dp 
                         JOIN sinif s ON dp.sinifID = s.sinifID 
                         WHERE dp.ogretmenID = @ogretmenID
                         ORDER BY s.sinifName";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ogretmenID", ogretmenID);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridSiniflar.DataSource = dt;
            viewSiniflar.BestFitColumns();
        }
        catch (Exception ex)
        {
            XtraMessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            connection.Close();
        }
    }

    private void HosGeldinOgretmen_Load_1(object sender, EventArgs e)
    {

    }
}