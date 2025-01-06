using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DevExpress.XtraEditors;

namespace OkulOtomasyon
{
    public partial class ParolaDegis : Form
    {
        private MySqlConnection connection;
        private int userId;

        public ParolaDegis(int userID)
        {
            InitializeComponent();
            userId = userID;
            connection = new MySqlConnection("Server=localhost;Database=okulotomasyon;Uid=root;Pwd=ulwus123;");

            btnDegistir.Click += BtnDegistir_Click;
            txtYeniParola2.KeyPress += TxtYeniParola2_KeyPress;
            chkParolaGoster.CheckedChanged += ChkParolaGoster_CheckedChanged;
        }

        private void ChkParolaGoster_CheckedChanged(object sender, EventArgs e)
        {
            bool goster = chkParolaGoster.Checked;
            txtEskiParola.Properties.UseSystemPasswordChar = !goster;
            txtYeniParola1.Properties.UseSystemPasswordChar = !goster;
            txtYeniParola2.Properties.UseSystemPasswordChar = !goster;
        }

        private void TxtYeniParola2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnDegistir_Click(sender, e);
            }
        }

        private void BtnDegistir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEskiParola.Text) ||
                string.IsNullOrEmpty(txtYeniParola1.Text) ||
                string.IsNullOrEmpty(txtYeniParola2.Text))
            {
                XtraMessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtYeniParola1.Text != txtYeniParola2.Text)
            {
                XtraMessageBox.Show("Yeni parolalar eşleşmiyor!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                connection.Open();

                string checkQuery = "SELECT COUNT(*) FROM account WHERE userId = @userId AND userPassword = @oldPass";
                using (var cmd = new MySqlCommand(checkQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@oldPass", txtEskiParola.Text);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count == 0)
                    {
                        XtraMessageBox.Show("Eski parola yanlış!", "Hata",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string updateQuery = "UPDATE account SET userPassword = @newPass WHERE userId = @userId";
                using (var cmd = new MySqlCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@newPass", txtYeniParola1.Text);
                    cmd.ExecuteNonQuery();
                }

                XtraMessageBox.Show("Parola başarıyla değiştirildi!", "Başarılı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Panel panel = new Panel(userId);
                panel.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata oluştu: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }


    }
}