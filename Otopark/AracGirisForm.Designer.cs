namespace Otopark
{
    partial class AracGirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracGirisForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.comboArac = new DevExpress.XtraEditors.ComboBoxEdit();
            this.captureViewer = new Ozeki.Media.VideoViewerWF();
            this.BtnCikisYap = new DevExpress.XtraEditors.SimpleButton();
            this.btnGirisiOnayla = new DevExpress.XtraEditors.SimpleButton();
            this.lblAracAboneDegil = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblKalanAbonelik = new System.Windows.Forms.Label();
            this.lblAboneTipi = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblSoyadi = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAdi = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlaka = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.liveViewer = new Ozeki.Media.VideoViewerWF();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboArac.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaka.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.comboArac);
            this.groupControl1.Controls.Add(this.captureViewer);
            this.groupControl1.Controls.Add(this.BtnCikisYap);
            this.groupControl1.Controls.Add(this.btnGirisiOnayla);
            this.groupControl1.Controls.Add(this.lblAracAboneDegil);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Controls.Add(this.checkBox1);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtPlaka);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(244, 547);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Araç Bilgileri";
            // 
            // comboArac
            // 
            this.comboArac.Location = new System.Drawing.Point(69, 236);
            this.comboArac.Name = "comboArac";
            this.comboArac.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboArac.Size = new System.Drawing.Size(92, 20);
            this.comboArac.TabIndex = 14;
            // 
            // captureViewer
            // 
            this.captureViewer.BackColor = System.Drawing.Color.White;
            this.captureViewer.ContextMenuEnabled = true;
            this.captureViewer.FlipMode = Ozeki.Media.FlipMode.None;
            this.captureViewer.FrameStretch = Ozeki.Media.FrameStretch.Uniform;
            this.captureViewer.FullScreenEnabled = true;
            this.captureViewer.Location = new System.Drawing.Point(14, 24);
            this.captureViewer.Name = "captureViewer";
            this.captureViewer.RotateAngle = 0;
            this.captureViewer.Size = new System.Drawing.Size(221, 176);
            this.captureViewer.TabIndex = 13;
            this.captureViewer.Text = "captureViewer";
            // 
            // BtnCikisYap
            // 
            this.BtnCikisYap.AppearancePressed.Options.UseTextOptions = true;
            this.BtnCikisYap.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.BtnCikisYap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnCikisYap.ImageOptions.Image")));
            this.BtnCikisYap.Location = new System.Drawing.Point(14, 507);
            this.BtnCikisYap.Name = "BtnCikisYap";
            this.BtnCikisYap.Size = new System.Drawing.Size(212, 35);
            this.BtnCikisYap.TabIndex = 8;
            this.BtnCikisYap.Text = "Çıkış Yap";
            this.BtnCikisYap.Click += new System.EventHandler(this.BtnCikisYap_Click);
            // 
            // btnGirisiOnayla
            // 
            this.btnGirisiOnayla.AppearancePressed.Options.UseTextOptions = true;
            this.btnGirisiOnayla.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnGirisiOnayla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGirisiOnayla.ImageOptions.Image")));
            this.btnGirisiOnayla.Location = new System.Drawing.Point(15, 464);
            this.btnGirisiOnayla.Name = "btnGirisiOnayla";
            this.btnGirisiOnayla.Size = new System.Drawing.Size(211, 35);
            this.btnGirisiOnayla.TabIndex = 8;
            this.btnGirisiOnayla.Text = "Giriş Yap";
            this.btnGirisiOnayla.Click += new System.EventHandler(this.btnGirisiOnayla_Click);
            // 
            // lblAracAboneDegil
            // 
            this.lblAracAboneDegil.AutoSize = true;
            this.lblAracAboneDegil.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblAracAboneDegil.ForeColor = System.Drawing.Color.Red;
            this.lblAracAboneDegil.Location = new System.Drawing.Point(66, 280);
            this.lblAracAboneDegil.Name = "lblAracAboneDegil";
            this.lblAracAboneDegil.Size = new System.Drawing.Size(113, 13);
            this.lblAracAboneDegil.TabIndex = 5;
            this.lblAracAboneDegil.Text = "ARAÇ ABONE DEĞİL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblKalanAbonelik);
            this.groupBox1.Controls.Add(this.lblAboneTipi);
            this.groupBox1.Controls.Add(this.lblTelefon);
            this.groupBox1.Controls.Add(this.lblSoyadi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblAdi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(9, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 151);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Abonelik Durumu";
            // 
            // lblKalanAbonelik
            // 
            this.lblKalanAbonelik.AutoSize = true;
            this.lblKalanAbonelik.Location = new System.Drawing.Point(77, 110);
            this.lblKalanAbonelik.Name = "lblKalanAbonelik";
            this.lblKalanAbonelik.Size = new System.Drawing.Size(0, 13);
            this.lblKalanAbonelik.TabIndex = 1;
            this.lblKalanAbonelik.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAboneTipi
            // 
            this.lblAboneTipi.AutoSize = true;
            this.lblAboneTipi.Location = new System.Drawing.Point(77, 88);
            this.lblAboneTipi.Name = "lblAboneTipi";
            this.lblAboneTipi.Size = new System.Drawing.Size(0, 13);
            this.lblAboneTipi.TabIndex = 1;
            this.lblAboneTipi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(77, 67);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(0, 13);
            this.lblTelefon.TabIndex = 1;
            this.lblTelefon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.AutoSize = true;
            this.lblSoyadi.Location = new System.Drawing.Point(77, 47);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(0, 13);
            this.lblSoyadi.TabIndex = 1;
            this.lblSoyadi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Kalan :";
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Location = new System.Drawing.Point(77, 27);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(0, 13);
            this.lblAdi.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Abone Tipi :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Telefon :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Soyadı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Adı :";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(167, 238);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Kontak";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Araç Tipi";
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(69, 206);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(152, 20);
            this.txtPlaka.TabIndex = 1;
            this.txtPlaka.EditValueChanged += new System.EventHandler(this.txtPlaka_EditValueChanged);
            this.txtPlaka.TextChanged += new System.EventHandler(this.txtPlaka_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaka";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.liveViewer);
            this.groupBox2.Location = new System.Drawing.Point(250, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(959, 533);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cam1";
            // 
            // liveViewer
            // 
            this.liveViewer.BackColor = System.Drawing.Color.White;
            this.liveViewer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("liveViewer.BackgroundImage")));
            this.liveViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.liveViewer.ContextMenuEnabled = true;
            this.liveViewer.FlipMode = Ozeki.Media.FlipMode.None;
            this.liveViewer.ForeColor = System.Drawing.Color.White;
            this.liveViewer.FrameStretch = Ozeki.Media.FrameStretch.Uniform;
            this.liveViewer.FullScreenEnabled = true;
            this.liveViewer.Location = new System.Drawing.Point(38, 24);
            this.liveViewer.Name = "liveViewer";
            this.liveViewer.RotateAngle = 0;
            this.liveViewer.Size = new System.Drawing.Size(881, 457);
            this.liveViewer.TabIndex = 1;
            this.liveViewer.Text = "liveViewer";
            // 
            // AracGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 547);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupControl1);
            this.Name = "AracGirisForm";
            this.Text = "Araç Giriş Çıkış";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AracGirisForm_FormClosed);
            this.Load += new System.EventHandler(this.AracGirisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboArac.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaka.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtPlaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblKalanAbonelik;
        private System.Windows.Forms.Label lblAboneTipi;
        private System.Windows.Forms.Label lblSoyadi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblAracAboneDegil;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.SimpleButton btnGirisiOnayla;
        private System.Windows.Forms.GroupBox groupBox2;
        private Ozeki.Media.VideoViewerWF captureViewer;
        private Ozeki.Media.VideoViewerWF liveViewer;
        private DevExpress.XtraEditors.ComboBoxEdit comboArac;
        private DevExpress.XtraEditors.SimpleButton BtnCikisYap;
    }
}