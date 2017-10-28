namespace Otopark
{
    partial class AraclarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AraclarForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnAramaYap = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtSoyadi = new DevExpress.XtraEditors.TextEdit();
            this.txtTelefon = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboAracTipi = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtPlaka = new DevExpress.XtraEditors.TextEdit();
            this.checkKontak = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSonlandir = new System.Windows.Forms.ToolStripMenuItem();
            this.aracBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PLAKA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ARACTIPADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAracTipNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAboneNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ABONEMI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIRISTARIHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KONTAK = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboAracTipi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aracBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnTemizle);
            this.groupControl1.Controls.Add(this.btnAramaYap);
            this.groupControl1.Controls.Add(this.groupBox2);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(232, 516);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Arama";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // btnTemizle
            // 
            this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.ImageOptions.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(122, 402);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(103, 33);
            this.btnTemizle.TabIndex = 13;
            this.btnTemizle.Text = "Temizle";
            // 
            // btnAramaYap
            // 
            this.btnAramaYap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAramaYap.ImageOptions.Image")));
            this.btnAramaYap.Location = new System.Drawing.Point(13, 402);
            this.btnAramaYap.Name = "btnAramaYap";
            this.btnAramaYap.Size = new System.Drawing.Size(103, 33);
            this.btnAramaYap.TabIndex = 13;
            this.btnAramaYap.Text = "Arama Yap";
            this.btnAramaYap.Click += new System.EventHandler(this.btnAramaYap_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAdi);
            this.groupBox2.Controls.Add(this.txtSoyadi);
            this.groupBox2.Controls.Add(this.txtTelefon);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(13, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 177);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Abone Bilgileri";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(18, 45);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(151, 20);
            this.txtAdi.TabIndex = 10;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(18, 92);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(151, 20);
            this.txtSoyadi.TabIndex = 9;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(18, 136);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d";
            this.txtTelefon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtTelefon.Size = new System.Drawing.Size(151, 20);
            this.txtTelefon.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Adı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboAracTipi);
            this.groupBox1.Controls.Add(this.txtPlaka);
            this.groupBox1.Controls.Add(this.checkKontak);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 175);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genel Bilgiler";
            // 
            // comboAracTipi
            // 
            this.comboAracTipi.Location = new System.Drawing.Point(19, 90);
            this.comboAracTipi.Name = "comboAracTipi";
            this.comboAracTipi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboAracTipi.Size = new System.Drawing.Size(151, 20);
            this.comboAracTipi.TabIndex = 11;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(19, 42);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(151, 20);
            this.txtPlaka.TabIndex = 10;
            // 
            // checkKontak
            // 
            this.checkKontak.AutoSize = true;
            this.checkKontak.Checked = true;
            this.checkKontak.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkKontak.Location = new System.Drawing.Point(19, 129);
            this.checkKontak.Name = "checkKontak";
            this.checkKontak.Size = new System.Drawing.Size(144, 17);
            this.checkKontak.TabIndex = 10;
            this.checkKontak.Text = "Kontak Var /  Kontak Yok";
            this.checkKontak.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Araç Tipi";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(232, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1001, 516);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Araçlar";
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.DataSource = this.aracBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(997, 494);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDuzenle,
            this.menuSonlandir});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 48);
            // 
            // menuDuzenle
            // 
            this.menuDuzenle.Name = "menuDuzenle";
            this.menuDuzenle.Size = new System.Drawing.Size(141, 22);
            this.menuDuzenle.Text = "FiyatHesapla";
            this.menuDuzenle.Click += new System.EventHandler(this.menuDuzenle_Click);
            // 
            // menuSonlandir
            // 
            this.menuSonlandir.Name = "menuSonlandir";
            this.menuSonlandir.Size = new System.Drawing.Size(141, 22);
            this.menuSonlandir.Text = "Sonlandır";
            this.menuSonlandir.Click += new System.EventHandler(this.menuSonlandir_Click);
            // 
            // aracBindingSource
            // 
            this.aracBindingSource.DataSource = typeof(EntityLayer.Otopark.Arac);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.PLAKA,
            this.ARACTIPADI,
            this.colAracTipNo,
            this.colAboneNo,
            this.ABONEMI,
            this.GIRISTARIHI,
            this.KONTAK});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // PLAKA
            // 
            this.PLAKA.FieldName = "PLAKA";
            this.PLAKA.Name = "PLAKA";
            this.PLAKA.Visible = true;
            this.PLAKA.VisibleIndex = 0;
            // 
            // ARACTIPADI
            // 
            this.ARACTIPADI.FieldName = "ARACTIPADI";
            this.ARACTIPADI.Name = "ARACTIPADI";
            this.ARACTIPADI.Visible = true;
            this.ARACTIPADI.VisibleIndex = 2;
            // 
            // colAracTipNo
            // 
            this.colAracTipNo.FieldName = "AracTipNo";
            this.colAracTipNo.Name = "colAracTipNo";
            // 
            // colAboneNo
            // 
            this.colAboneNo.FieldName = "AboneNo";
            this.colAboneNo.Name = "colAboneNo";
            // 
            // ABONEMI
            // 
            this.ABONEMI.FieldName = "ABONEMI";
            this.ABONEMI.Name = "ABONEMI";
            this.ABONEMI.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.ABONEMI.Visible = true;
            this.ABONEMI.VisibleIndex = 3;
            // 
            // GIRISTARIHI
            // 
            this.GIRISTARIHI.FieldName = "GIRISTARIHI";
            this.GIRISTARIHI.Name = "GIRISTARIHI";
            this.GIRISTARIHI.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.GIRISTARIHI.Visible = true;
            this.GIRISTARIHI.VisibleIndex = 4;
            // 
            // KONTAK
            // 
            this.KONTAK.FieldName = "KONTAK";
            this.KONTAK.Name = "KONTAK";
            this.KONTAK.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.KONTAK.Visible = true;
            this.KONTAK.VisibleIndex = 1;
            // 
            // AraclarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 516);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "AraclarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araçlar";
            this.Load += new System.EventHandler(this.AraclarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboAracTipi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aracBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.SimpleButton btnAramaYap;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.TextEdit txtAdi;
        private DevExpress.XtraEditors.TextEdit txtSoyadi;
        private DevExpress.XtraEditors.TextEdit txtTelefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.ComboBoxEdit comboAracTipi;
        private DevExpress.XtraEditors.TextEdit txtPlaka;
        private System.Windows.Forms.CheckBox checkKontak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource aracBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn PLAKA;
        private DevExpress.XtraGrid.Columns.GridColumn ARACTIPADI;
        private DevExpress.XtraGrid.Columns.GridColumn colAracTipNo;
        private DevExpress.XtraGrid.Columns.GridColumn colAboneNo;
        private DevExpress.XtraGrid.Columns.GridColumn ABONEMI;
        private DevExpress.XtraGrid.Columns.GridColumn GIRISTARIHI;
        private DevExpress.XtraGrid.Columns.GridColumn KONTAK;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuDuzenle;
        private System.Windows.Forms.ToolStripMenuItem menuSonlandir;
    }
}