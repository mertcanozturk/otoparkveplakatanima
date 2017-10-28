namespace Otopark
{
    partial class AboneListesiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboneListesiForm));
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.aboneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlaka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAracTipAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAracTipId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGirisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBitisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAbonelikTipiNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAbonelikAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKullaniciId = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboAracTipi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaka.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(232, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(977, 489);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Aboneler";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.aboneBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(973, 467);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // aboneBindingSource
            // 
            this.aboneBindingSource.DataSource = typeof(EntityLayer.Abone);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colAdi,
            this.colSoyadi,
            this.colAdres,
            this.colTelefon,
            this.colPlaka,
            this.colAracTipAdi,
            this.colAracTipId,
            this.colGirisTarihi,
            this.colBitisTarihi,
            this.colAbonelikTipiNo,
            this.colAbonelikAdi,
            this.colFiyat,
            this.colKullaniciId});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 30;
            // 
            // colId
            // 
            this.colId.AppearanceCell.Options.UseTextOptions = true;
            this.colId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colId.AppearanceHeader.Options.UseTextOptions = true;
            this.colId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colAdi
            // 
            this.colAdi.AppearanceCell.Options.UseTextOptions = true;
            this.colAdi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAdi.AppearanceHeader.Options.UseTextOptions = true;
            this.colAdi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAdi.FieldName = "Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.Visible = true;
            this.colAdi.VisibleIndex = 0;
            this.colAdi.Width = 64;
            // 
            // colSoyadi
            // 
            this.colSoyadi.AppearanceCell.Options.UseTextOptions = true;
            this.colSoyadi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoyadi.AppearanceHeader.Options.UseTextOptions = true;
            this.colSoyadi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoyadi.FieldName = "Soyadi";
            this.colSoyadi.Name = "colSoyadi";
            this.colSoyadi.Visible = true;
            this.colSoyadi.VisibleIndex = 1;
            this.colSoyadi.Width = 77;
            // 
            // colAdres
            // 
            this.colAdres.AppearanceCell.Options.UseTextOptions = true;
            this.colAdres.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAdres.AppearanceHeader.Options.UseTextOptions = true;
            this.colAdres.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAdres.FieldName = "Adres";
            this.colAdres.Name = "colAdres";
            this.colAdres.Visible = true;
            this.colAdres.VisibleIndex = 2;
            this.colAdres.Width = 303;
            // 
            // colTelefon
            // 
            this.colTelefon.AppearanceCell.Options.UseTextOptions = true;
            this.colTelefon.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTelefon.AppearanceHeader.Options.UseTextOptions = true;
            this.colTelefon.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTelefon.FieldName = "Telefon";
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.Visible = true;
            this.colTelefon.VisibleIndex = 3;
            this.colTelefon.Width = 70;
            // 
            // colPlaka
            // 
            this.colPlaka.AppearanceCell.Options.UseTextOptions = true;
            this.colPlaka.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlaka.AppearanceHeader.Options.UseTextOptions = true;
            this.colPlaka.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlaka.FieldName = "Plaka";
            this.colPlaka.Name = "colPlaka";
            this.colPlaka.Visible = true;
            this.colPlaka.VisibleIndex = 4;
            // 
            // colAracTipAdi
            // 
            this.colAracTipAdi.AppearanceCell.Options.UseTextOptions = true;
            this.colAracTipAdi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAracTipAdi.AppearanceHeader.Options.UseTextOptions = true;
            this.colAracTipAdi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAracTipAdi.FieldName = "AracTipAdi";
            this.colAracTipAdi.Name = "colAracTipAdi";
            this.colAracTipAdi.Visible = true;
            this.colAracTipAdi.VisibleIndex = 5;
            this.colAracTipAdi.Width = 82;
            // 
            // colAracTipId
            // 
            this.colAracTipId.AppearanceCell.Options.UseTextOptions = true;
            this.colAracTipId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAracTipId.AppearanceHeader.Options.UseTextOptions = true;
            this.colAracTipId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAracTipId.FieldName = "AracTipId";
            this.colAracTipId.Name = "colAracTipId";
            this.colAracTipId.Width = 110;
            // 
            // colGirisTarihi
            // 
            this.colGirisTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colGirisTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGirisTarihi.AppearanceHeader.Options.UseTextOptions = true;
            this.colGirisTarihi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGirisTarihi.FieldName = "GirisTarihi";
            this.colGirisTarihi.Name = "colGirisTarihi";
            this.colGirisTarihi.Visible = true;
            this.colGirisTarihi.VisibleIndex = 6;
            this.colGirisTarihi.Width = 98;
            // 
            // colBitisTarihi
            // 
            this.colBitisTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colBitisTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBitisTarihi.AppearanceHeader.Options.UseTextOptions = true;
            this.colBitisTarihi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBitisTarihi.FieldName = "BitisTarihi";
            this.colBitisTarihi.Name = "colBitisTarihi";
            this.colBitisTarihi.Visible = true;
            this.colBitisTarihi.VisibleIndex = 7;
            this.colBitisTarihi.Width = 77;
            // 
            // colAbonelikTipiNo
            // 
            this.colAbonelikTipiNo.AppearanceCell.Options.UseTextOptions = true;
            this.colAbonelikTipiNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAbonelikTipiNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colAbonelikTipiNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAbonelikTipiNo.FieldName = "AbonelikTipiNo";
            this.colAbonelikTipiNo.Name = "colAbonelikTipiNo";
            this.colAbonelikTipiNo.Width = 87;
            // 
            // colAbonelikAdi
            // 
            this.colAbonelikAdi.AppearanceCell.Options.UseTextOptions = true;
            this.colAbonelikAdi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAbonelikAdi.AppearanceHeader.Options.UseTextOptions = true;
            this.colAbonelikAdi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAbonelikAdi.FieldName = "AbonelikAdi";
            this.colAbonelikAdi.Name = "colAbonelikAdi";
            this.colAbonelikAdi.Visible = true;
            this.colAbonelikAdi.VisibleIndex = 8;
            this.colAbonelikAdi.Width = 73;
            // 
            // colFiyat
            // 
            this.colFiyat.AppearanceCell.Options.UseTextOptions = true;
            this.colFiyat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFiyat.AppearanceHeader.Options.UseTextOptions = true;
            this.colFiyat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFiyat.FieldName = "Fiyat";
            this.colFiyat.Name = "colFiyat";
            this.colFiyat.Visible = true;
            this.colFiyat.VisibleIndex = 9;
            this.colFiyat.Width = 38;
            // 
            // colKullaniciId
            // 
            this.colKullaniciId.AppearanceCell.Options.UseTextOptions = true;
            this.colKullaniciId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKullaniciId.AppearanceHeader.Options.UseTextOptions = true;
            this.colKullaniciId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKullaniciId.FieldName = "KullaniciId";
            this.colKullaniciId.Name = "colKullaniciId";
            this.colKullaniciId.Width = 57;
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
            this.groupControl1.Size = new System.Drawing.Size(232, 489);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Arama";
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
            // AboneListesiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 489);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "AboneListesiForm";
            this.Text = "AboneListesiForm";
            this.Load += new System.EventHandler(this.AboneListesiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.SimpleButton btnAramaYap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkKontak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtAdi;
        private DevExpress.XtraEditors.TextEdit txtSoyadi;
        private DevExpress.XtraEditors.TextEdit txtTelefon;
        private DevExpress.XtraEditors.TextEdit txtPlaka;
        private DevExpress.XtraEditors.ComboBoxEdit comboAracTipi;
        private System.Windows.Forms.BindingSource aboneBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colSoyadi;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colPlaka;
        private DevExpress.XtraGrid.Columns.GridColumn colAracTipAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colAracTipId;
        private DevExpress.XtraGrid.Columns.GridColumn colGirisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colBitisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colAbonelikTipiNo;
        private DevExpress.XtraGrid.Columns.GridColumn colAbonelikAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colKullaniciId;
    }
}