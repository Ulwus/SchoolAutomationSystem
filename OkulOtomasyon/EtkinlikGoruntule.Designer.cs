using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

partial class EtkinlikGoruntule
{
    private System.ComponentModel.IContainer components = null;
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
            this.grpEtkinlikler = new DevExpress.XtraEditors.GroupControl();
            this.gridEtkinlikler = new DevExpress.XtraGrid.GridControl();
            this.viewEtkinlikler = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.grpEtkinlikler)).BeginInit();
            this.grpEtkinlikler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEtkinlikler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEtkinlikler)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEtkinlikler
            // 
            this.grpEtkinlikler.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpEtkinlikler.Appearance.Options.UseFont = true;
            this.grpEtkinlikler.Controls.Add(this.gridEtkinlikler);
            this.grpEtkinlikler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpEtkinlikler.Location = new System.Drawing.Point(0, 0);
            this.grpEtkinlikler.Name = "grpEtkinlikler";
            this.grpEtkinlikler.Size = new System.Drawing.Size(1200, 700);
            this.grpEtkinlikler.TabIndex = 1;
            this.grpEtkinlikler.Text = "ETKİNLİK BİLGİLERİ";
            // 
            // gridEtkinlikler
            // 
            this.gridEtkinlikler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEtkinlikler.Location = new System.Drawing.Point(2, 23);
            this.gridEtkinlikler.MainView = this.viewEtkinlikler;
            this.gridEtkinlikler.Name = "gridEtkinlikler";
            this.gridEtkinlikler.Size = new System.Drawing.Size(1196, 675);
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
            // EtkinlikGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.grpEtkinlikler);
            this.Name = "EtkinlikGoruntule";
            this.Text = "Etkinlikler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EtkinlikGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpEtkinlikler)).EndInit();
            this.grpEtkinlikler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEtkinlikler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEtkinlikler)).EndInit();
            this.ResumeLayout(false);

    }
}