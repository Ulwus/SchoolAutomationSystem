using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

public partial class HosGeldinAdmin : Form
{
    private MySqlConnection connection;
    private int adminID;

    public HosGeldinAdmin(int adminID)
    {
        InitializeComponent();
        this.adminID = adminID;
        connection = new MySqlConnection("Server=localhost;Database=okulotomasyon;Uid=root;Pwd=ulwus123;");
        this.Load += HosGeldinAdmin_Load;
    }

    private void HosGeldinAdmin_Load(object sender, EventArgs e)
    {
        IstatistikleriGetir();
        SonEtkinlikleriGetir();
        SonKayitlariGetir();
    }

    private void IstatistikleriGetir()
    {
        try
        {
            connection.Open();

            string queryOgrenci = "SELECT COUNT(*) FROM ogrenci";
            MySqlCommand cmdOgrenci = new MySqlCommand(queryOgrenci, connection);
            int ogrenciSayisi = Convert.ToInt32(cmdOgrenci.ExecuteScalar());
            lblOgrenciSayisi.Text = $"TOPLAM ÖĞRENCİ\n{ogrenciSayisi}";

            string queryOgretmen = "SELECT COUNT(*) FROM ogretmen";
            MySqlCommand cmdOgretmen = new MySqlCommand(queryOgretmen, connection);
            int ogretmenSayisi = Convert.ToInt32(cmdOgretmen.ExecuteScalar());
            lblOgretmenSayisi.Text = $"TOPLAM ÖĞRETMEN\n{ogretmenSayisi}";

            string querySinif = "SELECT COUNT(*) FROM sinif";
            MySqlCommand cmdSinif = new MySqlCommand(querySinif, connection);
            int sinifSayisi = Convert.ToInt32(cmdSinif.ExecuteScalar());
            lblSinifSayisi.Text = $"TOPLAM SINIF\n{sinifSayisi}";
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

    private void SonEtkinlikleriGetir()
    {
        try
        {
            connection.Open();
            string query = @"SELECT 
                         etkinlikIsmi as 'Etkinlik',
                         DATE_FORMAT(etkinlikTarihi,'%d.%m.%Y') as 'Tarih',
                         etkinlikYeri as 'Yer',
                         etkinlikAciklama as 'Açıklama'
                         FROM etkinlik 
                         WHERE etkinlikTarihi >= CURDATE()
                         ORDER BY etkinlikTarihi 
                         LIMIT 10";

            MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridEtkinlikler.DataSource = dt;
            viewEtkinlikler.BestFitColumns();
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

    private void SonKayitlariGetir()
    {
        try
        {
            connection.Open();
            string query = @"(SELECT 'Öğrenci' as 'Tip', 
                           CONCAT(ogrenciIsmi,' ',ogrenciSoyismi) as 'Ad Soyad',
                           DATE_FORMAT(ogrenciYili,'%d.%m.%Y') as 'Kayıt Tarihi'
                           FROM ogrenci 
                           ORDER BY ogrenciYili DESC LIMIT 5)
                           UNION
                           (SELECT 'Öğretmen' as 'Tip',
                           CONCAT(ogretmenIsim,' ',ogretmenSoyisim) as 'Ad Soyad',
                           DATE_FORMAT(ogretmenIseBaslamaTarihi,'%d.%m.%Y') as 'Kayıt Tarihi'
                           FROM ogretmen 
                           ORDER BY ogretmenIseBaslamaTarihi DESC LIMIT 5)
                           ORDER BY 'Kayıt Tarihi' DESC";

            MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridKayitlar.DataSource = dt;
            viewKayitlar.BestFitColumns();
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