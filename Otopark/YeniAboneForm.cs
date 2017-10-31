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

    public partial class YeniAboneForm : DevExpress.XtraEditors.XtraForm
    {
        Classlar.Bildirim bildirim = new Classlar.Bildirim();
        List<EntityLayer.AboneTip> aboneTips = new List<EntityLayer.AboneTip>();
        List<EntityLayer.Arac.AracTip> aracTips = new List<EntityLayer.Arac.AracTip>();
        BusinessLayer.Arac BsArac = new BusinessLayer.Arac();
        BusinessLayer.Abone BsAbone = new BusinessLayer.Abone();
        EntityLayer.Abone abone = new EntityLayer.Abone();
        EntityLayer.AboneTip aboneTip = new EntityLayer.AboneTip();
        EntityLayer.Arac.AracTip aracTip = new EntityLayer.Arac.AracTip();
        public YeniAboneForm()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (bildirim.Soru("Çıkmak istiyor musunuz?", "Uyarı"))
            {
                this.Close();
            }

        }

        private void YeniAboneForm_Load(object sender, EventArgs e)
        {
            aracTips = BsArac.AracTipGetir();

            foreach (var item in aracTips)
            {
                comboAracTipi.Properties.Items.Add(item.Adi);
            }
            comboAracTipi.SelectedIndex = 0;

            aboneTips = BsAbone.aboneTipGetir();

            foreach (var item in aboneTips)
            {
                comboAbonelikTipi.Properties.Items.Add(item.Adi);
            }
            comboAbonelikTipi.SelectedIndex = 0;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            abone = new EntityLayer.Abone();
            abone.Adi = txtAdi.Text;
            abone.Plaka = txtPlaka.Text;
            abone.Soyadi = txtSoyadi.Text;
            abone.Telefon = txtTelefon.Text;
            abone.AbonelikAdi = comboAbonelikTipi.Text;
            abone.Adres = txtAdres.Text;
            abone.AracTipAdi = comboAracTipi.Text;
            abone.AracTipId = BsArac.AracTipIdGetir(abone.AracTipAdi);
            aboneTip = BsAbone.aboneTipGetir(abone.AbonelikAdi);
            abone.AbonelikTipiNo = BsAbone.AbonelikTipiIdGetir(abone.AbonelikAdi);
            abone.BitisTarihi = DateTime.Now.AddDays(aboneTip.Sure);// abonetip doldurup getir
            abone.Fiyat = aboneTip.Ucret;
            abone.GirisTarihi = DateTime.Now;
            abone.KullaniciId = 1;

            if (BsAbone.Kaydet(abone))
            {
                bildirim.Bilgi("Kayıt işlemi başarı ile gerçekleşti", "Bilgi");
                this.Close();
            }
            else
            {
                bildirim.Uyari("Kayıt işlemi gerçekleşirken bir hata oluştu.", "Hata");
            }

        }
    }
}