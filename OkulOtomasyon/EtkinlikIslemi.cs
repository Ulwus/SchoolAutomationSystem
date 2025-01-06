using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace OkulOtomasyon
{
    public partial class EtkinlikIslemi : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=okulotomasyon;Uid=root;Pwd=ulwus123;");

        public EtkinlikIslemi()
        {
            InitializeComponent();
            Listele();
        }

        public void Listele()
        {
            string komut = "SELECT * FROM etkinlik";
            MySqlDataAdapter da = new MySqlDataAdapter(komut, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            gridControl1.DataSource = ds.Tables[0];
        }

        private void EtkinlikIslemi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("etkinlikID") != null)
            {
                textEdit1.Text = gridView1.GetFocusedRowCellValue("etkinlikIsmi").ToString();
                textEdit2.Text = gridView1.GetFocusedRowCellValue("etkinlikAciklama").ToString();
                dateEdit1.DateTime = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("etkinlikTarihi"));
                textEdit4.Text = gridView1.GetFocusedRowCellValue("etkinlikYeri").ToString();
            }
        }

        public void Ekle()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO etkinlik (etkinlikIsmi, etkinlikAciklama, etkinlikTarihi, etkinlikYeri) " +
                    "VALUES (@etkinlikIsmi, @etkinlikAciklama, @etkinlikTarihi, @etkinlikYeri)",
                    connection))
                {
                    cmd.Parameters.AddWithValue("@etkinlikIsmi", textEdit1.Text);
                    cmd.Parameters.AddWithValue("@etkinlikAciklama", textEdit2.Text);
                    cmd.Parameters.AddWithValue("@etkinlikTarihi", dateEdit1.DateTime);
                    cmd.Parameters.AddWithValue("@etkinlikYeri", textEdit4.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Etkinlik başarıyla eklendi!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                connection.Close();
                Listele();
            }
        }

        public void Guncelle()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(
                    "UPDATE etkinlik SET etkinlikIsmi=@isim, etkinlikAciklama=@aciklama, " +
                    "etkinlikTarihi=@tarih, etkinlikYeri=@yer WHERE etkinlikID=@id",
                    connection))
                {
                    cmd.Parameters.AddWithValue("@id", gridView1.GetFocusedRowCellValue("etkinlikID"));
                    cmd.Parameters.AddWithValue("@isim", textEdit1.Text);
                    cmd.Parameters.AddWithValue("@aciklama", textEdit2.Text);
                    cmd.Parameters.AddWithValue("@tarih", dateEdit1.DateTime);
                    cmd.Parameters.AddWithValue("@yer", textEdit4.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Etkinlik bilgileri güncellendi!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                connection.Close();
                Listele();
            }
        }

        public void Sil()
        {
            try
            {
                if (gridView1.GetFocusedRowCellValue("etkinlikID") == null)
                {
                    MessageBox.Show("Lütfen silinecek etkinliği seçin!");
                    return;
                }

                DialogResult dr = MessageBox.Show("Etkinliği silmek istediğinizden emin misiniz?", "Onay",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    connection.Open();
                    string etkinlikID = gridView1.GetFocusedRowCellValue("etkinlikID").ToString();

                    using (MySqlCommand cmd = new MySqlCommand("DELETE FROM etkinlik WHERE etkinlikID = @id", connection))
                    {
                        cmd.Parameters.AddWithValue("@id", etkinlikID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Etkinlik başarıyla silindi!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                connection.Close();
                Listele();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Sil();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void EtkinlikIslemi_Load_1(object sender, EventArgs e)
        {

        }
    }
}