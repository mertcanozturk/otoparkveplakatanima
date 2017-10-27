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
            foreach (int i in gridView1.GetSelectedRows())
            {
                //row[0]= PLAKA
                DataRow row = gridView1.GetDataRow(i);
                DataRow OtoparkAraci = Bsotopark.AracGetir(row[0].ToString());
                
                satis.AracTipNo = Convert.ToInt32(OtoparkAraci[2]);
                satis.Plaka = OtoparkAraci[1].ToString();
                satis.AboneNo = Convert.ToInt32(OtoparkAraci[3].ToString());
                satis.GirisTarihi = Convert.ToDateTime(OtoparkAraci[4]);
                satis.Kontak = Convert.ToBoolean(OtoparkAraci[5]);
                satis.Ucret = control.UcretHesapla(satis.AracTipNo, satis.GirisTarihi);
                satis.CikisTarihi = DateTime.Now;
                satis.KullaniciId = 1;

                if (bildirim.Soru("Araç otoparktan silinsin mi?", "Araç Çıkış"))
                    if (BsSatis.Kaydet(satis))
                    {
                        if (Bsotopark.aracSil(row[0].ToString()))
                            bildirim.Bilgi("Araç çıkışı yapıldı.", "Bilgi");
                        else
                            bildirim.Hata("Silerken hata oluştu.", "Hata");
                    }
                    else
                        bildirim.Hata("Satışı kaydederken hata oluştu.", "Hata");
                else
                    bildirim.Bilgi("İptal edildi.", "Bilgi");

                Listele();
            }
        }

        private void menuDuzenle_Click(object sender, EventArgs e)
        {
            DateTime dt = Convert.ToDateTime("2017 - 10 - 27 10:02:17.000");
            decimal a = control.UcretHesapla(1, dt);
            MessageBox.Show(a.ToString());
        }
    }
}