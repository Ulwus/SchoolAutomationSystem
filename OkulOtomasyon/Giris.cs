using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;

namespace OkulOtomasyon
{
    public partial class Giris : DevExpress.XtraEditors.XtraForm
    {

        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=okulotomasyon;Uid=root;Pwd=ulwus123;");

        public Giris()
        {
            InitializeComponent();
        }

        private void svgImageBox1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string userName = textEdit1.Text.Trim();
            string userPassword = textEdit2.Text.Trim();

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(userPassword))
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş olamaz.");
                return;
            }

            try
            {
                connection.Open();

                string query = "SELECT * FROM account WHERE userName = @userName AND userPassword = @userPassword";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.Parameters.AddWithValue("@userPassword", userPassword);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    int userId = Convert.ToInt32(dr["userId"]);

                    if (dr["userPassword"].ToString() == "123456")
                    {
                        ParolaDegis parolaDegis = new ParolaDegis(userId);
                        parolaDegis.Show();
                        this.Hide();

                    }
                    else
                    {
                        Panel panel = new Panel(userId);
                        panel.Show();
                        this.Hide();
                    }


                }
                else
                {
                    MessageBox.Show("Yanlış Giriş!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }
    }
}