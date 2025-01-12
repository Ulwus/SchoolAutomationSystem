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
using OkulOtomasyon.Models;

namespace OkulOtomasyon
{
    public partial class Giris : DevExpress.XtraEditors.XtraForm
    {
        Account account = new Account();


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
            account.UserName = userName;
            account.UserPassword = userPassword;
            

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(userPassword))
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş olamaz.");
                return;
            }

            try
            {



                if (account.ValidateLogin(account.UserName, account.UserPassword))
                {
                    

                    if (account.UserPassword == "123456")
                    {
                        ParolaDegis parolaDegis = new ParolaDegis(account);
                        parolaDegis.Show();
                        this.Hide();

                    }
                    else
                    {
                        Panel panel = new Panel(account);
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

        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }
    }
}