using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.ComponentModel;

partial class DevamsizlikIslemi
{
    private IContainer components = null;

    private PanelControl pnlUst;
    private LabelControl lblBaslik;
    private GroupControl grpSecim;
    private LabelControl lblDers;
    private ComboBoxEdit cmbDersler;
    private LabelControl lblSinif;
    private ComboBoxEdit cmbSiniflar;
    private LabelControl lblTarih;
    private DateEdit dateDevamsizlik;
    private GroupControl grpOgrenciler;
    private GridControl gridOgrenciler;
    private GridView viewOgrenciler;
    private SimpleButton btnKaydet;

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
            this.grpSecim = new DevExpress.XtraEditors.GroupControl();
            this.lblDers = new DevExpress.XtraEditors.LabelControl();
            this.cmbDersler = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblSinif = new DevExpress.XtraEditors.LabelControl();
            this.cmbSiniflar = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblTarih = new DevExpress.XtraEditors.LabelControl();
            this.dateDevamsizlik = new DevExpress.XtraEditors.DateEdit();
            this.grpOgrenciler = new DevExpress.XtraEditors.GroupControl();
            this.gridOgrenciler = new DevExpress.XtraGrid.GridControl();
            this.viewOgrenciler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnlUst)).BeginInit();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpSecim)).BeginInit();
            this.grpSecim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDersler.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSiniflar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDevamsizlik.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDevamsizlik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpOgrenciler)).BeginInit();
            this.grpOgrenciler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOgrenciler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewOgrenciler)).BeginInit();
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
            this.lblBaslik.Size = new System.Drawing.Size(184, 25);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "DEVAMSIZLIK KAYIT";
            // 
            // grpSecim
            // 
            this.grpSecim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSecim.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.grpSecim.Appearance.Options.UseBackColor = true;
            this.grpSecim.AppearanceCaption.ForeColor = System.Drawing.Color.White;
            this.grpSecim.AppearanceCaption.Options.UseForeColor = true;
            this.grpSecim.Controls.Add(this.lblDers);
            this.grpSecim.Controls.Add(this.cmbDersler);
            this.grpSecim.Controls.Add(this.lblSinif);
            this.grpSecim.Controls.Add(this.cmbSiniflar);
            this.grpSecim.Controls.Add(this.lblTarih);
            this.grpSecim.Controls.Add(this.dateDevamsizlik);
            this.grpSecim.Location = new System.Drawing.Point(20, 70);
            this.grpSecim.Name = "grpSecim";
            this.grpSecim.Size = new System.Drawing.Size(1144, 100);
            this.grpSecim.TabIndex = 1;
            this.grpSecim.Text = "DERS VE SINIF SEÇİMİ";
            // 
            // lblDers
            // 
            this.lblDers.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDers.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblDers.Appearance.Options.UseFont = true;
            this.lblDers.Appearance.Options.UseForeColor = true;
            this.lblDers.Location = new System.Drawing.Point(20, 40);
            this.lblDers.Name = "lblDers";
            this.lblDers.Size = new System.Drawing.Size(30, 17);
            this.lblDers.TabIndex = 0;
            this.lblDers.Text = "Ders:";
            // 
            // cmbDersler
            // 
            this.cmbDersler.Location = new System.Drawing.Point(100, 37);
            this.cmbDersler.Name = "cmbDersler";
            this.cmbDersler.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cmbDersler.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.cmbDersler.Properties.Appearance.Options.UseBackColor = true;
            this.cmbDersler.Properties.Appearance.Options.UseForeColor = true;
            this.cmbDersler.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDersler.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.cmbDersler.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbDersler.Size = new System.Drawing.Size(200, 20);
            this.cmbDersler.TabIndex = 1;
            this.cmbDersler.SelectedIndexChanged += new System.EventHandler(this.cmbDersler_SelectedIndexChanged_1);
            // 
            // lblSinif
            // 
            this.lblSinif.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSinif.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblSinif.Appearance.Options.UseFont = true;
            this.lblSinif.Appearance.Options.UseForeColor = true;
            this.lblSinif.Location = new System.Drawing.Point(320, 40);
            this.lblSinif.Name = "lblSinif";
            this.lblSinif.Size = new System.Drawing.Size(27, 17);
            this.lblSinif.TabIndex = 2;
            this.lblSinif.Text = "Sınıf:";
            // 
            // cmbSiniflar
            // 
            this.cmbSiniflar.Location = new System.Drawing.Point(400, 37);
            this.cmbSiniflar.Name = "cmbSiniflar";
            this.cmbSiniflar.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cmbSiniflar.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.cmbSiniflar.Properties.Appearance.Options.UseBackColor = true;
            this.cmbSiniflar.Properties.Appearance.Options.UseForeColor = true;
            this.cmbSiniflar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSiniflar.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.cmbSiniflar.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbSiniflar.Size = new System.Drawing.Size(200, 20);
            this.cmbSiniflar.TabIndex = 3;
            this.cmbSiniflar.SelectedIndexChanged += new System.EventHandler(this.cmbSiniflar_SelectedIndexChanged_1);
            // 
            // lblTarih
            // 
            this.lblTarih.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTarih.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblTarih.Appearance.Options.UseFont = true;
            this.lblTarih.Appearance.Options.UseForeColor = true;
            this.lblTarih.Location = new System.Drawing.Point(620, 40);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(32, 17);
            this.lblTarih.TabIndex = 4;
            this.lblTarih.Text = "Tarih:";
            // 
            // dateDevamsizlik
            // 
            this.dateDevamsizlik.EditValue = new System.DateTime(2025, 1, 5, 0, 0, 0, 0);
            this.dateDevamsizlik.Location = new System.Drawing.Point(700, 37);
            this.dateDevamsizlik.Name = "dateDevamsizlik";
            this.dateDevamsizlik.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dateDevamsizlik.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.dateDevamsizlik.Properties.Appearance.Options.UseBackColor = true;
            this.dateDevamsizlik.Properties.Appearance.Options.UseForeColor = true;
            this.dateDevamsizlik.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDevamsizlik.Properties.DisplayFormat.FormatString = "dd.MM.yyyy";
            this.dateDevamsizlik.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateDevamsizlik.Properties.EditFormat.FormatString = "dd.MM.yyyy";
            this.dateDevamsizlik.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateDevamsizlik.Properties.Mask.EditMask = "dd.MM.yyyy";
            this.dateDevamsizlik.Size = new System.Drawing.Size(200, 20);
            this.dateDevamsizlik.TabIndex = 5;
            // 
            // grpOgrenciler
            // 
            this.grpOgrenciler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOgrenciler.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.grpOgrenciler.Appearance.Options.UseBackColor = true;
            this.grpOgrenciler.AppearanceCaption.ForeColor = System.Drawing.Color.White;
            this.grpOgrenciler.AppearanceCaption.Options.UseForeColor = true;
            this.grpOgrenciler.Controls.Add(this.gridOgrenciler);
            this.grpOgrenciler.Location = new System.Drawing.Point(20, 180);
            this.grpOgrenciler.Name = "grpOgrenciler";
            this.grpOgrenciler.Size = new System.Drawing.Size(1144, 500);
            this.grpOgrenciler.TabIndex = 2;
            this.grpOgrenciler.Text = "ÖĞRENCİ LİSTESİ";
            // 
            // gridOgrenciler
            // 
            this.gridOgrenciler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridOgrenciler.Location = new System.Drawing.Point(2, 23);
            this.gridOgrenciler.MainView = this.viewOgrenciler;
            this.gridOgrenciler.Name = "gridOgrenciler";
            this.gridOgrenciler.Size = new System.Drawing.Size(1140, 475);
            this.gridOgrenciler.TabIndex = 0;
            this.gridOgrenciler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewOgrenciler});
            // 
            // viewOgrenciler
            // 
            this.viewOgrenciler.GridControl = this.gridOgrenciler;
            this.viewOgrenciler.Name = "viewOgrenciler";
            this.viewOgrenciler.OptionsView.ShowGroupPanel = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Appearance.Options.UseBackColor = true;
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.Appearance.Options.UseForeColor = true;
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnKaydet.Location = new System.Drawing.Point(0, 721);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(1184, 40);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "KAYDET";
            // 
            // DevamsizlikIslemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.pnlUst);
            this.Controls.Add(this.grpSecim);
            this.Controls.Add(this.grpOgrenciler);
            this.Controls.Add(this.btnKaydet);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "DevamsizlikIslemi";
            this.Text = "Devamsızlık Kayıt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pnlUst)).EndInit();
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpSecim)).EndInit();
            this.grpSecim.ResumeLayout(false);
            this.grpSecim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDersler.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSiniflar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDevamsizlik.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDevamsizlik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpOgrenciler)).EndInit();
            this.grpOgrenciler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOgrenciler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewOgrenciler)).EndInit();
            this.ResumeLayout(false);

    }
}