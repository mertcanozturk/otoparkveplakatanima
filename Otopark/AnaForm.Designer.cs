namespace Otopark
{
    partial class AnaForm
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Otopark.Splash), true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnOtopark = new DevExpress.XtraBars.BarButtonItem();
            this.btnAracGiris = new DevExpress.XtraBars.BarButtonItem();
            this.btnAraclar = new DevExpress.XtraBars.BarButtonItem();
            this.btnAracTipleri = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnKasaDurumu = new DevExpress.XtraBars.BarButtonItem();
            this.btnParaGirisi = new DevExpress.XtraBars.BarButtonItem();
            this.btnParaCikisi = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnYeniAbone = new DevExpress.XtraBars.BarButtonItem();
            this.btnAboneListesi = new DevExpress.XtraBars.BarButtonItem();
            this.btnAbonelikTipleri = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnSatislar = new DevExpress.XtraBars.BarButtonItem();
            this.btnRaporlar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnAyarlar = new DevExpress.XtraBars.BarButtonItem();
            this.btnCikis = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barTarih = new DevExpress.XtraBars.BarStaticItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barToggleSwitchItem1 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 5000;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup5,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Menü";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnOtopark);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAracGiris);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAraclar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAracTipleri);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Ana İşlem Grubu";
            // 
            // btnOtopark
            // 
            this.btnOtopark.Caption = "Otopark";
            this.btnOtopark.Id = 20;
            this.btnOtopark.ImageOptions.LargeImage = global::Otopark.Properties.Resources.tend_32;
            this.btnOtopark.Name = "btnOtopark";
            // 
            // btnAracGiris
            // 
            this.btnAracGiris.Caption = "Araç Girişi";
            this.btnAracGiris.Id = 4;
            this.btnAracGiris.ImageOptions.Image = global::Otopark.Properties.Resources.Car_Key_32;
            this.btnAracGiris.ImageOptions.LargeImage = global::Otopark.Properties.Resources.Car_Key_32;
            this.btnAracGiris.Name = "btnAracGiris";
            this.btnAracGiris.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAracGiris_ItemClick);
            // 
            // btnAraclar
            // 
            this.btnAraclar.Caption = "Araçlar";
            this.btnAraclar.Id = 5;
            this.btnAraclar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAraclar.ImageOptions.Image")));
            this.btnAraclar.ImageOptions.LargeImage = global::Otopark.Properties.Resources.Car_48;
            this.btnAraclar.Name = "btnAraclar";
            this.btnAraclar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAraclar_ItemClick);
            // 
            // btnAracTipleri
            // 
            this.btnAracTipleri.Caption = "Araç Tipleri";
            this.btnAracTipleri.Id = 19;
            this.btnAracTipleri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAracTipleri.ImageOptions.Image")));
            this.btnAracTipleri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAracTipleri.ImageOptions.LargeImage")));
            this.btnAracTipleri.Name = "btnAracTipleri";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnKasaDurumu);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnParaGirisi);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnParaCikisi);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Kasa İşlemleri";
            // 
            // btnKasaDurumu
            // 
            this.btnKasaDurumu.Caption = "Kasa Durumu";
            this.btnKasaDurumu.Id = 18;
            this.btnKasaDurumu.ImageOptions.LargeImage = global::Otopark.Properties.Resources.Safe_Box_32;
            this.btnKasaDurumu.Name = "btnKasaDurumu";
            // 
            // btnParaGirisi
            // 
            this.btnParaGirisi.Caption = "Para Girişi";
            this.btnParaGirisi.Id = 21;
            this.btnParaGirisi.ImageOptions.LargeImage = global::Otopark.Properties.Resources.para_ekle;
            this.btnParaGirisi.Name = "btnParaGirisi";
            // 
            // btnParaCikisi
            // 
            this.btnParaCikisi.Caption = "Para Çıkışı";
            this.btnParaCikisi.Id = 22;
            this.btnParaCikisi.ImageOptions.LargeImage = global::Otopark.Properties.Resources.para_cikar;
            this.btnParaCikisi.Name = "btnParaCikisi";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnYeniAbone);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnAboneListesi);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnAbonelikTipleri);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Abone İşlemleri";
            // 
            // btnYeniAbone
            // 
            this.btnYeniAbone.Caption = "Yeni Abone";
            this.btnYeniAbone.Id = 8;
            this.btnYeniAbone.ImageOptions.LargeImage = global::Otopark.Properties.Resources.User_Plus_48;
            this.btnYeniAbone.Name = "btnYeniAbone";
            this.btnYeniAbone.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnYeniAbone_ItemClick);
            // 
            // btnAboneListesi
            // 
            this.btnAboneListesi.Caption = "Abone Listesi";
            this.btnAboneListesi.Id = 9;
            this.btnAboneListesi.ImageOptions.LargeImage = global::Otopark.Properties.Resources.Userlist_48;
            this.btnAboneListesi.Name = "btnAboneListesi";
            this.btnAboneListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAboneListesi_ItemClick);
            // 
            // btnAbonelikTipleri
            // 
            this.btnAbonelikTipleri.Caption = "Abonelik Tipleri";
            this.btnAbonelikTipleri.Id = 10;
            this.btnAbonelikTipleri.ImageOptions.LargeImage = global::Otopark.Properties.Resources.substip_48;
            this.btnAbonelikTipleri.Name = "btnAbonelikTipleri";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnSatislar);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnRaporlar);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Raporlar";
            // 
            // btnSatislar
            // 
            this.btnSatislar.Caption = "Satışlar";
            this.btnSatislar.Id = 11;
            this.btnSatislar.ImageOptions.LargeImage = global::Otopark.Properties.Resources.daily_report_32;
            this.btnSatislar.Name = "btnSatislar";
            this.btnSatislar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSatislar_ItemClick);
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.Caption = "Raporlar";
            this.btnRaporlar.Id = 12;
            this.btnRaporlar.ImageOptions.LargeImage = global::Otopark.Properties.Resources.presentation_chart_reports_sales_32;
            this.btnRaporlar.Name = "btnRaporlar";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnAyarlar);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnCikis);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Program";
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.Caption = "Ayarlar";
            this.btnAyarlar.Id = 16;
            this.btnAyarlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAyarlar.ImageOptions.Image")));
            this.btnAyarlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAyarlar.ImageOptions.LargeImage")));
            this.btnAyarlar.Name = "btnAyarlar";
            // 
            // btnCikis
            // 
            this.btnCikis.Caption = "Çıkış";
            this.btnCikis.Id = 15;
            this.btnCikis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.ImageOptions.Image")));
            this.btnCikis.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCikis.ImageOptions.LargeImage")));
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCikis_ItemClick);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.btnAracGiris,
            this.btnAraclar,
            this.barTarih,
            this.barHeaderItem1,
            this.btnYeniAbone,
            this.btnAboneListesi,
            this.btnAbonelikTipleri,
            this.btnSatislar,
            this.btnRaporlar,
            this.barToggleSwitchItem1,
            this.barButtonItem4,
            this.btnCikis,
            this.btnAyarlar,
            this.barButtonItem7,
            this.btnKasaDurumu,
            this.btnAracTipleri,
            this.btnOtopark,
            this.btnParaGirisi,
            this.btnParaCikisi});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 23;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsTouch.TouchUI = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.QuickToolbarItemLinks.Add(this.barTarih);
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl1.Size = new System.Drawing.Size(1077, 130);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Otopark";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barTarih
            // 
            this.barTarih.Caption = "Tarih : 2.10.2017 15:46:21";
            this.barTarih.Id = 6;
            this.barTarih.Name = "barTarih";
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "barHeaderItem1";
            this.barHeaderItem1.Id = 7;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // barToggleSwitchItem1
            // 
            this.barToggleSwitchItem1.Caption = "barToggleSwitchItem1";
            this.barToggleSwitchItem1.Id = 13;
            this.barToggleSwitchItem1.Name = "barToggleSwitchItem1";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 14;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "barButtonItem7";
            this.barButtonItem7.Id = 17;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPagesAndTabControlHeader;
            this.xtraTabbedMdiManager1.HeaderButtons = ((DevExpress.XtraTab.TabButtons)((DevExpress.XtraTab.TabButtons.Close | DevExpress.XtraTab.TabButtons.Default)));
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AnaForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 503);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "AnaForm";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otopark Sistemi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaForm_FormClosing);
            this.Load += new System.EventHandler(this.AnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem btnAracGiris;
        private DevExpress.XtraBars.BarButtonItem btnAraclar;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarStaticItem barTarih;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnYeniAbone;
        private DevExpress.XtraBars.BarButtonItem btnAboneListesi;
        private DevExpress.XtraBars.BarButtonItem btnAbonelikTipleri;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnSatislar;
        private DevExpress.XtraBars.BarButtonItem btnRaporlar;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem btnKasaDurumu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnAyarlar;
        private DevExpress.XtraBars.BarButtonItem btnCikis;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem btnAracTipleri;
        private DevExpress.XtraBars.BarButtonItem btnOtopark;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnParaGirisi;
        private DevExpress.XtraBars.BarButtonItem btnParaCikisi;
    }
}

