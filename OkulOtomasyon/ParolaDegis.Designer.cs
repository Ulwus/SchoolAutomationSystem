namespace OkulOtomasyon
{
    partial class ParolaDegis
    {
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.PanelControl pnlUst;
        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl grpParola;
        private DevExpress.XtraEditors.TextEdit txtEskiParola;
        private DevExpress.XtraEditors.TextEdit txtYeniParola1;
        private DevExpress.XtraEditors.TextEdit txtYeniParola2;
        private DevExpress.XtraEditors.LabelControl lblEskiParola;
        private DevExpress.XtraEditors.LabelControl lblYeniParola1;
        private DevExpress.XtraEditors.LabelControl lblYeniParola2;
        private DevExpress.XtraEditors.SimpleButton btnDegistir;
        private DevExpress.XtraEditors.CheckEdit chkParolaGoster;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlUst = new DevExpress.XtraEditors.PanelControl();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grpParola = new DevExpress.XtraEditors.GroupControl();
            this.txtEskiParola = new DevExpress.XtraEditors.TextEdit();
            this.txtYeniParola1 = new DevExpress.XtraEditors.TextEdit();
            this.txtYeniParola2 = new DevExpress.XtraEditors.TextEdit();
            this.lblEskiParola = new DevExpress.XtraEditors.LabelControl();
            this.lblYeniParola1 = new DevExpress.XtraEditors.LabelControl();
            this.lblYeniParola2 = new DevExpress.XtraEditors.LabelControl();
            this.chkParolaGoster = new DevExpress.XtraEditors.CheckEdit();
            this.btnDegistir = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnlUst)).BeginInit();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpParola)).BeginInit();
            this.grpParola.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEskiParola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYeniParola1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYeniParola2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkParolaGoster.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pnlUst.Appearance.Options.UseBackColor = true;
            this.pnlUst.Controls.Add(this.lblBaslik);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(894, 60);
            this.pnlUst.TabIndex = 0;
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Appearance.Options.UseFont = true;
            this.lblBaslik.Appearance.Options.UseForeColor = true;
            this.lblBaslik.Location = new System.Drawing.Point(20, 20);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(164, 25);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "PAROLA DEĞİŞTİR";
            // 
            // grpParola
            // 
            this.grpParola.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpParola.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.grpParola.Appearance.Options.UseBackColor = true;
            this.grpParola.AppearanceCaption.ForeColor = System.Drawing.Color.White;
            this.grpParola.AppearanceCaption.Options.UseForeColor = true;
            this.grpParola.Controls.Add(this.txtEskiParola);
            this.grpParola.Controls.Add(this.txtYeniParola1);
            this.grpParola.Controls.Add(this.txtYeniParola2);
            this.grpParola.Controls.Add(this.lblEskiParola);
            this.grpParola.Controls.Add(this.lblYeniParola1);
            this.grpParola.Controls.Add(this.lblYeniParola2);
            this.grpParola.Controls.Add(this.chkParolaGoster);
            this.grpParola.Location = new System.Drawing.Point(20, 114);
            this.grpParola.Name = "grpParola";
            this.grpParola.Size = new System.Drawing.Size(854, 200);
            this.grpParola.TabIndex = 1;
            this.grpParola.Text = "Parola Bilgileri";
            // 
            // txtEskiParola
            // 
            this.txtEskiParola.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEskiParola.Location = new System.Drawing.Point(150, 37);
            this.txtEskiParola.Name = "txtEskiParola";
            this.txtEskiParola.Properties.UseSystemPasswordChar = true;
            this.txtEskiParola.Size = new System.Drawing.Size(674, 20);
            this.txtEskiParola.TabIndex = 0;
            // 
            // txtYeniParola1
            // 
            this.txtYeniParola1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYeniParola1.Location = new System.Drawing.Point(150, 77);
            this.txtYeniParola1.Name = "txtYeniParola1";
            this.txtYeniParola1.Properties.UseSystemPasswordChar = true;
            this.txtYeniParola1.Size = new System.Drawing.Size(674, 20);
            this.txtYeniParola1.TabIndex = 1;
            // 
            // txtYeniParola2
            // 
            this.txtYeniParola2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYeniParola2.Location = new System.Drawing.Point(150, 117);
            this.txtYeniParola2.Name = "txtYeniParola2";
            this.txtYeniParola2.Properties.UseSystemPasswordChar = true;
            this.txtYeniParola2.Size = new System.Drawing.Size(674, 20);
            this.txtYeniParola2.TabIndex = 2;
            // 
            // lblEskiParola
            // 
            this.lblEskiParola.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblEskiParola.Appearance.Options.UseForeColor = true;
            this.lblEskiParola.Location = new System.Drawing.Point(20, 40);
            this.lblEskiParola.Name = "lblEskiParola";
            this.lblEskiParola.Size = new System.Drawing.Size(55, 13);
            this.lblEskiParola.TabIndex = 3;
            this.lblEskiParola.Text = "Eski Parola:";
            // 
            // lblYeniParola1
            // 
            this.lblYeniParola1.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblYeniParola1.Appearance.Options.UseForeColor = true;
            this.lblYeniParola1.Location = new System.Drawing.Point(20, 80);
            this.lblYeniParola1.Name = "lblYeniParola1";
            this.lblYeniParola1.Size = new System.Drawing.Size(57, 13);
            this.lblYeniParola1.TabIndex = 4;
            this.lblYeniParola1.Text = "Yeni Parola:";
            // 
            // lblYeniParola2
            // 
            this.lblYeniParola2.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblYeniParola2.Appearance.Options.UseForeColor = true;
            this.lblYeniParola2.Location = new System.Drawing.Point(20, 120);
            this.lblYeniParola2.Name = "lblYeniParola2";
            this.lblYeniParola2.Size = new System.Drawing.Size(99, 13);
            this.lblYeniParola2.TabIndex = 5;
            this.lblYeniParola2.Text = "Yeni Parola (Tekrar):";
            // 
            // chkParolaGoster
            // 
            this.chkParolaGoster.Location = new System.Drawing.Point(150, 150);
            this.chkParolaGoster.Name = "chkParolaGoster";
            this.chkParolaGoster.Properties.Caption = "Parolayı Göster";
            this.chkParolaGoster.Size = new System.Drawing.Size(180, 18);
            this.chkParolaGoster.TabIndex = 6;
            // 
            // btnDegistir
            // 
            this.btnDegistir.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnDegistir.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDegistir.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnDegistir.Appearance.Options.UseBackColor = true;
            this.btnDegistir.Appearance.Options.UseFont = true;
            this.btnDegistir.Appearance.Options.UseForeColor = true;
            this.btnDegistir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDegistir.Location = new System.Drawing.Point(0, 480);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(894, 40);
            this.btnDegistir.TabIndex = 2;
            this.btnDegistir.Text = "DEĞİŞTİR";
            this.btnDegistir.Click += new System.EventHandler(this.BtnDegistir_Click);
            // 
            // ParolaDegis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(894, 520);
            this.Controls.Add(this.pnlUst);
            this.Controls.Add(this.grpParola);
            this.Controls.Add(this.btnDegistir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ParolaDegis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parola Değiştir";
            ((System.ComponentModel.ISupportInitialize)(this.pnlUst)).EndInit();
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpParola)).EndInit();
            this.grpParola.ResumeLayout(false);
            this.grpParola.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEskiParola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYeniParola1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYeniParola2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkParolaGoster.Properties)).EndInit();
            this.ResumeLayout(false);

        }
    }
}