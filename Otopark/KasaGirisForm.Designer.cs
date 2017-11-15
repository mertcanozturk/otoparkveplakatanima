namespace Otopark
{
    partial class KasaGirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KasaGirisForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUcret = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.btnIptalEt = new DevExpress.XtraEditors.SimpleButton();
            this.btnTamamla = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtUcret.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ücret";
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(29, 42);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(168, 20);
            this.txtUcret.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Açıklama";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(29, 92);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(269, 117);
            this.txtAciklama.TabIndex = 1;
            // 
            // btnIptalEt
            // 
            this.btnIptalEt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIptalEt.ImageOptions.Image")));
            this.btnIptalEt.Location = new System.Drawing.Point(223, 221);
            this.btnIptalEt.Name = "btnIptalEt";
            this.btnIptalEt.Size = new System.Drawing.Size(75, 23);
            this.btnIptalEt.TabIndex = 2;
            this.btnIptalEt.Text = "İptal Et";
            this.btnIptalEt.Click += new System.EventHandler(this.btnIptalEt_Click);
            // 
            // btnTamamla
            // 
            this.btnTamamla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTamamla.ImageOptions.Image")));
            this.btnTamamla.Location = new System.Drawing.Point(138, 221);
            this.btnTamamla.Name = "btnTamamla";
            this.btnTamamla.Size = new System.Drawing.Size(75, 23);
            this.btnTamamla.TabIndex = 2;
            this.btnTamamla.Text = "Tamamla";
            this.btnTamamla.Click += new System.EventHandler(this.btnTamamla_Click);
            // 
            // KasaGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 256);
            this.Controls.Add(this.btnIptalEt);
            this.Controls.Add(this.btnTamamla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUcret);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAciklama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KasaGirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa Para Girişi";
            ((System.ComponentModel.ISupportInitialize)(this.txtUcret.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtUcret;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.SimpleButton btnTamamla;
        private DevExpress.XtraEditors.SimpleButton btnIptalEt;
    }
}