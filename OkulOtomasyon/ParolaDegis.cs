using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DevExpress.XtraEditors;
using OkulOtomasyon.Models;

namespace OkulOtomasyon
{
    public partial class ParolaDegis : Form
    {
        private Account account;

        public ParolaDegis(Account account)
        {
            InitializeComponent();
            this.account = account;

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
                if (account.ChangePassword(txtEskiParola.Text, txtYeniParola1.Text))
                {
                    XtraMessageBox.Show("Şifre Başarıyla Değiştirildi", "Onay",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Panel panel = new Panel(account);
                    panel.FormClosed += (s, args) => this.Close(); // Panel kapandığında bu formu da kapat
                    account.UserPassword = txtYeniParola1.Text;
                    panel.Show();
                    this.Close();
                    
                }
                else
                {
                    XtraMessageBox.Show("Şifre Yanlış", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata oluştu: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}