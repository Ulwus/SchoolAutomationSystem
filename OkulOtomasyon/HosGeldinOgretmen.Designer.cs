using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

partial class HosGeldinOgretmen
{
    private System.ComponentModel.IContainer components = null;

    private PanelControl pnlUst;
    private LabelControl lblBaslik;
    private GroupControl grpOgretmenBilgi;
    private LabelControl lblOgretmenAd;
    private LabelControl lblBrans;
    private LabelControl lblOgretmenNo;
    private GroupControl grpDersProgrami;
    private GridControl gridDersProgrami;
    private GridView viewDersProgrami;
    private GroupControl grpSiniflar;
    private GridControl gridSiniflar;
    private GridView viewSiniflar;

    private void InitializeComponent()
    {
            this.pnlUst = new DevExpress.XtraEditors.PanelControl();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grpOgretmenBilgi = new DevExpress.XtraEditors.GroupControl();
            this.lblOgretmenAd = new DevExpress.XtraEditors.LabelControl();
            this.lblBrans = new DevExpress.XtraEditors.LabelControl();
            this.lblOgretmenNo = new DevExpress.XtraEditors.LabelControl();
            this.grpDersProgrami = new DevExpress.XtraEditors.GroupControl();
            this.gridDersProgrami = new DevExpress.XtraGrid.GridControl();
            this.viewDersProgrami = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grpSiniflar = new DevExpress.XtraEditors.GroupControl();
            this.gridSiniflar = new DevExpress.XtraGrid.GridControl();
            this.viewSiniflar = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.pnlUst)).BeginInit();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpOgretmenBilgi)).BeginInit();
            this.grpOgretmenBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpDersProgrami)).BeginInit();
            this.grpDersProgrami.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDersProgrami)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDersProgrami)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSiniflar)).BeginInit();
            this.grpSiniflar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSiniflar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSiniflar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pnlUst.Appearance.Options.UseBackColor = true;
            this.pnlUst.Controls.Add(this.lblBaslik);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.pnlUst.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1184, 60);
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
            this.lblBaslik.Size = new System.Drawing.Size(236, 25);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "HOŞGELDİNİZ ÖĞRETMEN";
            // 
            // grpOgretmenBilgi
            // 
            this.grpOgretmenBilgi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOgretmenBilgi.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpOgretmenBilgi.Appearance.Options.UseFont = true;
            this.grpOgretmenBilgi.Controls.Add(this.lblOgretmenAd);
            this.grpOgretmenBilgi.Controls.Add(this.lblBrans);
            this.grpOgretmenBilgi.Controls.Add(this.lblOgretmenNo);
            this.grpOgretmenBilgi.Location = new System.Drawing.Point(20, 70);
            this.grpOgretmenBilgi.Name = "grpOgretmenBilgi";
            this.grpOgretmenBilgi.Size = new System.Drawing.Size(1160, 124);
            this.grpOgretmenBilgi.TabIndex = 1;
            this.grpOgretmenBilgi.Text = "ÖĞRETMEN BİLGİLERİ";
            // 
            // lblOgretmenAd
            // 
            this.lblOgretmenAd.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblOgretmenAd.Appearance.Options.UseFont = true;
            this.lblOgretmenAd.Location = new System.Drawing.Point(20, 30);
            this.lblOgretmenAd.Name = "lblOgretmenAd";
            this.lblOgretmenAd.Size = new System.Drawing.Size(0, 21);
            this.lblOgretmenAd.TabIndex = 0;
            // 
            // lblBrans
            // 
            this.lblBrans.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblBrans.Appearance.Options.UseFont = true;
            this.lblBrans.Location = new System.Drawing.Point(20, 55);
            this.lblBrans.Name = "lblBrans";
            this.lblBrans.Size = new System.Drawing.Size(0, 21);
            this.lblBrans.TabIndex = 1;
            // 
            // lblOgretmenNo
            // 
            this.lblOgretmenNo.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblOgretmenNo.Appearance.Options.UseFont = true;
            this.lblOgretmenNo.Location = new System.Drawing.Point(20, 80);
            this.lblOgretmenNo.Name = "lblOgretmenNo";
            this.lblOgretmenNo.Size = new System.Drawing.Size(0, 21);
            this.lblOgretmenNo.TabIndex = 2;
            // 
            // grpDersProgrami
            // 
            this.grpDersProgrami.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDersProgrami.Controls.Add(this.gridDersProgrami);
            this.grpDersProgrami.Location = new System.Drawing.Point(20, 209);
            this.grpDersProgrami.Name = "grpDersProgrami";
            this.grpDersProgrami.Size = new System.Drawing.Size(1160, 276);
            this.grpDersProgrami.TabIndex = 2;
            this.grpDersProgrami.Text = "DERS PROGRAMI";
            // 
            // gridDersProgrami
            // 
            this.gridDersProgrami.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDersProgrami.Location = new System.Drawing.Point(2, 23);
            this.gridDersProgrami.MainView = this.viewDersProgrami;
            this.gridDersProgrami.Name = "gridDersProgrami";
            this.gridDersProgrami.Size = new System.Drawing.Size(1156, 251);
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
            // grpSiniflar
            // 
            this.grpSiniflar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSiniflar.Controls.Add(this.gridSiniflar);
            this.grpSiniflar.Location = new System.Drawing.Point(20, 500);
            this.grpSiniflar.Name = "grpSiniflar";
            this.grpSiniflar.Size = new System.Drawing.Size(1160, 300);
            this.grpSiniflar.TabIndex = 3;
            this.grpSiniflar.Text = "SINIFLARIM";
            // 
            // gridSiniflar
            // 
            this.gridSiniflar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSiniflar.Location = new System.Drawing.Point(2, 23);
            this.gridSiniflar.MainView = this.viewSiniflar;
            this.gridSiniflar.Name = "gridSiniflar";
            this.gridSiniflar.Size = new System.Drawing.Size(1156, 275);
            this.gridSiniflar.TabIndex = 0;
            this.gridSiniflar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewSiniflar});
            // 
            // viewSiniflar
            // 
            this.viewSiniflar.GridControl = this.gridSiniflar;
            this.viewSiniflar.Name = "viewSiniflar";
            this.viewSiniflar.OptionsBehavior.Editable = false;
            this.viewSiniflar.OptionsView.ShowGroupPanel = false;
            // 
            // HosGeldinOgretmen
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.pnlUst);
            this.Controls.Add(this.grpOgretmenBilgi);
            this.Controls.Add(this.grpDersProgrami);
            this.Controls.Add(this.grpSiniflar);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "HosGeldinOgretmen";
            this.Text = "Öğretmen Bilgi Sistemi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HosGeldinOgretmen_Load_1);
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
            ((System.ComponentModel.ISupportInitialize)(this.grpSiniflar)).EndInit();
            this.grpSiniflar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSiniflar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSiniflar)).EndInit();
            this.ResumeLayout(false);

    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }
}