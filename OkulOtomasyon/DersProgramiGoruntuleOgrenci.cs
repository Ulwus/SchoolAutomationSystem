using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using MySql.Data.MySqlClient;

public partial class DersProgramiGoruntuleOgrenci : Form
{
    private MySqlConnection connection;
    private int ogrenciID;

    public DersProgramiGoruntuleOgrenci(int ogrID)
    {
        InitializeComponent();
        ogrenciID = ogrID;
        connection = new MySqlConnection("Server=localhost;Database=okulotomasyon;Uid=root;Pwd=ulwus123;");
        this.Load += DersProgramiGoruntuleOgrenci_Load;
    }

    private void DersProgramiGoruntuleOgrenci_Load(object sender, EventArgs e)
    {
        OgrenciBilgileriniGetir();
        DersProgramiGetir();
    }

    private void OgrenciBilgileriniGetir()
    {
        try
        {
            connection.Open();
            string query = @"SELECT o.*, s.sinifName
                           FROM ogrenci o
                           LEFT JOIN sinif s ON o.ogrenciSinif = s.sinifID
                           WHERE o.ogrenciID = @ogrenciID";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ogrenciID", ogrenciID);

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lblOgrenciAd.Text = $"{reader["ogrenciIsmi"]} {reader["ogrenciSoyismi"]}";
                lblSinif.Text = $"Sınıf: {reader["sinifName"]}";
                lblOgrenciNo.Text = $"Öğrenci No: {reader["ogrenciID"]}";
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
                           CONCAT(o.ogretmenIsim,' ',o.ogretmenSoyisim) as 'Öğretmen',
                           s.sinifName as 'Sınıf'
                           FROM ders_programi dp 
                           JOIN ders d ON dp.dersID = d.dersID 
                           JOIN ogretmen o ON dp.ogretmenID = o.ogretmenID 
                           JOIN sinif s ON dp.sinifID = s.sinifID
                           WHERE dp.sinifID = (SELECT ogrenciSinif FROM ogrenci WHERE ogrenciID = @ogrenciID)
                           ORDER BY dp.gun, dp.baslangicSaati";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ogrenciID", ogrenciID);

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
}