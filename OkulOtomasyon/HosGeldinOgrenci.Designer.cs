using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

partial class HosGeldinOgrenci
{
    private System.ComponentModel.IContainer components = null;

    // DevExpress Kontrolleri
    private PanelControl pnlUst;
    private LabelControl lblBaslik;
    private GroupControl grpOgrenciBilgi;
    private LabelControl lblOgrenciAd;
    private LabelControl lblSinif;
    private LabelControl lblOgrenciNo;
    private LabelControl lblNotOrt;
    private LabelControl lblDevamsizlik;
    private GroupControl grpDersProgrami;
    private GridControl gridDersProgrami;
    private GridView viewDersProgrami;
    private GroupControl grpNotlar;
    private GridControl gridNotlar;
    private GridView viewNotlar;
    private GroupControl grpEtkinlikler;
    private GridControl gridEtkinlikler;
    private GridView viewEtkinlikler;

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
            this.grpOgrenciBilgi = new DevExpress.XtraEditors.GroupControl();
            this.lblOgrenciAd = new DevExpress.XtraEditors.LabelControl();
            this.lblSinif = new DevExpress.XtraEditors.LabelControl();
            this.lblOgrenciNo = new DevExpress.XtraEditors.LabelControl();
            this.lblNotOrt = new DevExpress.XtraEditors.LabelControl();
            this.lblDevamsizlik = new DevExpress.XtraEditors.LabelControl();
            this.grpDersProgrami = new DevExpress.XtraEditors.GroupControl();
            this.gridDersProgrami = new DevExpress.XtraGrid.GridControl();
            this.viewDersProgrami = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grpNotlar = new DevExpress.XtraEditors.GroupControl();
            this.gridNotlar = new DevExpress.XtraGrid.GridControl();
            this.viewNotlar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grpEtkinlikler = new DevExpress.XtraEditors.GroupControl();
            this.gridEtkinlikler = new DevExpress.XtraGrid.GridControl();
            this.viewEtkinlikler = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.pnlUst)).BeginInit();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpOgrenciBilgi)).BeginInit();
            this.grpOgrenciBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpDersProgrami)).BeginInit();
            this.grpDersProgrami.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDersProgrami)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDersProgrami)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpNotlar)).BeginInit();
            this.grpNotlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNotlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewNotlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpEtkinlikler)).BeginInit();
            this.grpEtkinlikler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEtkinlikler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEtkinlikler)).BeginInit();
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
            this.pnlUst.Size = new System.Drawing.Size(1165, 60);
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
            this.lblBaslik.Size = new System.Drawing.Size(127, 25);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "HOŞGELDİNİZ";
            // 
            // grpOgrenciBilgi
            // 
            this.grpOgrenciBilgi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOgrenciBilgi.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpOgrenciBilgi.Appearance.Options.UseFont = true;
            this.grpOgrenciBilgi.Controls.Add(this.lblOgrenciAd);
            this.grpOgrenciBilgi.Controls.Add(this.lblSinif);
            this.grpOgrenciBilgi.Controls.Add(this.lblOgrenciNo);
            this.grpOgrenciBilgi.Controls.Add(this.lblNotOrt);
            this.grpOgrenciBilgi.Controls.Add(this.lblDevamsizlik);
            this.grpOgrenciBilgi.Location = new System.Drawing.Point(20, 70);
            this.grpOgrenciBilgi.Name = "grpOgrenciBilgi";
            this.grpOgrenciBilgi.Size = new System.Drawing.Size(1133, 180);
            this.grpOgrenciBilgi.TabIndex = 1;
            this.grpOgrenciBilgi.Text = "ÖĞRENCİ BİLGİLERİ";
            // 
            // lblOgrenciAd
            // 
            this.lblOgrenciAd.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblOgrenciAd.Appearance.Options.UseFont = true;
            this.lblOgrenciAd.Location = new System.Drawing.Point(10, 30);
            this.lblOgrenciAd.Name = "lblOgrenciAd";
            this.lblOgrenciAd.Size = new System.Drawing.Size(0, 17);
            this.lblOgrenciAd.TabIndex = 0;
            // 
            // lblSinif
            // 
            this.lblSinif.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSinif.Appearance.Options.UseFont = true;
            this.lblSinif.Location = new System.Drawing.Point(10, 60);
            this.lblSinif.Name = "lblSinif";
            this.lblSinif.Size = new System.Drawing.Size(0, 17);
            this.lblSinif.TabIndex = 1;
            // 
            // lblOgrenciNo
            // 
            this.lblOgrenciNo.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblOgrenciNo.Appearance.Options.UseFont = true;
            this.lblOgrenciNo.Location = new System.Drawing.Point(10, 90);
            this.lblOgrenciNo.Name = "lblOgrenciNo";
            this.lblOgrenciNo.Size = new System.Drawing.Size(0, 17);
            this.lblOgrenciNo.TabIndex = 2;
            // 
            // lblNotOrt
            // 
            this.lblNotOrt.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNotOrt.Appearance.Options.UseFont = true;
            this.lblNotOrt.Location = new System.Drawing.Point(10, 120);
            this.lblNotOrt.Name = "lblNotOrt";
            this.lblNotOrt.Size = new System.Drawing.Size(0, 17);
            this.lblNotOrt.TabIndex = 3;
            // 
            // lblDevamsizlik
            // 
            this.lblDevamsizlik.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDevamsizlik.Appearance.Options.UseFont = true;
            this.lblDevamsizlik.Location = new System.Drawing.Point(10, 150);
            this.lblDevamsizlik.Name = "lblDevamsizlik";
            this.lblDevamsizlik.Size = new System.Drawing.Size(0, 17);
            this.lblDevamsizlik.TabIndex = 4;
            // 
            // grpDersProgrami
            // 
            this.grpDersProgrami.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDersProgrami.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpDersProgrami.Appearance.Options.UseFont = true;
            this.grpDersProgrami.Controls.Add(this.gridDersProgrami);
            this.grpDersProgrami.Location = new System.Drawing.Point(20, 260);
            this.grpDersProgrami.Name = "grpDersProgrami";
            this.grpDersProgrami.Size = new System.Drawing.Size(1133, 189);
            this.grpDersProgrami.TabIndex = 2;
            this.grpDersProgrami.Text = "DERS PROGRAMI";
            // 
            // gridDersProgrami
            // 
            this.gridDersProgrami.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDersProgrami.Location = new System.Drawing.Point(2, 23);
            this.gridDersProgrami.MainView = this.viewDersProgrami;
            this.gridDersProgrami.Name = "gridDersProgrami";
            this.gridDersProgrami.Size = new System.Drawing.Size(1129, 164);
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
            // grpNotlar
            // 
            this.grpNotlar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpNotlar.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpNotlar.Appearance.Options.UseFont = true;
            this.grpNotlar.Controls.Add(this.gridNotlar);
            this.grpNotlar.Location = new System.Drawing.Point(20, 466);
            this.grpNotlar.Name = "grpNotlar";
            this.grpNotlar.Size = new System.Drawing.Size(1133, 200);
            this.grpNotlar.TabIndex = 3;
            this.grpNotlar.Text = "NOTLAR";
            // 
            // gridNotlar
            // 
            this.gridNotlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridNotlar.Location = new System.Drawing.Point(2, 23);
            this.gridNotlar.MainView = this.viewNotlar;
            this.gridNotlar.Name = "gridNotlar";
            this.gridNotlar.Size = new System.Drawing.Size(1129, 175);
            this.gridNotlar.TabIndex = 0;
            this.gridNotlar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewNotlar});
            // 
            // viewNotlar
            // 
            this.viewNotlar.GridControl = this.gridNotlar;
            this.viewNotlar.Name = "viewNotlar";
            this.viewNotlar.OptionsBehavior.Editable = false;
            this.viewNotlar.OptionsView.ShowGroupPanel = false;
            // 
            // grpEtkinlikler
            // 
            this.grpEtkinlikler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEtkinlikler.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpEtkinlikler.Appearance.Options.UseFont = true;
            this.grpEtkinlikler.Controls.Add(this.gridEtkinlikler);
            this.grpEtkinlikler.Location = new System.Drawing.Point(22, 684);
            this.grpEtkinlikler.Name = "grpEtkinlikler";
            this.grpEtkinlikler.Size = new System.Drawing.Size(1131, 178);
            this.grpEtkinlikler.TabIndex = 4;
            this.grpEtkinlikler.Text = "YAKLAŞAN ETKİNLİKLER";
            // 
            // gridEtkinlikler
            // 
            this.gridEtkinlikler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEtkinlikler.Location = new System.Drawing.Point(2, 23);
            this.gridEtkinlikler.MainView = this.viewEtkinlikler;
            this.gridEtkinlikler.Name = "gridEtkinlikler";
            this.gridEtkinlikler.Size = new System.Drawing.Size(1127, 153);
            this.gridEtkinlikler.TabIndex = 0;
            this.gridEtkinlikler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewEtkinlikler});
            // 
            // viewEtkinlikler
            // 
            this.viewEtkinlikler.GridControl = this.gridEtkinlikler;
            this.viewEtkinlikler.Name = "viewEtkinlikler";
            this.viewEtkinlikler.OptionsBehavior.Editable = false;
            this.viewEtkinlikler.OptionsView.ShowGroupPanel = false;
            // 
            // HosGeldinOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1165, 872);
            this.Controls.Add(this.pnlUst);
            this.Controls.Add(this.grpOgrenciBilgi);
            this.Controls.Add(this.grpDersProgrami);
            this.Controls.Add(this.grpNotlar);
            this.Controls.Add(this.grpEtkinlikler);
            this.Name = "HosGeldinOgrenci";
            this.Text = "Öğrenci Bilgi Sistemi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HosGeldinOgrenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlUst)).EndInit();
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpOgrenciBilgi)).EndInit();
            this.grpOgrenciBilgi.ResumeLayout(false);
            this.grpOgrenciBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpDersProgrami)).EndInit();
            this.grpDersProgrami.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDersProgrami)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDersProgrami)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpNotlar)).EndInit();
            this.grpNotlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridNotlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewNotlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpEtkinlikler)).EndInit();
            this.grpEtkinlikler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEtkinlikler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEtkinlikler)).EndInit();
            this.ResumeLayout(false);

    }
}