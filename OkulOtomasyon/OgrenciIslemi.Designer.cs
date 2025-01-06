namespace OkulOtomasyon
{
    partial class OgrenciIslemi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciIslemi));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cologrenciID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cologrenciIsmi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cologrenciSoyismi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cologrenciYili = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cologrenciDogumYili = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cologrenciSinif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cologrenciVeliİsmi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cologrenciVeliTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cologrenciAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.xtraTabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1175, 644);
            this.splitContainer1.SplitterDistance = 427;
            this.splitContainer1.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom;
            this.xtraTabControl1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Size = new System.Drawing.Size(427, 644);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.comboBox1);
            this.xtraTabPage1.Controls.Add(this.simpleButton3);
            this.xtraTabPage1.Controls.Add(this.simpleButton2);
            this.xtraTabPage1.Controls.Add(this.dateEdit1);
            this.xtraTabPage1.Controls.Add(this.textEdit7);
            this.xtraTabPage1.Controls.Add(this.textEdit6);
            this.xtraTabPage1.Controls.Add(this.textEdit3);
            this.xtraTabPage1.Controls.Add(this.textEdit2);
            this.xtraTabPage1.Controls.Add(this.textEdit1);
            this.xtraTabPage1.Controls.Add(this.simpleButton1);
            this.xtraTabPage1.Controls.Add(this.label7);
            this.xtraTabPage1.Controls.Add(this.label6);
            this.xtraTabPage1.Controls.Add(this.label5);
            this.xtraTabPage1.Controls.Add(this.label4);
            this.xtraTabPage1.Controls.Add(this.label3);
            this.xtraTabPage1.Controls.Add(this.label2);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(425, 642);
            this.xtraTabPage1.Text = "Öğrenci Ekle";
            this.xtraTabPage1.Paint += new System.Windows.Forms.PaintEventHandler(this.xtraTabPage1_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(134, 186);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(277, 21);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton3.Location = new System.Drawing.Point(15, 350);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(396, 26);
            this.simpleButton3.TabIndex = 30;
            this.simpleButton3.Text = "Güncelle";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click_1);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Location = new System.Drawing.Point(15, 321);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(396, 23);
            this.simpleButton2.TabIndex = 29;
            this.simpleButton2.Text = "Sil";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click_1);
            // 
            // dateEdit1
            // 
            this.dateEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(134, 146);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(277, 20);
            this.dateEdit1.TabIndex = 27;
            // 
            // textEdit7
            // 
            this.textEdit7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit7.Location = new System.Drawing.Point(134, 250);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Size = new System.Drawing.Size(277, 20);
            this.textEdit7.TabIndex = 23;
            // 
            // textEdit6
            // 
            this.textEdit6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit6.Location = new System.Drawing.Point(134, 217);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Size = new System.Drawing.Size(277, 20);
            this.textEdit6.TabIndex = 22;
            // 
            // textEdit3
            // 
            this.textEdit3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit3.Location = new System.Drawing.Point(134, 107);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(277, 20);
            this.textEdit3.TabIndex = 19;
            // 
            // textEdit2
            // 
            this.textEdit2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit2.Location = new System.Drawing.Point(134, 67);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(277, 20);
            this.textEdit2.TabIndex = 18;
            // 
            // textEdit1
            // 
            this.textEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit1.Location = new System.Drawing.Point(134, 31);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(277, 20);
            this.textEdit1.TabIndex = 17;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Location = new System.Drawing.Point(15, 292);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(396, 23);
            this.simpleButton1.TabIndex = 16;
            this.simpleButton1.Text = "Ekle";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Öğrenci Veli Tel:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Öğrenci Veli İsmi:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Öğrenci Sınıfı:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Öğrenci Doğum Yılı:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Öğrenci Yılı:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğrenci Soyismi:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci İsmi:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.sqlDataSource2.Relations;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(744, 644);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click_1);
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "localhost_okulotomasyon_Connection";
            this.sqlDataSource2.Name = "sqlDataSource2";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = "select * from ogrenci";
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cologrenciID,
            this.cologrenciIsmi,
            this.cologrenciSoyismi,
            this.cologrenciYili,
            this.cologrenciDogumYili,
            this.cologrenciSinif,
            this.cologrenciVeliİsmi,
            this.cologrenciVeliTel,
            this.cologrenciAciklama});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // cologrenciID
            // 
            this.cologrenciID.FieldName = "ogrenciID";
            this.cologrenciID.Name = "cologrenciID";
            this.cologrenciID.Visible = true;
            this.cologrenciID.VisibleIndex = 0;
            // 
            // cologrenciIsmi
            // 
            this.cologrenciIsmi.FieldName = "ogrenciIsmi";
            this.cologrenciIsmi.Name = "cologrenciIsmi";
            this.cologrenciIsmi.Visible = true;
            this.cologrenciIsmi.VisibleIndex = 1;
            // 
            // cologrenciSoyismi
            // 
            this.cologrenciSoyismi.FieldName = "ogrenciSoyismi";
            this.cologrenciSoyismi.Name = "cologrenciSoyismi";
            this.cologrenciSoyismi.Visible = true;
            this.cologrenciSoyismi.VisibleIndex = 2;
            // 
            // cologrenciYili
            // 
            this.cologrenciYili.FieldName = "ogrenciYili";
            this.cologrenciYili.Name = "cologrenciYili";
            this.cologrenciYili.Visible = true;
            this.cologrenciYili.VisibleIndex = 3;
            // 
            // cologrenciDogumYili
            // 
            this.cologrenciDogumYili.FieldName = "ogrenciDogumYili";
            this.cologrenciDogumYili.Name = "cologrenciDogumYili";
            this.cologrenciDogumYili.Visible = true;
            this.cologrenciDogumYili.VisibleIndex = 4;
            // 
            // cologrenciSinif
            // 
            this.cologrenciSinif.FieldName = "ogrenciSinif";
            this.cologrenciSinif.Name = "cologrenciSinif";
            this.cologrenciSinif.Visible = true;
            this.cologrenciSinif.VisibleIndex = 5;
            // 
            // cologrenciVeliİsmi
            // 
            this.cologrenciVeliİsmi.FieldName = "ogrenciVeliİsmi";
            this.cologrenciVeliİsmi.Name = "cologrenciVeliİsmi";
            this.cologrenciVeliİsmi.Visible = true;
            this.cologrenciVeliİsmi.VisibleIndex = 6;
            // 
            // cologrenciVeliTel
            // 
            this.cologrenciVeliTel.FieldName = "ogrenciVeliTel";
            this.cologrenciVeliTel.Name = "cologrenciVeliTel";
            this.cologrenciVeliTel.Visible = true;
            this.cologrenciVeliTel.VisibleIndex = 7;
            // 
            // cologrenciAciklama
            // 
            this.cologrenciAciklama.FieldName = "ogrenciAciklama";
            this.cologrenciAciklama.Name = "cologrenciAciklama";
            this.cologrenciAciklama.Visible = true;
            this.cologrenciAciklama.VisibleIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // OgrenciIslemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 644);
            this.Controls.Add(this.splitContainer1);
            this.Name = "OgrenciIslemi";
            this.Text = "OgrenciEkle";
            this.Load += new System.EventHandler(this.OgrenciEkle_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraGrid.Columns.GridColumn cologrenciID;
        private DevExpress.XtraGrid.Columns.GridColumn cologrenciIsmi;
        private DevExpress.XtraGrid.Columns.GridColumn cologrenciSoyismi;
        private DevExpress.XtraGrid.Columns.GridColumn cologrenciYili;
        private DevExpress.XtraGrid.Columns.GridColumn cologrenciDogumYili;
        private DevExpress.XtraGrid.Columns.GridColumn cologrenciSinif;
        private DevExpress.XtraGrid.Columns.GridColumn cologrenciVeliİsmi;
        private DevExpress.XtraGrid.Columns.GridColumn cologrenciVeliTel;
        private DevExpress.XtraGrid.Columns.GridColumn cologrenciAciklama;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}