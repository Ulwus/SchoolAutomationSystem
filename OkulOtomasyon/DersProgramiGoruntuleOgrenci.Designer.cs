using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

partial class DersProgramiGoruntuleOgrenci
{
    private System.ComponentModel.IContainer components = null;

    private PanelControl pnlUst;
    private LabelControl lblBaslik;
    private GroupControl grpOgrenciBilgi;
    private LabelControl lblOgrenciAd;
    private LabelControl lblSinif;
    private LabelControl lblOgrenciNo;
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
            this.grpOgrenciBilgi = new DevExpress.XtraEditors.GroupControl();
            this.lblOgrenciAd = new DevExpress.XtraEditors.LabelControl();
            this.lblSinif = new DevExpress.XtraEditors.LabelControl();
            this.lblOgrenciNo = new DevExpress.XtraEditors.LabelControl();
            this.grpDersProgrami = new DevExpress.XtraEditors.GroupControl();
            this.gridDersProgrami = new DevExpress.XtraGrid.GridControl();
            this.viewDersProgrami = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.pnlUst)).BeginInit();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpOgrenciBilgi)).BeginInit();
            this.grpOgrenciBilgi.SuspendLayout();
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
            // grpOgrenciBilgi
            // 
            this.grpOgrenciBilgi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOgrenciBilgi.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpOgrenciBilgi.Appearance.Options.UseFont = true;
            this.grpOgrenciBilgi.Controls.Add(this.lblOgrenciAd);
            this.grpOgrenciBilgi.Controls.Add(this.lblSinif);
            this.grpOgrenciBilgi.Controls.Add(this.lblOgrenciNo);
            this.grpOgrenciBilgi.Location = new System.Drawing.Point(20, 70);
            this.grpOgrenciBilgi.Name = "grpOgrenciBilgi";
            this.grpOgrenciBilgi.Size = new System.Drawing.Size(1160, 100);
            this.grpOgrenciBilgi.TabIndex = 1;
            this.grpOgrenciBilgi.Text = "ÖĞRENCİ BİLGİLERİ";
            // 
            // lblOgrenciAd
            // 
            this.lblOgrenciAd.Location = new System.Drawing.Point(20, 30);
            this.lblOgrenciAd.Name = "lblOgrenciAd";
            this.lblOgrenciAd.Size = new System.Drawing.Size(0, 13);
            this.lblOgrenciAd.TabIndex = 0;
            // 
            // lblSinif
            // 
            this.lblSinif.Location = new System.Drawing.Point(20, 55);
            this.lblSinif.Name = "lblSinif";
            this.lblSinif.Size = new System.Drawing.Size(0, 13);
            this.lblSinif.TabIndex = 1;
            // 
            // lblOgrenciNo
            // 
            this.lblOgrenciNo.Location = new System.Drawing.Point(20, 80);
            this.lblOgrenciNo.Name = "lblOgrenciNo";
            this.lblOgrenciNo.Size = new System.Drawing.Size(0, 13);
            this.lblOgrenciNo.TabIndex = 2;
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
            // DersProgramiGoruntuleOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.pnlUst);
            this.Controls.Add(this.grpOgrenciBilgi);
            this.Controls.Add(this.grpDersProgrami);
            this.Name = "DersProgramiGoruntuleOgrenci";
            this.Text = "Ders Programı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
            this.ResumeLayout(false);

    }
}