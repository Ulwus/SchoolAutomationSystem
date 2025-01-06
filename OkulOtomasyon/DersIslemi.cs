using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace OkulOtomasyon
{
    public partial class DersIslemi : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=okulotomasyon;Uid=root;Pwd=ulwus123;");

        public DersIslemi()
        {
            InitializeComponent();
            Listele();
        }

        public void Listele()
        {
            string komut = "SELECT * FROM ders";
            MySqlDataAdapter da = new MySqlDataAdapter(komut, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            gridControl1.DataSource = ds.Tables[0];
        }

        private void DersIslemi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("dersID") != null)
            {
                textEdit1.Text = gridView1.GetFocusedRowCellValue("dersIsmi").ToString();
                textEdit2.Text = gridView1.GetFocusedRowCellValue("dersAciklama").ToString();
                textEdit3.Text = gridView1.GetFocusedRowCellValue("dersSaat").ToString();
            }
        }

        public void Ekle()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO ders (dersIsmi, dersAciklama, dersSaat) VALUES (@dersIsmi, @dersAciklama, @dersSaat)",
                    connection))
                {
                    cmd.Parameters.AddWithValue("@dersIsmi", textEdit1.Text);
                    cmd.Parameters.AddWithValue("@dersAciklama", textEdit2.Text);
                    cmd.Parameters.AddWithValue("@dersSaat", textEdit3.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ders başarıyla eklendi!");
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
                    "UPDATE ders SET dersIsmi=@isim, dersAciklama=@aciklama, dersSaat=@saat WHERE dersID=@id",
                    connection))
                {
                    cmd.Parameters.AddWithValue("@id", gridView1.GetFocusedRowCellValue("dersID"));
                    cmd.Parameters.AddWithValue("@isim", textEdit1.Text);
                    cmd.Parameters.AddWithValue("@aciklama", textEdit2.Text);
                    cmd.Parameters.AddWithValue("@saat", textEdit3.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ders bilgileri güncellendi!");
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
                if (gridView1.GetFocusedRowCellValue("dersID") == null)
                {
                    MessageBox.Show("Lütfen silinecek dersi seçin!");
                    return;
                }

                DialogResult dr = MessageBox.Show("Dersi silmek istediğinizden emin misiniz?", "Onay",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    connection.Open();
                    string dersID = gridView1.GetFocusedRowCellValue("dersID").ToString();

                    using (MySqlCommand cmd = new MySqlCommand("DELETE FROM ders WHERE dersID = @id", connection))
                    {
                        cmd.Parameters.AddWithValue("@id", dersID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Ders başarıyla silindi!");
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
    }
}