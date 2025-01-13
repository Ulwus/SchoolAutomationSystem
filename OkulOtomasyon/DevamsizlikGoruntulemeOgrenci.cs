using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using MySql.Data.MySqlClient;
using OkulOtomasyon.Models;

public partial class DevamsizlikGoruntulemeOgrenci : Form
{
    private DatabaseConnection dbConnection = DatabaseConnection.Instance;
    private int ogrenciID;
    Student student;
    Account account;

    public DevamsizlikGoruntulemeOgrenci(Account account)
    {
        InitializeComponent();
        this.account = account;
        ogrenciID = account.UserAttachID;
        student = Student.GetById(ogrenciID);

        this.Load += DevamsizlikGoruntulemeOgrenci_Load;
    }

    private void DevamsizlikGoruntulemeOgrenci_Load(object sender, EventArgs e)
    {
        OgrenciBilgileriniGetir();
        DevamsizliklariGetir();
    }

    private void OgrenciBilgileriniGetir()
    {
        lblOgrenciAd.Text = "Öğrenci İsmi: " + student.OgrenciIsmi + " " + student.OgrenciSoyismi;
        lblSinif.Text = "Öğrenci Sınıfı: " + Convert.ToString(student.OgrenciSinif);
        lblOgrenciNo.Text = "Öğrenci Numarası: " + Convert.ToString(student.OgrenciID);
        try
        {
            using (var connection = dbConnection.GetConnection())
            {
                string query = @"SELECT o.*, s.sinifName,
                           (SELECT COUNT(*) FROM devamsizlik WHERE ogrenciID = o.ogrenciID) as ToplamDevamsizlik
                           FROM ogrenci o
                           LEFT JOIN sinif s ON o.ogrenciSinif = s.sinifID
                           WHERE o.ogrenciID = @ogrenciID";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ogrenciID", ogrenciID);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    
                    lblToplamDevamsizlik.Text = $"Toplam Devamsızlık: {reader["ToplamDevamsizlik"]} gün";
                }
                reader.Close();
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

    private void DevamsizliklariGetir()
    {
        try
        {
            using (var connection = dbConnection.GetConnection())
            {
                string query = @"SELECT 
                           d.devamsizlikID as 'Devamsızlık No',
                           DATE_FORMAT(d.devamsizlikTarihi,'%d.%m.%Y') as 'Tarih',
                           dr.dersIsmi as 'Ders',
                           CASE d.durum 
                               WHEN 1 THEN 'Tam Gün'
                               WHEN 0.5 THEN 'Yarım Gün'
                               ELSE 'Belirtilmemiş'
                           END as 'Durum'
                           FROM devamsizlik d
                           JOIN ders dr ON d.dersID = dr.dersID
                           WHERE d.ogrenciID = @ogrenciID
                           ORDER BY d.devamsizlikTarihi DESC";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ogrenciID", ogrenciID);

                DataTable dt = new DataTable();
                new MySqlDataAdapter(cmd).Fill(dt);
                gridDevamsizlik.DataSource = dt;
                viewDevamsizlik.BestFitColumns();

                foreach (DevExpress.XtraGrid.Columns.GridColumn column in viewDevamsizlik.Columns)
                {
                    column.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
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
}