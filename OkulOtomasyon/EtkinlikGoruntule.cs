using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using MySql.Data.MySqlClient;
using OkulOtomasyon.Models;

public partial class EtkinlikGoruntule : Form
{
    private DatabaseConnection dbConnection = DatabaseConnection.Instance;

    public EtkinlikGoruntule()
    {
        InitializeComponent();
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
            using (var connection = dbConnection.GetConnection())
            {
                string query = @"SELECT 
                         etkinlikIsmi as 'Etkinlik',
                         DATE_FORMAT(etkinlikTarihi,'%d.%m.%Y') as 'Tarih',
                         etkinlikYeri as 'Yer',
                         etkinlikAciklama as 'Açıklama'
                         FROM etkinlik 
                         WHERE etkinlikTarihi >= CURDATE()
                         ORDER BY etkinlikTarihi";

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