using System;
using System.Windows.Forms;
using System.Drawing;

public partial class DersProgramiOlustur : Form
{
    private Panel panel1;
    private Label lblBaslik;
    private ComboBox cmbSinif;
    private ComboBox cmbDers;
    private ComboBox cmbOgretmen;
    private ComboBox cmbGun;
    private DateTimePicker dtpBaslangic;
    private DateTimePicker dtpBitis;
    private Button btnEkle;
    private Button btnKaydet;
    private DataGridView dgvDersProgrami;

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DersProgramiOlustur));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.cmbSinif = new System.Windows.Forms.ComboBox();
            this.cmbDers = new System.Windows.Forms.ComboBox();
            this.cmbOgretmen = new System.Windows.Forms.ComboBox();
            this.cmbGun = new System.Windows.Forms.ComboBox();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dgvDersProgrami = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colprogramID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldersID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cologretmenID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsinifID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgun = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbaslangicSaati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbitisSaati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersProgrami)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.lblBaslik);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 60);
            this.panel1.TabIndex = 0;
            // 
            // lblBaslik
            // 
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(20, 15);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(950, 23);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "DERS PROGRAMI OLUŞTUR";
            // 
            // cmbSinif
            // 
            this.cmbSinif.Location = new System.Drawing.Point(20, 80);
            this.cmbSinif.Name = "cmbSinif";
            this.cmbSinif.Size = new System.Drawing.Size(200, 21);
            this.cmbSinif.TabIndex = 1;
            this.cmbSinif.Text = "Sınıf Seçiniz";
            this.cmbSinif.SelectedIndexChanged += new System.EventHandler(this.cmbSinif_SelectedIndexChanged);
            // 
            // cmbDers
            // 
            this.cmbDers.Location = new System.Drawing.Point(20, 120);
            this.cmbDers.Name = "cmbDers";
            this.cmbDers.Size = new System.Drawing.Size(200, 21);
            this.cmbDers.TabIndex = 2;
            this.cmbDers.Text = "Ders Seçiniz";
            // 
            // cmbOgretmen
            // 
            this.cmbOgretmen.Location = new System.Drawing.Point(20, 160);
            this.cmbOgretmen.Name = "cmbOgretmen";
            this.cmbOgretmen.Size = new System.Drawing.Size(200, 21);
            this.cmbOgretmen.TabIndex = 3;
            this.cmbOgretmen.Text = "Öğretmen Seçiniz";
            // 
            // cmbGun
            // 
            this.cmbGun.Items.AddRange(new object[] {
            "Pazartesi",
            "Salı",
            "Çarşamba",
            "Perşembe",
            "Cuma"});
            this.cmbGun.Location = new System.Drawing.Point(20, 200);
            this.cmbGun.Name = "cmbGun";
            this.cmbGun.Size = new System.Drawing.Size(200, 21);
            this.cmbGun.TabIndex = 4;
            this.cmbGun.Text = "Gün Seçiniz";
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpBaslangic.Location = new System.Drawing.Point(250, 200);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.ShowUpDown = true;
            this.dtpBaslangic.Size = new System.Drawing.Size(100, 20);
            this.dtpBaslangic.TabIndex = 5;
            // 
            // dtpBitis
            // 
            this.dtpBitis.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpBitis.Location = new System.Drawing.Point(370, 200);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.ShowUpDown = true;
            this.dtpBitis.Size = new System.Drawing.Size(100, 20);
            this.dtpBitis.TabIndex = 6;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(20, 250);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(120, 40);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "DERS EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(150, 250);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(150, 40);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "PROGRAMI KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            // 
            // dgvDersProgrami
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvDersProgrami.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDersProgrami.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvDersProgrami.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDersProgrami.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.dgvDersProgrami.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDersProgrami.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvDersProgrami.Location = new System.Drawing.Point(20, 310);
            this.dgvDersProgrami.Name = "dgvDersProgrami";
            this.dgvDersProgrami.Size = new System.Drawing.Size(606, 300);
            this.dgvDersProgrami.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(306, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "OTOMATİK OLUŞTUR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Location = new System.Drawing.Point(633, 66);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(593, 544);
            this.panelControl1.TabIndex = 11;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "Query";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(589, 540);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_okulotomasyon_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery2.Name = "Query";
            customSqlQuery2.Sql = "select * from ders_programi";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colprogramID,
            this.coldersID,
            this.cologretmenID,
            this.colsinifID,
            this.colgun,
            this.colbaslangicSaati,
            this.colbitisSaati});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colprogramID
            // 
            this.colprogramID.FieldName = "programID";
            this.colprogramID.Name = "colprogramID";
            this.colprogramID.Visible = true;
            this.colprogramID.VisibleIndex = 0;
            // 
            // coldersID
            // 
            this.coldersID.FieldName = "dersID";
            this.coldersID.Name = "coldersID";
            this.coldersID.Visible = true;
            this.coldersID.VisibleIndex = 1;
            // 
            // cologretmenID
            // 
            this.cologretmenID.FieldName = "ogretmenID";
            this.cologretmenID.Name = "cologretmenID";
            this.cologretmenID.Visible = true;
            this.cologretmenID.VisibleIndex = 2;
            // 
            // colsinifID
            // 
            this.colsinifID.FieldName = "sinifID";
            this.colsinifID.Name = "colsinifID";
            this.colsinifID.Visible = true;
            this.colsinifID.VisibleIndex = 3;
            // 
            // colgun
            // 
            this.colgun.FieldName = "gun";
            this.colgun.Name = "colgun";
            this.colgun.Visible = true;
            this.colgun.VisibleIndex = 4;
            // 
            // colbaslangicSaati
            // 
            this.colbaslangicSaati.FieldName = "baslangicSaati";
            this.colbaslangicSaati.Name = "colbaslangicSaati";
            this.colbaslangicSaati.Visible = true;
            this.colbaslangicSaati.VisibleIndex = 5;
            // 
            // colbitisSaati
            // 
            this.colbitisSaati.FieldName = "bitisSaati";
            this.colbitisSaati.Name = "colbitisSaati";
            this.colbitisSaati.Visible = true;
            this.colbitisSaati.VisibleIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(462, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "PROGRAM İNCELE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DersProgramiOlustur
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1238, 618);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbSinif);
            this.Controls.Add(this.cmbDers);
            this.Controls.Add(this.cmbOgretmen);
            this.Controls.Add(this.cmbGun);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dgvDersProgrami);
            this.Name = "DersProgramiOlustur";
            this.Load += new System.EventHandler(this.DersProgramiOlustur_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersProgrami)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

    }

    private Button button1;
    private DevExpress.XtraEditors.PanelControl panelControl1;
    private DevExpress.XtraGrid.GridControl gridControl1;
    private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    private System.ComponentModel.IContainer components;
    private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    private DevExpress.XtraGrid.Columns.GridColumn colprogramID;
    private DevExpress.XtraGrid.Columns.GridColumn coldersID;
    private DevExpress.XtraGrid.Columns.GridColumn cologretmenID;
    private DevExpress.XtraGrid.Columns.GridColumn colsinifID;
    private DevExpress.XtraGrid.Columns.GridColumn colgun;
    private DevExpress.XtraGrid.Columns.GridColumn colbaslangicSaati;
    private DevExpress.XtraGrid.Columns.GridColumn colbitisSaati;
    private Button button2;
}