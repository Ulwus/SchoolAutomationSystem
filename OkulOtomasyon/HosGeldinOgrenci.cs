using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using OkulOtomasyon.Models;

public partial class HosGeldinOgrenci : Form
{
    private DatabaseConnection dbConnection = DatabaseConnection.Instance;
    private int ogrenciID;
    Account account;
    Student student;

    public HosGeldinOgrenci(Account account)
    {
        InitializeComponent();
        this.account = account;
        ogrenciID = account.UserAttachID;
        this.Load += HosGeldinOgrenci_Load;
    }

    private void HosGeldinOgrenci_Load(object sender, EventArgs e)
    {
        student = Student.GetById(ogrenciID);

        OgrenciBilgileriniGetir();
        DersProgramiGetir();
        NotlariGetir();
        YaklasanEtkinlikleriGetir();
    }

    private void OgrenciBilgileriniGetir()
    {

        lblOgrenciAd.Text = student.OgrenciIsmi + " " + student.OgrenciSoyismi;
        lblSinif.Text = Convert.ToString(student.OgrenciSinif);
        lblOgrenciNo.Text = Convert.ToString(student.OgrenciID);

        try
        {
            using (var connection = dbConnection.GetConnection())
            {
                string query = @"SELECT o.*, 
                         (SELECT COUNT(*) FROM devamsizlik d WHERE d.ogrenciID = o.ogrenciID) as DevamsizlikSayisi,
                         (SELECT AVG(notDegeri) FROM notlar n WHERE n.ogrenciID = o.ogrenciID) as NotOrtalamasi,
                         s.sinifName
                         FROM ogrenci o
                         LEFT JOIN sinif s ON o.ogrenciSinif = s.sinifID
                         WHERE o.ogrenciID = @ogrenciID";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ogrenciID", ogrenciID);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    
                    lblNotOrt.Text = $"Not Ortalaması: {reader["NotOrtalamasi"]:F2}";
                    lblDevamsizlik.Text = $"Toplam Devamsızlık: {reader["DevamsizlikSayisi"]} gün";
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

    private void DersProgramiGetir()
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
                         CONCAT(o.ogretmenIsim,' ',o.ogretmenSoyisim) as 'Öğretmen'
                         FROM ders_programi dp 
                         JOIN ders d ON dp.dersID = d.dersID 
                         JOIN ogretmen o ON dp.ogretmenID = o.ogretmenID 
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

    private void NotlariGetir()
    {
        try
        {
            using (var connection = dbConnection.GetConnection())
            {
                string query = @"SELECT 
                         d.dersIsmi as 'Ders',
                         n.notDegeri as 'Not',
                         DATE_FORMAT(n.notTarihi,'%d.%m.%Y') as 'Tarih'
                         FROM notlar n 
                         JOIN ders d ON n.dersID = d.dersID 
                         WHERE n.ogrenciID = @ogrenciID
                         ORDER BY n.notTarihi DESC";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ogrenciID", ogrenciID);

                DataTable dt = new DataTable();
                new MySqlDataAdapter(cmd).Fill(dt);
                gridNotlar.DataSource = dt;
                viewNotlar.BestFitColumns();

                foreach (DevExpress.XtraGrid.Columns.GridColumn column in viewNotlar.Columns)
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

    private void YaklasanEtkinlikleriGetir()
    {
        try
        {
            using (var connection = dbConnection.GetConnection())
            {
                string query = @"SELECT 
                         etkinlikIsmi as 'Etkinlik',
                         DATE_FORMAT(etkinlikTarihi,'%d.%m.%Y') as 'Tarih',
                         etkinlikYeri as 'Yer',
                         etkinlikAciklama as 'Açıklama'
                         FROM etkinlik 
                         WHERE etkinlikTarihi >= CURDATE()
                         ORDER BY etkinlikTarihi 
                         LIMIT 5";

                MySqlCommand cmd = new MySqlCommand(query, connection); // Bağlantıyı ekledik
                
                DataTable dt = new DataTable();
                new MySqlDataAdapter(cmd).Fill(dt);
                gridEtkinlikler.DataSource = dt;
                viewEtkinlikler.BestFitColumns();

                foreach (DevExpress.XtraGrid.Columns.GridColumn column in viewEtkinlikler.Columns)
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