using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

partial class DersProgramiGoruntuleOgretmen
{
    private System.ComponentModel.IContainer components = null;

    private PanelControl pnlUst;
    private LabelControl lblBaslik;
    private GroupControl grpOgretmenBilgi;
    private LabelControl lblOgretmenAd;
    private LabelControl lblBrans;
    private LabelControl lblDersSayisi;
    private GroupControl grpDersProgrami;
    private GridControl gridDersProgrami;
    private GridView viewDersProgrami;

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
            this.grpOgretmenBilgi = new DevExpress.XtraEditors.GroupControl();
            this.lblOgretmenAd = new DevExpress.XtraEditors.LabelControl();
            this.lblBrans = new DevExpress.XtraEditors.LabelControl();
            this.lblDersSayisi = new DevExpress.XtraEditors.LabelControl();
            this.grpDersProgrami = new DevExpress.XtraEditors.GroupControl();
            this.gridDersProgrami = new DevExpress.XtraGrid.GridControl();
            this.viewDersProgrami = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnlUst)).BeginInit();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpOgretmenBilgi)).BeginInit();
            this.grpOgretmenBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpDersProgrami)).BeginInit();
            this.grpDersProgrami.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDersProgrami)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDersProgrami)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pnlUst.Appearance.Options.UseBackColor = true;
            this.pnlUst.Controls.Add(this.lblBaslik);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1200, 60);
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
            this.lblBaslik.Size = new System.Drawing.Size(153, 25);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "DERS PROGRAMI";
            // 
            // grpOgretmenBilgi
            // 
            this.grpOgretmenBilgi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOgretmenBilgi.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpOgretmenBilgi.Appearance.Options.UseFont = true;
            this.grpOgretmenBilgi.Controls.Add(this.simpleButton1);
            this.grpOgretmenBilgi.Controls.Add(this.lblOgretmenAd);
            this.grpOgretmenBilgi.Controls.Add(this.lblBrans);
            this.grpOgretmenBilgi.Controls.Add(this.lblDersSayisi);
            this.grpOgretmenBilgi.Location = new System.Drawing.Point(20, 70);
            this.grpOgretmenBilgi.Name = "grpOgretmenBilgi";
            this.grpOgretmenBilgi.Size = new System.Drawing.Size(1160, 100);
            this.grpOgretmenBilgi.TabIndex = 1;
            this.grpOgretmenBilgi.Text = "ÖĞRETMEN BİLGİLERİ";
            // 
            // lblOgretmenAd
            // 
            this.lblOgretmenAd.Location = new System.Drawing.Point(20, 30);
            this.lblOgretmenAd.Name = "lblOgretmenAd";
            this.lblOgretmenAd.Size = new System.Drawing.Size(0, 13);
            this.lblOgretmenAd.TabIndex = 0;
            // 
            // lblBrans
            // 
            this.lblBrans.Location = new System.Drawing.Point(20, 55);
            this.lblBrans.Name = "lblBrans";
            this.lblBrans.Size = new System.Drawing.Size(0, 13);
            this.lblBrans.TabIndex = 1;
            // 
            // lblDersSayisi
            // 
            this.lblDersSayisi.Location = new System.Drawing.Point(20, 80);
            this.lblDersSayisi.Name = "lblDersSayisi";
            this.lblDersSayisi.Size = new System.Drawing.Size(0, 13);
            this.lblDersSayisi.TabIndex = 2;
            // 
            // grpDersProgrami
            // 
            this.grpDersProgrami.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDersProgrami.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpDersProgrami.Appearance.Options.UseFont = true;
            this.grpDersProgrami.Controls.Add(this.gridDersProgrami);
            this.grpDersProgrami.Location = new System.Drawing.Point(20, 180);
            this.grpDersProgrami.Name = "grpDersProgrami";
            this.grpDersProgrami.Size = new System.Drawing.Size(1160, 500);
            this.grpDersProgrami.TabIndex = 2;
            this.grpDersProgrami.Text = "DERS PROGRAMI";
            this.grpDersProgrami.Paint += new System.Windows.Forms.PaintEventHandler(this.grpDersProgrami_Paint);
            // 
            // gridDersProgrami
            // 
            this.gridDersProgrami.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDersProgrami.Location = new System.Drawing.Point(2, 23);
            this.gridDersProgrami.MainView = this.viewDersProgrami;
            this.gridDersProgrami.Name = "gridDersProgrami";
            this.gridDersProgrami.Size = new System.Drawing.Size(1156, 475);
            this.gridDersProgrami.TabIndex = 0;
            this.gridDersProgrami.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewDersProgrami});
            // 
            // viewDersProgrami
            // 
            this.viewDersProgrami.GridControl = this.gridDersProgrami;
            this.viewDersProgrami.Name = "viewDersProgrami";
            this.viewDersProgrami.OptionsBehavior.Editable = false;
            this.viewDersProgrami.OptionsView.ShowGroupPanel = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Location = new System.Drawing.Point(1009, 20);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(151, 80);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Pdf Çıktısı Al";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // DersProgramiGoruntuleOgretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.pnlUst);
            this.Controls.Add(this.grpOgretmenBilgi);
            this.Controls.Add(this.grpDersProgrami);
            this.Name = "DersProgramiGoruntuleOgretmen";
            this.Text = "Öğretmen Ders Programı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pnlUst)).EndInit();
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpOgretmenBilgi)).EndInit();
            this.grpOgretmenBilgi.ResumeLayout(false);
            this.grpOgretmenBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpDersProgrami)).EndInit();
            this.grpDersProgrami.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDersProgrami)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDersProgrami)).EndInit();
            this.ResumeLayout(false);

    }

    private SimpleButton simpleButton1;
}