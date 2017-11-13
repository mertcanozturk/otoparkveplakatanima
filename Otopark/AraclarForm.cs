using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Otopark
{
    public partial class AraclarForm : DevExpress.XtraEditors.XtraForm
    {
        Classlar.Bildirim bildirim = new Classlar.Bildirim();
        BusinessLayer.Otopark Bsotopark = new BusinessLayer.Otopark();
        BusinessLayer.Satis BsSatis = new BusinessLayer.Satis();
        BusinessLayer.Arac BsArac = new BusinessLayer.Arac();

        List<EntityLayer.Arac.AracTip> aracTips = new List<EntityLayer.Arac.AracTip>();
        EntityLayer.Satis satis = new EntityLayer.Satis();
        Classlar.AracCikis control = new Classlar.AracCikis();
        public AraclarForm()
        {
            InitializeComponent();
        }

        public AraclarForm(string plaka)
        {
            InitializeComponent();
            txtPlaka.Text = plaka;
            Listele();
        }
        private void AraclarForm_Load(object sender, EventArgs e)
        {
            aracTips = BsArac.AracTipGetir();

            foreach (var item in aracTips)
            {
                comboAracTipi.Properties.Items.Add(item.Adi);
            }
            
        }
        private void Listele()
        {
            gridControl1.DataSource = null;
            gridControl1.DataSource = Bsotopark.Listele(txtPlaka.Text, checkKontak.Checked, comboAracTipi.Text);

        }
        private void btnAramaYap_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void menuSonlandir_Click(object sender, EventArgs e)
        {
            satis = new EntityLayer.Satis();
            EntityLayer.Otopark.Arac otoparkAraci = new EntityLayer.Otopark.Arac();
            Classlar.AracCikis aracCikisControl = new Classlar.AracCikis();
            BusinessLayer.Kasa kasa = new BusinessLayer.Kasa();
            string plaka = Convert.ToString(gridView1.GetFocusedRowCellValue("PLAKA"));
            if (!Bsotopark.aracOtoparktaMi(plaka.Trim()))
                bildirim.Uyari("Araç otoparkta değil!", "Uyarı");
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

                if (bildirim.Soru("Araç otoparktan silinsin mi?", "Araç Çıkış"))
                    if (BsSatis.Kaydet(satis))
                    {
                        if (Bsotopark.aracSil(plaka.Trim()))
                            bildirim.Bilgi("Araç çıkışı yapıldı.", "Bilgi");
                        else
                            bildirim.Hata("Silerken hata oluştu.", "Hata");
                        if (kasa.ParaEkle(satis.Ucret)) { }
                        else bildirim.Hata("Kasaya para eklenirken hata oluştu", "Hata");
                    }
                    else
                        bildirim.Hata("Satışı kaydederken hata oluştu.", "Hata");
                else
                    bildirim.Bilgi("İptal edildi.", "Bilgi");
            }
        }

        private void menuDuzenle_Click(object sender, EventArgs e)
        {
            DateTime dt = Convert.ToDateTime( gridView1.GetFocusedRowCellValue("GIRISTARIHI"));
            decimal a = control.UcretHesapla(1, dt);
            MessageBox.Show(a.ToString());
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}