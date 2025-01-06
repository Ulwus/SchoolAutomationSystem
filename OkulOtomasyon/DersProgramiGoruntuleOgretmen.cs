using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using MySql.Data.MySqlClient;

public partial class DersProgramiGoruntuleOgretmen : Form
{
    private MySqlConnection connection;
    private int ogretmenID;

    public DersProgramiGoruntuleOgretmen(int ogrID)
    {
        InitializeComponent();
        ogretmenID = ogrID;
        connection = new MySqlConnection("Server=localhost;Database=okulotomasyon;Uid=root;Pwd=ulwus123;");
        this.Load += DersProgramiGoruntuleOgretmen_Load;
    }

    private void DersProgramiGoruntuleOgretmen_Load(object sender, EventArgs e)
    {
        OgretmenBilgileriniGetir();
        DersProgramiGetir();
    }

    private void OgretmenBilgileriniGetir()
    {
        try
        {
            connection.Open();
            string query = @"SELECT o.*, 
                           (SELECT COUNT(DISTINCT d.dersID) FROM ders_programi d WHERE d.ogretmenID = o.ogretmenID) as DersSayisi
                           FROM ogretmen o
                           WHERE o.ogretmenID = @ogretmenID";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ogretmenID", ogretmenID);

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lblOgretmenAd.Text = $"{reader["ogretmenIsim"]} {reader["ogretmenSoyisim"]}";
                lblBrans.Text = $"Branş: {reader["ogretmenBrans"]}";
                lblDersSayisi.Text = $"Toplam Ders Sayısı: {reader["DersSayisi"]}";
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
                         s.sinifName as 'Sınıf',
                         CONCAT(s.sinifName, ' - ', d.dersIsmi) as 'Ders Bilgisi'
                         FROM ders_programi dp 
                         JOIN ders d ON dp.dersID = d.dersID 
                         JOIN sinif s ON dp.sinifID = s.sinifID
                         WHERE dp.ogretmenID = @ogretmenID
                         ORDER BY dp.gun, dp.baslangicSaati";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ogretmenID", ogretmenID);

            DataTable dt = new DataTable();
            new MySqlDataAdapter(cmd).Fill(dt);
            gridDersProgrami.DataSource = dt;

            viewDersProgrami.Columns["Gün"].GroupIndex = 0;
            viewDersProgrami.BestFitColumns();

            foreach (DevExpress.XtraGrid.Columns.GridColumn column in viewDersProgrami.Columns)
            {
                column.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }
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

    private void grpDersProgrami_Paint(object sender, PaintEventArgs e)
    {

    }
}