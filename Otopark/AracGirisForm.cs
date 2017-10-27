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
        BusinessLayer.Arac BsArac = new BusinessLayer.Arac();
        Classlar.Bildirim mesaj = new Classlar.Bildirim();
        BusinessLayer.Otopark Bsotopark = new BusinessLayer.Otopark();
        EntityLayer.Otopark.Arac otoparkAraci = new EntityLayer.Otopark.Arac();
        EntityLayer.Arac.AracTip aracTip = new EntityLayer.Arac.AracTip();
        List<EntityLayer.Arac.AracTip> aracTips = new List<EntityLayer.Arac.AracTip>();
        bool AboneMi = false;
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
                var sec = 1;

                _capture.SetInterval(new TimeSpan(0, 0, 0, sec));
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
            var image = e.ToImage();
            image.Save("test" + _index + ".jpg");
            string yol = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\test" + _index + ".jpg";
            processImageFile(yol);

        }

        public void plakaKontrol()
        {
            try
            {
                string plaka = txtPlaka.Text;
                plaka = plaka.Trim();
                if (plaka.Length == 7 || plaka.Length == 8)
                {
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
                        lblKalanAbonelik.Text = arac.okuZaman(fark);
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
        }
        private void btnGirisiOnayla_Click(object sender, EventArgs e)
        {
            string plaka = txtPlaka.Text;
            Bsotopark = new BusinessLayer.Otopark();
            if (Bsotopark.aracOtoparktaMi(plaka.Trim()))
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
                otoparkAraci.AboneNo = AboneMi?abone.Id:0;
                otoparkAraci.AboneMi = otoparkAraci.AboneNo>0?true:false;
                if (Bsotopark.aracKaydet(otoparkAraci))
                    mesaj.Bilgi("Araç otoparka başarıyla giriş yaptı.", "Bilgi");
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
                    var rect = boundingRectangle(result.PlatePoints);
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

                        txtPlaka.Text = plakalar[0];

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
                            lblKalanAbonelik.Text = arac.okuZaman(fark);
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


        public System.Drawing.Rectangle boundingRectangle(List<Point> points)
        {
            var minX = points.Min(p => p.X);
            var minY = points.Min(p => p.Y);
            var maxX = points.Max(p => p.X);
            var maxY = points.Max(p => p.Y);

            return new System.Drawing.Rectangle(new Point(minX, minY), new Size(maxX - minX, maxY - minY));
        }

        private static Image cropImage(Image img, System.Drawing.Rectangle cropArea)
        {
            var bmpImage = new Bitmap(img);
            return bmpImage.Clone(cropArea, bmpImage.PixelFormat);
        }

        public static Bitmap combineImages(List<Image> images)
        {
            Bitmap finalImage = null;

            try
            {
                var width = 0;
                var height = 0;

                foreach (var bmp in images)
                {
                    width += bmp.Width;
                    height = bmp.Height > height ? bmp.Height : height;
                }

                finalImage = new Bitmap(width, height);

                using (var g = Graphics.FromImage(finalImage))
                {
                    g.Clear(Color.Black);

                    var offset = 0;
                    foreach (Bitmap image in images)
                    {
                        g.DrawImage(image,
                                    new System.Drawing.Rectangle(offset, 0, image.Width, image.Height));
                        offset += image.Width;
                    }
                }

                return finalImage;
            }
            catch (Exception ex)
            {
                if (finalImage != null)
                    finalImage.Dispose();

                throw ex;
            }
            finally
            {
                foreach (var image in images)
                {
                    image.Dispose();
                }
            }
        }

        private void AracGirisForm_Load(object sender, EventArgs e)
        {
            aracTips=BsArac.AracTipGetir();

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

        private void txtPlaka_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtPlaka_TextChanged(object sender, EventArgs e)
        {
            abone = new EntityLayer.Arac.AboneBilgileri();
            arac = new EntityLayer.Arac();
            aboneTip = new EntityLayer.Arac.AboneTip();
            otoparkAraci = new EntityLayer.Otopark.Arac();
            lblAdi.Text = "";
            lblAboneTipi.Text = "";
            comboArac.Text = "";
            lblKalanAbonelik.Text = "";
            lblSoyadi.Text = "";
            lblTelefon.Text = "";
            lblAracAboneDegil.Visible = true;
            plakaKontrol();
        }

        private void txtFiyat_Leave(object sender, EventArgs e)
        {

        }

        private void comboArac_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }

}