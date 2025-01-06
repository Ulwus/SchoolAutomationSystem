using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

partial class DersProgramiGoruntule
{
    private System.ComponentModel.IContainer components = null;

    private PanelControl pnlUst;
    private LabelControl lblBaslik;
    private GroupControl grpFiltre;
    private LabelControl lblSinif;
    private ComboBoxEdit cmbSinif;
    private SimpleButton btnFiltrele;
    private GroupControl grpDersProgrami;
    private GridControl gridDersProgrami;
    private GridView viewDersProgrami;

    private void InitializeComponent()
    {
            this.pnlUst = new DevExpress.XtraEditors.PanelControl();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grpFiltre = new DevExpress.XtraEditors.GroupControl();
            this.lblSinif = new DevExpress.XtraEditors.LabelControl();
            this.cmbSinif = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnFiltrele = new DevExpress.XtraEditors.SimpleButton();
            this.grpDersProgrami = new DevExpress.XtraEditors.GroupControl();
            this.gridDersProgrami = new DevExpress.XtraGrid.GridControl();
            this.viewDersProgrami = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.pnlUst)).BeginInit();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpFiltre)).BeginInit();
            this.grpFiltre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSinif.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDersProgrami)).BeginInit();
            this.grpDersProgrami.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDersProgrami)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDersProgrami)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
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
            this.lblBaslik.Size = new System.Drawing.Size(272, 25);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "DERS PROGRAMI GÖRÜNTÜLE";
            // 
            // grpFiltre
            // 
            this.grpFiltre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFiltre.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpFiltre.Appearance.Options.UseFont = true;
            this.grpFiltre.Controls.Add(this.lblSinif);
            this.grpFiltre.Controls.Add(this.cmbSinif);
            this.grpFiltre.Controls.Add(this.btnFiltrele);
            this.grpFiltre.Location = new System.Drawing.Point(20, 70);
            this.grpFiltre.Name = "grpFiltre";
            this.grpFiltre.Size = new System.Drawing.Size(1160, 80);
            this.grpFiltre.TabIndex = 1;
            this.grpFiltre.Text = "SINIF FİLTRELE";
            // 
            // lblSinif
            // 
            this.lblSinif.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSinif.Appearance.Options.UseFont = true;
            this.lblSinif.Location = new System.Drawing.Point(20, 35);
            this.lblSinif.Name = "lblSinif";
            this.lblSinif.Size = new System.Drawing.Size(70, 17);
            this.lblSinif.TabIndex = 0;
            this.lblSinif.Text = "Sınıf Seçiniz:";
            // 
            // cmbSinif
            // 
            this.cmbSinif.Location = new System.Drawing.Point(100, 32);
            this.cmbSinif.Name = "cmbSinif";
            this.cmbSinif.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbSinif.Size = new System.Drawing.Size(150, 20);
            this.cmbSinif.TabIndex = 1;
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnFiltrele.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFiltrele.Appearance.Options.UseBackColor = true;
            this.btnFiltrele.Appearance.Options.UseFont = true;
            this.btnFiltrele.Location = new System.Drawing.Point(270, 32);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(80, 24);
            this.btnFiltrele.TabIndex = 2;
            this.btnFiltrele.Text = "Filtrele";
            // 
            // grpDersProgrami
            // 
            this.grpDersProgrami.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDersProgrami.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpDersProgrami.Appearance.Options.UseFont = true;
            this.grpDersProgrami.Controls.Add(this.gridDersProgrami);
            this.grpDersProgrami.Location = new System.Drawing.Point(20, 160);
            this.grpDersProgrami.Name = "grpDersProgrami";
            this.grpDersProgrami.Size = new System.Drawing.Size(1160, 600);
            this.grpDersProgrami.TabIndex = 2;
            this.grpDersProgrami.Text = "HAFTALIK DERS PROGRAMI";
            // 
            // gridDersProgrami
            // 
            this.gridDersProgrami.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDersProgrami.Location = new System.Drawing.Point(2, 23);
            this.gridDersProgrami.MainView = this.viewDersProgrami;
            this.gridDersProgrami.Name = "gridDersProgrami";
            this.gridDersProgrami.Size = new System.Drawing.Size(1156, 575);
            this.gridDersProgrami.TabIndex = 0;
            this.gridDersProgrami.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewDersProgrami});
            // 
            // viewDersProgrami
            // 
            this.viewDersProgrami.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.viewDersProgrami.Appearance.EvenRow.Options.UseBackColor = true;
            this.viewDersProgrami.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.viewDersProgrami.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White;
            this.viewDersProgrami.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.viewDersProgrami.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.viewDersProgrami.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.viewDersProgrami.Appearance.OddRow.Options.UseBackColor = true;
            this.viewDersProgrami.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.viewDersProgrami.Appearance.Row.ForeColor = System.Drawing.Color.White;
            this.viewDersProgrami.Appearance.Row.Options.UseBackColor = true;
            this.viewDersProgrami.Appearance.Row.Options.UseForeColor = true;
            this.viewDersProgrami.GridControl = this.gridDersProgrami;
            this.viewDersProgrami.Name = "viewDersProgrami";
            this.viewDersProgrami.OptionsBehavior.Editable = false;
            this.viewDersProgrami.OptionsView.EnableAppearanceEvenRow = true;
            this.viewDersProgrami.OptionsView.EnableAppearanceOddRow = true;
            this.viewDersProgrami.OptionsView.ShowGroupPanel = false;
            // 
            // DersProgramiGoruntule
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.pnlUst);
            this.Controls.Add(this.grpFiltre);
            this.Controls.Add(this.grpDersProgrami);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "DersProgramiGoruntule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ders Programı Görüntüle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pnlUst)).EndInit();
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpFiltre)).EndInit();
            this.grpFiltre.ResumeLayout(false);
            this.grpFiltre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSinif.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDersProgrami)).EndInit();
            this.grpDersProgrami.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDersProgrami)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDersProgrami)).EndInit();
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