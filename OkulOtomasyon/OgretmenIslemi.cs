using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace OkulOtomasyon
{
    public partial class OgretmenIslemi : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=okulotomasyon;Uid=root;Pwd=ulwus123;");

        public OgretmenIslemi()
        {
            InitializeComponent();
            Listele();
        }

        public void Listele()
        {
            string komut = "SELECT * FROM ogretmen";
            MySqlDataAdapter da = new MySqlDataAdapter(komut, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            gridControl1.DataSource = ds.Tables[0];
        }

        private void OgretmenIslemi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void simpleButton1_Click_1  (object sender, EventArgs e)
        {
            Ekle();
        }




        private void gridControl1_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("ogretmenID") != null)
            {
                textEdit1.Text = gridView1.GetFocusedRowCellValue("ogretmenIsim").ToString();
                textEdit2.Text = gridView1.GetFocusedRowCellValue("ogretmenSoyisim").ToString();
                textEdit3.Text = gridView1.GetFocusedRowCellValue("ogretmenTelefon").ToString();
                textEdit4.Text = gridView1.GetFocusedRowCellValue("ogretmenEmail").ToString();
                comboBoxEdit1.Text = gridView1.GetFocusedRowCellValue("ogretmenBrans").ToString();
            }
        }

        public void Ekle()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                int ogretmenID = -1;

                using (MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO ogretmen (ogretmenIsim, ogretmenSoyisim, ogretmenTelefon, ogretmenEmail, ogretmenBrans, ogretmenIseBaslamaTarihi) VALUES " +
                    "(@ogretmenIsim, @ogretmenSoyisim, @ogretmenTelefon, @ogretmenEmail, @ogretmenBrans, @ogretmenIseBaslamaTarihi); SELECT LAST_INSERT_ID();",
                    connection))
                {
                    cmd.Parameters.AddWithValue("@ogretmenIsim", textEdit1.Text);
                    cmd.Parameters.AddWithValue("@ogretmenSoyisim", textEdit2.Text);
                    cmd.Parameters.AddWithValue("@ogretmenTelefon", textEdit3.Text);
                    cmd.Parameters.AddWithValue("@ogretmenEmail", textEdit4.Text);
                    cmd.Parameters.AddWithValue("@ogretmenBrans", comboBoxEdit1.Text);
                    cmd.Parameters.AddWithValue("@ogretmenIseBaslamaTarihi", DateTime.Now);

                    ogretmenID = Convert.ToInt32(cmd.ExecuteScalar());
                }

                using (MySqlCommand cmdAccount = new MySqlCommand(
                    "INSERT INTO account (userName, userPassword, userPermission, userAttachID) VALUES " +
                    "(@userName, @userPassword, @userPermission, @userAttachID)", connection))
                {
                    cmdAccount.Parameters.AddWithValue("@userName", textEdit3.Text);
                    cmdAccount.Parameters.AddWithValue("@userPassword", "123456");
                    cmdAccount.Parameters.AddWithValue("@userPermission", 1);
                    cmdAccount.Parameters.AddWithValue("@userAttachID", ogretmenID);

                    cmdAccount.ExecuteNonQuery();
                    MessageBox.Show("Öğretmen başarıyla eklendi!");
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
                    "UPDATE ogretmen SET ogretmenIsim=@isim, ogretmenSoyisim=@soyisim, " +
                    "ogretmenTelefon=@telefon, ogretmenEmail=@email, ogretmenBrans=@brans " +
                    "WHERE ogretmenID=@id", connection))
                {
                    cmd.Parameters.AddWithValue("@id", gridView1.GetFocusedRowCellValue("ogretmenID"));
                    cmd.Parameters.AddWithValue("@isim", textEdit1.Text);
                    cmd.Parameters.AddWithValue("@soyisim", textEdit2.Text);
                    cmd.Parameters.AddWithValue("@telefon", textEdit3.Text);
                    cmd.Parameters.AddWithValue("@email", textEdit4.Text);
                    cmd.Parameters.AddWithValue("@brans", comboBoxEdit1.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Öğretmen bilgileri güncellendi!");
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
                if (gridView1.GetFocusedRowCellValue("ogretmenID") == null)
                {
                    MessageBox.Show("Lütfen silinecek öğretmeni seçin!");
                    return;
                }

                DialogResult dr = MessageBox.Show("Öğretmeni silmek istediğinizden emin misiniz?", "Onay",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    connection.Open();
                    string ogretmenID = gridView1.GetFocusedRowCellValue("ogretmenID").ToString();

                    using (MySqlCommand cmd = new MySqlCommand("DELETE FROM ogretmen WHERE ogretmenID = @id", connection))
                    {
                        cmd.Parameters.AddWithValue("@id", ogretmenID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Öğretmen başarıyla silindi!");
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

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            Sil();
        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            Guncelle();
        }
    }
}