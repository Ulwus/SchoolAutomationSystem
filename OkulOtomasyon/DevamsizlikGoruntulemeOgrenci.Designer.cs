using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

partial class DevamsizlikGoruntulemeOgrenci
{
    private System.ComponentModel.IContainer components = null;

    private PanelControl pnlUst;
    private LabelControl lblBaslik;
    private GroupControl grpOgrenciBilgi;
    private LabelControl lblOgrenciAd;
    private LabelControl lblSinif;
    private LabelControl lblOgrenciNo;
    private LabelControl lblToplamDevamsizlik;
    private GroupControl grpDevamsizlik;
    private GridControl gridDevamsizlik;
    private GridView viewDevamsizlik;

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
            this.lblToplamDevamsizlik = new DevExpress.XtraEditors.LabelControl();
            this.grpDevamsizlik = new DevExpress.XtraEditors.GroupControl();
            this.gridDevamsizlik = new DevExpress.XtraGrid.GridControl();
            this.viewDevamsizlik = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.pnlUst)).BeginInit();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpOgrenciBilgi)).BeginInit();
            this.grpOgrenciBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpDevamsizlik)).BeginInit();
            this.grpDevamsizlik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDevamsizlik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDevamsizlik)).BeginInit();
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
            this.lblBaslik.Size = new System.Drawing.Size(216, 25);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "DEVAMSIZLIK BİLGİLERİ";
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
            this.grpOgrenciBilgi.Controls.Add(this.lblToplamDevamsizlik);
            this.grpOgrenciBilgi.Location = new System.Drawing.Point(20, 70);
            this.grpOgrenciBilgi.Name = "grpOgrenciBilgi";
            this.grpOgrenciBilgi.Size = new System.Drawing.Size(1160, 120);
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
            // lblToplamDevamsizlik
            // 
            this.lblToplamDevamsizlik.Location = new System.Drawing.Point(20, 105);
            this.lblToplamDevamsizlik.Name = "lblToplamDevamsizlik";
            this.lblToplamDevamsizlik.Size = new System.Drawing.Size(0, 13);
            this.lblToplamDevamsizlik.TabIndex = 3;
            // 
            // grpDevamsizlik
            // 
            this.grpDevamsizlik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDevamsizlik.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpDevamsizlik.Appearance.Options.UseFont = true;
            this.grpDevamsizlik.Controls.Add(this.gridDevamsizlik);
            this.grpDevamsizlik.Location = new System.Drawing.Point(20, 200);
            this.grpDevamsizlik.Name = "grpDevamsizlik";
            this.grpDevamsizlik.Size = new System.Drawing.Size(1160, 480);
            this.grpDevamsizlik.TabIndex = 2;
            this.grpDevamsizlik.Text = "DEVAMSIZLIK BİLGİLERİ";
            // 
            // gridDevamsizlik
            // 
            this.gridDevamsizlik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDevamsizlik.Location = new System.Drawing.Point(2, 23);
            this.gridDevamsizlik.MainView = this.viewDevamsizlik;
            this.gridDevamsizlik.Name = "gridDevamsizlik";
            this.gridDevamsizlik.Size = new System.Drawing.Size(1156, 455);
            this.gridDevamsizlik.TabIndex = 0;
            this.gridDevamsizlik.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewDevamsizlik});
            // 
            // viewDevamsizlik
            // 
            this.viewDevamsizlik.GridControl = this.gridDevamsizlik;
            this.viewDevamsizlik.Name = "viewDevamsizlik";
            this.viewDevamsizlik.OptionsBehavior.Editable = false;
            this.viewDevamsizlik.OptionsView.ShowGroupPanel = false;
            // 
            // DevamsizlikGoruntulemeOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.pnlUst);
            this.Controls.Add(this.grpOgrenciBilgi);
            this.Controls.Add(this.grpDevamsizlik);
            this.Name = "DevamsizlikGoruntulemeOgrenci";
            this.Text = "Devamsızlık Bilgileri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pnlUst)).EndInit();
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpOgrenciBilgi)).EndInit();
            this.grpOgrenciBilgi.ResumeLayout(false);
            this.grpOgrenciBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpDevamsizlik)).EndInit();
            this.grpDevamsizlik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDevamsizlik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDevamsizlik)).EndInit();
            this.ResumeLayout(false);

    }
}