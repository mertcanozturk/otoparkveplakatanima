namespace Otopark
{
    partial class Splash
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
            this.marqueeProgressBarControl1 = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblYuzde = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.lblcopy = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // marqueeProgressBarControl1
            // 
            this.marqueeProgressBarControl1.EditValue = 0;
            this.marqueeProgressBarControl1.Location = new System.Drawing.Point(46, 35);
            this.marqueeProgressBarControl1.Name = "marqueeProgressBarControl1";
            this.marqueeProgressBarControl1.Size = new System.Drawing.Size(336, 12);
            this.marqueeProgressBarControl1.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(46, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(144, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Otopark Uygulaması Başlıyor..";
            // 
            // lblYuzde
            // 
            this.lblYuzde.Location = new System.Drawing.Point(12, 34);
            this.lblYuzde.Name = "lblYuzde";
            this.lblYuzde.Size = new System.Drawing.Size(17, 13);
            this.lblYuzde.TabIndex = 8;
            this.lblYuzde.Text = "%0";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = global::Otopark.Properties.Resources.otopark;
            this.pictureEdit1.Location = new System.Drawing.Point(12, 53);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(370, 174);
            this.pictureEdit1.TabIndex = 9;
            // 
            // lblcopy
            // 
            this.lblcopy.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblcopy.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.lblcopy.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.lblcopy.Appearance.Options.UseBackColor = true;
            this.lblcopy.Appearance.Options.UseBorderColor = true;
            this.lblcopy.LineColor = System.Drawing.Color.Transparent;
            this.lblcopy.Location = new System.Drawing.Point(295, 233);
            this.lblcopy.Name = "lblcopy";
            this.lblcopy.Size = new System.Drawing.Size(87, 13);
            this.lblcopy.TabIndex = 10;
            this.lblcopy.Text = "Copyright © 2017";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 259);
            this.Controls.Add(this.lblcopy);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.lblYuzde);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.marqueeProgressBarControl1);
            this.Name = "Splash";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MarqueeProgressBarControl marqueeProgressBarControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblYuzde;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl lblcopy;
        private System.Windows.Forms.Timer timer1;
    }
}
