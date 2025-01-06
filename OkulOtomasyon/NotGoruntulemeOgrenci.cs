using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using MySql.Data.MySqlClient;

public partial class NotGoruntulemeOgrenci : Form
{
    private MySqlConnection connection;
    private int ogrenciID;

    public NotGoruntulemeOgrenci(int ogrID)
    {
        InitializeComponent();
        ogrenciID = ogrID;
        connection = new MySqlConnection("Server=localhost;Database=okulotomasyon;Uid=root;Pwd=ulwus123;");
        this.Load += NotGoruntulemeOgrenci_Load_1;
    }

    private void NotGoruntulemeOgrenci_Load_1(object sender, EventArgs e)
    {
        OgrenciBilgileriniGetir();
        NotlariGetir();
    }

    private void OgrenciBilgileriniGetir()
    {
        try
        {
            connection.Open();
            string query = @"SELECT o.*, s.sinifName,
                           (SELECT AVG(notDegeri) FROM notlar WHERE ogrenciID = o.ogrenciID) as NotOrtalamasi
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
                lblNotOrt.Text = $"Not Ortalaması: {reader["NotOrtalamasi"]:F2}";
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

    private void NotlariGetir()
    {
        try
        {
            connection.Open();
            string query = @"SELECT 
                       d.dersIsmi as 'Ders',
                       n.notDegeri as 'Not',
                       DATE_FORMAT(n.notTarihi,'%d.%m.%Y') as 'Tarih',
                       n.notID as 'Not ID',
                       d.dersID as 'Ders ID',
                       n.notTarihi
                       FROM (
                           SELECT DISTINCT dersID, ogrenciID, notID, notDegeri, notTarihi
                           FROM notlar
                           WHERE ogrenciID = @ogrenciID
                       ) n 
                       INNER JOIN ders d ON n.dersID = d.dersID 
                       ORDER BY n.notTarihi DESC, d.dersIsmi";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ogrenciID", ogrenciID);

            DataTable dt = new DataTable();
            new MySqlDataAdapter(cmd).Fill(dt);

            if (dt.Columns.Contains("notTarihi"))
                dt.Columns.Remove("notTarihi");

            gridNotlar.DataSource = dt;

            viewNotlar.Columns["Not ID"].Visible = false;
            viewNotlar.Columns["Ders ID"].Visible = false;
            viewNotlar.Columns["Ders"].GroupIndex = 0;
            viewNotlar.BestFitColumns();

            foreach (DevExpress.XtraGrid.Columns.GridColumn column in viewNotlar.Columns)
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
