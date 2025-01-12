using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using OkulOtomasyon.Models;

namespace OkulOtomasyon
{
    public partial class DersIslemi : Form
    {
        private DatabaseConnection dbConnection = DatabaseConnection.Instance;

        public DersIslemi()
        {
            InitializeComponent();
            Listele();
        }

        public void Listele()
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    string komut = "SELECT * FROM ders";
                    MySqlDataAdapter da = new MySqlDataAdapter(komut, connection);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    gridControl1.DataSource = ds.Tables[0];
                }
            }
            finally
            {
                dbConnection.CloseConnection();
            }
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
                using (var connection = dbConnection.GetConnection())
                {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
                Listele();
            }
        }

        public void Guncelle()
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
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
                    using (var connection = dbConnection.GetConnection())
                    {
                        string dersID = gridView1.GetFocusedRowCellValue("dersID").ToString();

                        using (MySqlCommand cmd = new MySqlCommand("DELETE FROM ders WHERE dersID = @id", connection))
                        {
                            cmd.Parameters.AddWithValue("@id", dersID);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Ders başarıyla silindi!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
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