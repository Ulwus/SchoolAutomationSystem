using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using MySql.Data.MySqlClient;

public partial class EtkinlikGoruntule : Form
{
    private MySqlConnection connection;

    public EtkinlikGoruntule()
    {
        InitializeComponent();
        connection = new MySqlConnection("Server=localhost;Database=okulotomasyon;Uid=root;Pwd=ulwus123;");
        this.Load += EtkinlikGoruntule_Load;
    }

    private void EtkinlikGoruntule_Load(object sender, EventArgs e)
    {
        EtkinlikleriGetir();
    }

    private void EtkinlikleriGetir()
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
                         ";

            MySqlCommand cmd = new MySqlCommand(query, connection);

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