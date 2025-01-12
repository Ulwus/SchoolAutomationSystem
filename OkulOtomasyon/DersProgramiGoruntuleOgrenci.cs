using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using MySql.Data.MySqlClient;
using OkulOtomasyon.Models;

public partial class DersProgramiGoruntuleOgrenci : Form
{
    private DatabaseConnection dbConnection = DatabaseConnection.Instance;
    private int ogrenciID;
    Account account;
    Student student;

    public DersProgramiGoruntuleOgrenci(Account account)
    {
        InitializeComponent();
        this.account = account;
        ogrenciID = account.UserAttachID;
        student = Student.GetById(ogrenciID);
        this.Load += DersProgramiGoruntuleOgrenci_Load;
    }

    private void DersProgramiGoruntuleOgrenci_Load(object sender, EventArgs e)
    {
        OgrenciBilgileriniGetir();
        DersProgramiGetir();
    }

    private void OgrenciBilgileriniGetir()
    {

        lblOgrenciAd.Text = student.OgrenciIsmi + " " + student.OgrenciSoyismi;
        lblSinif.Text = Convert.ToString(student.OgrenciSinif);
        lblOgrenciNo.Text = Convert.ToString(student.OgrenciID);
        
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