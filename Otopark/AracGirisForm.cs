using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Ozeki.Camera;
using Ozeki.Media;
using openalprnet;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Data;

namespace Otopark
{
    public partial class AracGirisForm : DevExpress.XtraEditors.XtraForm
    {
        private int _index = 0;
        private FrameCapture _capture;
        private WebCamera _webCamera;
        private MediaConnector _connector;
        private DrawingImageProvider _liveProvider;
        private DrawingImageProvider _frameCaptureProvider;

        EntityLayer.Arac arac = new EntityLayer.Arac();
        EntityLayer.Arac.AboneBilgileri abone = new EntityLayer.Arac.AboneBilgileri();
        EntityLayer.Arac.AboneTip aboneTip = new EntityLayer.Arac.AboneTip();
        EntityLayer.Satis satis = new EntityLayer.Satis();
        EntityLayer.Otopark.Arac otoparkAraci = new EntityLayer.Otopark.Arac();
        EntityLayer.Arac.AracTip aracTip = new EntityLayer.Arac.AracTip();

        BusinessLayer.Arac BsArac = new BusinessLayer.Arac();
        BusinessLayer.Otopark Bsotopark = new BusinessLayer.Otopark();
        BusinessLayer.Satis BsSatis = new BusinessLayer.Satis();
        BusinessLayer.Kasa kasa = new BusinessLayer.Kasa();
        List<EntityLayer.Arac.AracTip> aracTips = new List<EntityLayer.Arac.AracTip>();

        Classlar.Bildirim mesaj = new Classlar.Bildirim();
        Classlar.AracGiris aracGirisControl = new Classlar.AracGiris();
        Classlar.AracCikis aracCikisControl = new Classlar.AracCikis();

        bool AboneMi = false;
        string oncekiPlaka = "";
        public static string AssemblyDirectory
        {
            get
            {
                var codeBase = Assembly.GetExecutingAssembly().CodeBase;
                var uri = new UriBuilder(codeBase);
                var path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }
        public AracGirisForm()
        {
            InitializeComponent();
            _liveProvider = new DrawingImageProvider();
            _frameCaptureProvider = new DrawingImageProvider();
            _capture = new FrameCapture();
            _connector = new MediaConnector();
            ConnectLive1();
            Yakala();
        }
        void ConnectLive1()
        {
            try
            {
                _webCamera = new WebCamera();
                _connector.Connect(_webCamera, _liveProvider);
                _connector.Connect(_webCamera, _capture);
                _connector.Connect(_capture, _frameCaptureProvider);
                liveViewer.SetImageProvider(_liveProvider);
                liveViewer.Start();
                captureViewer.SetImageProvider(_frameCaptureProvider);
                captureViewer.Start();
                _webCamera.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Yakala()
        {
            try
            {

                _capture.SetInterval(new TimeSpan(1000));
                _capture.Start();
                _capture.OnFrameCaptured += _capture_OnFrameCaptured;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void YakalamayıDurdur()
        {

            _capture.Stop();
            _capture.OnFrameCaptured -= _capture_OnFrameCaptured;
        }
        void _capture_OnFrameCaptured(object sender, Ozeki.Media.Snapshot e)
        {
            try
            {
                var image = e.ToImage();
                image.Save("test" + _index + ".jpg");
                string yol = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\test" + _index + ".jpg";
                processImageFile(yol);
            }
            catch (Exception)
            {

            }


        }

        public void plakaKontrol()
        {
            try
            {
                string plaka = txtPlaka.Text;
                plaka = plaka.Trim();
                
                if (plaka.Length == 7 || plaka.Length == 8)
                {

                    if (plaka == oncekiPlaka)
                    {
                        lblAracAboneDegil.Visible = true; ;
                        lblAracAboneDegil.Text = "ARAÇ ABONE DEĞİL.";
                        AboneMi = BsArac.AboneMi(plaka.Trim());

                        if (AboneMi)
                        {
                            lblAracAboneDegil.Visible = false;
                            abone = BsArac.AboneGetir(plaka);
                            lblAdi.Text = abone.Adi;
                            lblAboneTipi.Text = abone.AbonelikAdi;
                            comboArac.Text = abone.AracTipAdi;
                            TimeSpan fark = abone.BitisTarihi - DateTime.Now;
                            if (fark.Minutes < 1)
                            {
                                lblAracAboneDegil.Visible = true;
                                lblAracAboneDegil.Text = "ABONELİĞİ BİTTİ.";
                                lblKalanAbonelik.Text = "0 gün 0 saat 0 dakika";
                                AboneMi = false;
                            }
                            else
                            {
                                lblKalanAbonelik.Text = arac.okuZaman(fark);

                            }
                            lblSoyadi.Text = abone.Soyadi;
                            lblTelefon.Text = abone.Telefon;

                        }
                        else
                        {
                            lblAracAboneDegil.Visible = true;
                        }

                        btnGirisiOnayla.Enabled = true;
                    }
                    oncekiPlaka = plaka;
                   

                } 
            }
            catch (Exception e)
            {

            }
        }
        private void btnGirisiOnayla_Click(object sender, EventArgs e)
        {
            string plaka = txtPlaka.Text;
            Bsotopark = new BusinessLayer.Otopark();
            if (aracGirisControl.AracOtoparktaMi(plaka.Trim()))
                mesaj.Uyari("Araç zaten otoparkta", "Uyarı");
            else
            {
                foreach (var item in aracTips)
                {
                    if (item.Adi == comboArac.Text)
                        otoparkAraci.AracTipNo = item.Id;
                }
                otoparkAraci.GirisTarihi = DateTime.Now;
                otoparkAraci.AracTipAdi = comboArac.Text;
                otoparkAraci.Kontak = checkBox1.Checked;
                otoparkAraci.Plaka = plaka.Trim();
                otoparkAraci.AboneNo = AboneMi ? abone.Id : 0;
                otoparkAraci.AboneMi = AboneMi;
                if (Bsotopark.aracKaydet(otoparkAraci))
                {
                    mesaj.Bilgi("Araç otoparka başarıyla giriş yaptı.", "Bilgi");
                    this.Close();
                }
                   

                else
                    mesaj.Uyari("Kaydederken veritabanında bir hata oluştu", "Uyarı");
            }

        }

        private void processImageFile(string fileName)
        {
            var region = "eu";
            String config_file = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\openalpr.conf";
            String runtime_data_dir = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\runtime_data";
            using (var alpr = new AlprNet(region, config_file, runtime_data_dir))
            {
                if (!alpr.IsLoaded())
                {
                    lblAracAboneDegil.Text = "Error initializing OpenALPR";
                    return;
                }
                var results = alpr.Recognize(fileName);
                List<string> plakalar = new List<string>();

                var images = new List<Image>(results.Plates.Count());
                //var i = 1;
                foreach (var result in results.Plates)
                {
                    var rect = aracGirisControl.boundingRectangle(result.PlatePoints);
                    var img = Image.FromFile(fileName);
                    var cropped = cropImage(img, rect);
                    images.Add(cropped);

                    foreach (var plate in result.TopNPlates)
                    {
                        plakalar.Add(plate.Characters.PadRight(12));
                    }
                }
                Control.CheckForIllegalCrossThreadCalls = false;

                try
                {
                    string plaka = plakalar[0];
                    plaka = plaka.Trim();
                    if (plaka.Length == 7 || plaka.Length == 8)
                    {
                        AboneMi = false;
                        txtPlaka.Text = plakalar[0];
                        lblAracAboneDegil.Visible = true; ;
                        lblAracAboneDegil.Text = "ARAÇ ABONE DEĞİL.";

                        string plaka1 = txtPlaka.Text;
                        AboneMi = BsArac.AboneMi(plaka1.Trim());
                        if (AboneMi)
                        {

                            lblAracAboneDegil.Visible = false;
                            abone = BsArac.AboneGetir(plaka);
                            lblAdi.Text = abone.Adi;
                            lblAboneTipi.Text = abone.AbonelikAdi;
                            comboArac.Text = abone.AracTipAdi;
                            TimeSpan fark = abone.BitisTarihi - DateTime.Now;
                            if (fark.Minutes < 1)
                            {
                                lblAracAboneDegil.Visible = true;
                                lblAracAboneDegil.Text = "ARAÇ ABONELİK SÜRESİ SONA ERDİ.";
                                lblKalanAbonelik.Text = "0 gün 0 saat 0 dakika";
                                AboneMi = false;
                            }
                            else
                            {
                                AboneMi = true;
                                lblKalanAbonelik.Text = arac.okuZaman(fark);

                            }
                            lblSoyadi.Text = abone.Soyadi;
                            lblTelefon.Text = abone.Telefon;

                        }
                        else
                        {
                            lblAracAboneDegil.Visible = true;
                        }

                        btnGirisiOnayla.Enabled = true;

                    }
                }
                catch (Exception e)
                {

                }

                plakalar.Clear();

            }

        }



        private static Image cropImage(Image img, System.Drawing.Rectangle cropArea)
        {
            var bmpImage = new Bitmap(img);
            return bmpImage.Clone(cropArea, bmpImage.PixelFormat);
        }



        private void AracGirisForm_Load(object sender, EventArgs e)
        {
            aracTips = BsArac.AracTipGetir();

            foreach (var item in aracTips)
            {
                comboArac.Properties.Items.Add(item.Adi);
            }
            comboArac.SelectedIndex = 0;

        }

        private void txtPlaka_EditValueChanged(object sender, EventArgs e)
        {
            abone = new EntityLayer.Arac.AboneBilgileri();
            arac = new EntityLayer.Arac();
            aboneTip = new EntityLayer.Arac.AboneTip();
            otoparkAraci = new EntityLayer.Otopark.Arac();
            plakaKontrol();


        }

        private void txtPlaka_TextChanged(object sender, EventArgs e)
        {
            abone = new EntityLayer.Arac.AboneBilgileri();
            arac = new EntityLayer.Arac();
            aboneTip = new EntityLayer.Arac.AboneTip();
            otoparkAraci = new EntityLayer.Otopark.Arac();
            lblAdi.Text = "";
            lblAboneTipi.Text = "";
            comboArac.Text = "Otomobil";
            lblKalanAbonelik.Text = "";
            lblSoyadi.Text = "";
            lblTelefon.Text = "";
            lblAracAboneDegil.Visible = true;
            plakaKontrol();
        }

        private void BtnCikisYap_Click(object sender, EventArgs e)
        {
            satis = new EntityLayer.Satis();
            otoparkAraci = new EntityLayer.Otopark.Arac();

            string plaka = txtPlaka.Text;
            if (!Bsotopark.aracOtoparktaMi(plaka.Trim()))
                mesaj.Uyari("Araç otoparkta değil!", "Uyarı");
            else
            {
                DataRow OtoparkAraci = Bsotopark.AracGetir(plaka.Trim());
                satis.AracTipNo = Convert.ToInt32(OtoparkAraci[2]);
                satis.Plaka = OtoparkAraci[1].ToString();
                satis.AboneNo = Convert.ToInt32(OtoparkAraci[3].ToString());
                satis.GirisTarihi = Convert.ToDateTime(OtoparkAraci[4]);
                satis.Kontak = Convert.ToBoolean(OtoparkAraci[5]);
                satis.Ucret = aracCikisControl.UcretHesapla(satis.AracTipNo, satis.GirisTarihi);
                satis.CikisTarihi = DateTime.Now;
                satis.KullaniciId = 1;

                if (mesaj.Soru("Araç otoparktan silinsin mi?", "Araç Çıkış"))
                    if (BsSatis.Kaydet(satis))
                    {
                        if (Bsotopark.aracSil(plaka.Trim()))
                            mesaj.Bilgi("Araç çıkışı yapıldı.", "Bilgi");
                        else
                            mesaj.Hata("Silerken hata oluştu.", "Hata");
                        if (kasa.ParaEkle(satis.Ucret)) { }
                        else mesaj.Hata("Kasaya para eklenirken hata oluştu","Hata");                     
                    }
                    else
                        mesaj.Hata("Satışı kaydederken hata oluştu.", "Hata");
                else
                    mesaj.Bilgi("İptal edildi.", "Bilgi");
            }

        }

        private void AracGirisForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _webCamera.Dispose();
            _liveProvider.Dispose();

            
        }
    }

}