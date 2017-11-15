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
    public partial class KasaGirisForm : DevExpress.XtraEditors.XtraForm
    {
        BusinessLayer.Kasa BsKasa = new BusinessLayer.Kasa();
        EntityLayer.KasaIslemi kasaIslem = new EntityLayer.KasaIslemi();
        Classlar.Bildirim bildirim = new Classlar.Bildirim();
        public KasaGirisForm()
        {
            InitializeComponent();
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            kasaIslem.Aciklama = txtAciklama.Text;
            kasaIslem.IslemTipi = "Kasa Giriş";
            kasaIslem.Tarih = DateTime.Now;
            kasaIslem.Ucret = Convert.ToDecimal(txtUcret.Text);
            if (BsKasa.IslemEkle(kasaIslem))
            {
                if (BsKasa.ParaEkle(kasaIslem.Ucret))
                    bildirim.Bilgi("Kasa girişi yapıldı", "Başarılı!");
                else
                {
                    BsKasa.SonKayitSil();
                    bildirim.Hata("Kasa girişi yapılırken bir hata oluştu.", "Hata");
                }

            }
            else
                bildirim.Hata("Kasa girişi yapılırken bir hata oluştu.", "Hata");
        }

        private void btnIptalEt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}