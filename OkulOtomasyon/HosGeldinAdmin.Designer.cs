using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

partial class HosGeldinAdmin
{
    private System.ComponentModel.IContainer components = null;

    private PanelControl pnlUst;
    private LabelControl lblBaslik;
    private GroupControl grpIstatistikler;
    private PanelControl pnlOgrenci;
    private PanelControl pnlOgretmen;
    private PanelControl pnlSinif;
    private LabelControl lblOgrenciSayisi;
    private LabelControl lblOgretmenSayisi;
    private LabelControl lblSinifSayisi;
    private GroupControl grpEtkinlikler;
    private GridControl gridEtkinlikler;
    private GridView viewEtkinlikler;
    private GroupControl grpKayitlar;
    private GridControl gridKayitlar;
    private GridView viewKayitlar;

    private void InitializeComponent()
    {
            this.pnlUst = new DevExpress.XtraEditors.PanelControl();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grpIstatistikler = new DevExpress.XtraEditors.GroupControl();
            this.pnlOgrenci = new DevExpress.XtraEditors.PanelControl();
            this.lblOgrenciSayisi = new DevExpress.XtraEditors.LabelControl();
            this.pnlOgretmen = new DevExpress.XtraEditors.PanelControl();
            this.lblOgretmenSayisi = new DevExpress.XtraEditors.LabelControl();
            this.pnlSinif = new DevExpress.XtraEditors.PanelControl();
            this.lblSinifSayisi = new DevExpress.XtraEditors.LabelControl();
            this.grpEtkinlikler = new DevExpress.XtraEditors.GroupControl();
            this.gridEtkinlikler = new DevExpress.XtraGrid.GridControl();
            this.viewEtkinlikler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grpKayitlar = new DevExpress.XtraEditors.GroupControl();
            this.gridKayitlar = new DevExpress.XtraGrid.GridControl();
            this.viewKayitlar = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.pnlUst)).BeginInit();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpIstatistikler)).BeginInit();
            this.grpIstatistikler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlOgrenci)).BeginInit();
            this.pnlOgrenci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlOgretmen)).BeginInit();
            this.pnlOgretmen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSinif)).BeginInit();
            this.pnlSinif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpEtkinlikler)).BeginInit();
            this.grpEtkinlikler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEtkinlikler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEtkinlikler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpKayitlar)).BeginInit();
            this.grpKayitlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKayitlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewKayitlar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pnlUst.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pnlUst.Appearance.Options.UseBackColor = true;
            this.pnlUst.Controls.Add(this.lblBaslik);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
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
            this.lblBaslik.Size = new System.Drawing.Size(157, 25);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "YÖNETİCİ PANELİ";
            // 
            // grpIstatistikler
            // 
            this.grpIstatistikler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpIstatistikler.Controls.Add(this.pnlOgrenci);
            this.grpIstatistikler.Controls.Add(this.pnlOgretmen);
            this.grpIstatistikler.Controls.Add(this.pnlSinif);
            this.grpIstatistikler.Location = new System.Drawing.Point(20, 70);
            this.grpIstatistikler.Name = "grpIstatistikler";
            this.grpIstatistikler.Size = new System.Drawing.Size(1160, 150);
            this.grpIstatistikler.TabIndex = 1;
            this.grpIstatistikler.Text = "GENEL İSTATİSTİKLER";
            // 
            // pnlOgrenci
            // 
            this.pnlOgrenci.Appearance.BackColor = System.Drawing.Color.Purple;
            this.pnlOgrenci.Appearance.Options.UseBackColor = true;
            this.pnlOgrenci.Controls.Add(this.lblOgrenciSayisi);
            this.pnlOgrenci.Location = new System.Drawing.Point(20, 30);
            this.pnlOgrenci.LookAndFeel.SkinName = "DevExpress Style";
            this.pnlOgrenci.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.pnlOgrenci.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlOgrenci.Name = "pnlOgrenci";
            this.pnlOgrenci.Size = new System.Drawing.Size(360, 100);
            this.pnlOgrenci.TabIndex = 0;
            // 
            // lblOgrenciSayisi
            // 
            this.lblOgrenciSayisi.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblOgrenciSayisi.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblOgrenciSayisi.Appearance.Options.UseFont = true;
            this.lblOgrenciSayisi.Appearance.Options.UseForeColor = true;
            this.lblOgrenciSayisi.Location = new System.Drawing.Point(20, 40);
            this.lblOgrenciSayisi.Name = "lblOgrenciSayisi";
            this.lblOgrenciSayisi.Size = new System.Drawing.Size(0, 21);
            this.lblOgrenciSayisi.TabIndex = 0;
            // 
            // pnlOgretmen
            // 
            this.pnlOgretmen.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.pnlOgretmen.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.pnlOgretmen.Appearance.Options.UseBackColor = true;
            this.pnlOgretmen.Controls.Add(this.lblOgretmenSayisi);
            this.pnlOgretmen.Location = new System.Drawing.Point(400, 30);
            this.pnlOgretmen.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.pnlOgretmen.LookAndFeel.SkinName = "Office 2019 Black";
            this.pnlOgretmen.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.pnlOgretmen.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlOgretmen.Name = "pnlOgretmen";
            this.pnlOgretmen.Size = new System.Drawing.Size(360, 100);
            this.pnlOgretmen.TabIndex = 1;
            // 
            // lblOgretmenSayisi
            // 
            this.lblOgretmenSayisi.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblOgretmenSayisi.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblOgretmenSayisi.Appearance.Options.UseFont = true;
            this.lblOgretmenSayisi.Appearance.Options.UseForeColor = true;
            this.lblOgretmenSayisi.Location = new System.Drawing.Point(20, 40);
            this.lblOgretmenSayisi.Name = "lblOgretmenSayisi";
            this.lblOgretmenSayisi.Size = new System.Drawing.Size(0, 21);
            this.lblOgretmenSayisi.TabIndex = 0;
            // 
            // pnlSinif
            // 
            this.pnlSinif.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.pnlSinif.Appearance.Options.UseBackColor = true;
            this.pnlSinif.Controls.Add(this.lblSinifSayisi);
            this.pnlSinif.Location = new System.Drawing.Point(780, 30);
            this.pnlSinif.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.pnlSinif.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlSinif.Name = "pnlSinif";
            this.pnlSinif.Size = new System.Drawing.Size(360, 100);
            this.pnlSinif.TabIndex = 2;
            // 
            // lblSinifSayisi
            // 
            this.lblSinifSayisi.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSinifSayisi.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblSinifSayisi.Appearance.Options.UseFont = true;
            this.lblSinifSayisi.Appearance.Options.UseForeColor = true;
            this.lblSinifSayisi.Location = new System.Drawing.Point(20, 40);
            this.lblSinifSayisi.Name = "lblSinifSayisi";
            this.lblSinifSayisi.Size = new System.Drawing.Size(0, 21);
            this.lblSinifSayisi.TabIndex = 0;
            // 
            // grpEtkinlikler
            // 
            this.grpEtkinlikler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEtkinlikler.Controls.Add(this.gridEtkinlikler);
            this.grpEtkinlikler.Location = new System.Drawing.Point(20, 230);
            this.grpEtkinlikler.Name = "grpEtkinlikler";
            this.grpEtkinlikler.Size = new System.Drawing.Size(1152, 238);
            this.grpEtkinlikler.TabIndex = 2;
            this.grpEtkinlikler.Text = "SON ETKİNLİKLER";
            // 
            // gridEtkinlikler
            // 
            this.gridEtkinlikler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEtkinlikler.Location = new System.Drawing.Point(2, 23);
            this.gridEtkinlikler.MainView = this.viewEtkinlikler;
            this.gridEtkinlikler.Name = "gridEtkinlikler";
            this.gridEtkinlikler.Size = new System.Drawing.Size(1148, 213);
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
            // grpKayitlar
            // 
            this.grpKayitlar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKayitlar.Controls.Add(this.gridKayitlar);
            this.grpKayitlar.Location = new System.Drawing.Point(20, 485);
            this.grpKayitlar.Name = "grpKayitlar";
            this.grpKayitlar.Size = new System.Drawing.Size(1150, 253);
            this.grpKayitlar.TabIndex = 3;
            this.grpKayitlar.Text = "SON KAYITLAR";
            // 
            // gridKayitlar
            // 
            this.gridKayitlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridKayitlar.Location = new System.Drawing.Point(2, 23);
            this.gridKayitlar.MainView = this.viewKayitlar;
            this.gridKayitlar.Name = "gridKayitlar";
            this.gridKayitlar.Size = new System.Drawing.Size(1146, 228);
            this.gridKayitlar.TabIndex = 0;
            this.gridKayitlar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewKayitlar});
            // 
            // viewKayitlar
            // 
            this.viewKayitlar.GridControl = this.gridKayitlar;
            this.viewKayitlar.Name = "viewKayitlar";
            this.viewKayitlar.OptionsBehavior.Editable = false;
            this.viewKayitlar.OptionsView.ShowGroupPanel = false;
            // 
            // HosGeldinAdmin
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.pnlUst);
            this.Controls.Add(this.grpIstatistikler);
            this.Controls.Add(this.grpEtkinlikler);
            this.Controls.Add(this.grpKayitlar);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "HosGeldinAdmin";
            this.Text = "Yönetici Paneli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pnlUst)).EndInit();
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpIstatistikler)).EndInit();
            this.grpIstatistikler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlOgrenci)).EndInit();
            this.pnlOgrenci.ResumeLayout(false);
            this.pnlOgrenci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlOgretmen)).EndInit();
            this.pnlOgretmen.ResumeLayout(false);
            this.pnlOgretmen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSinif)).EndInit();
            this.pnlSinif.ResumeLayout(false);
            this.pnlSinif.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpEtkinlikler)).EndInit();
            this.grpEtkinlikler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEtkinlikler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEtkinlikler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpKayitlar)).EndInit();
            this.grpKayitlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridKayitlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewKayitlar)).EndInit();
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