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
    public partial class AracTipleriForm : DevExpress.XtraEditors.XtraForm
    {
        BusinessLayer.Arac BsaracTip = new BusinessLayer.Arac();
        List<EntityLayer.Arac.AracTip> aracTipList = new List<EntityLayer.Arac.AracTip>();
        EntityLayer.Arac.AracTip aracTip = new EntityLayer.Arac.AracTip();
        Classlar.Bildirim bildirim = new Classlar.Bildirim();
        public AracTipleriForm()
        {
            InitializeComponent();
        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            aracTip = new EntityLayer.Arac.AracTip();
            aracTip.Adi = txtAracTipAdi.Text;
            aracTip.Adi = txtAracTipAdi.Text;
            string s = txtAracTipFiyati.Text;
            s = s.Replace('.', ',');
            aracTip.Fiyat = Convert.ToDecimal(s);
            if (!BsaracTip.AracTipEkle(aracTip))
                bildirim.Hata("Kayıt eklenirken bir veritabanı hatası oluştu.", "Hata");
            Listele();

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            aracTip.Adi = txtAracTipAdi.Text;
            string s = txtAracTipFiyati.Text;
            s = s.Replace('.', ',');
            aracTip.Fiyat = Convert.ToDecimal(s);
            if (BsaracTip.AracTipGuncelle(aracTip))
            {
                bildirim.Bilgi("Başarıyla güncellendi.", "Bilgi");
                btnDuzenle.Visible = false;
                btnYeniEkle.Visible = true;
                txtAracTipAdi.Text = "";
                txtAracTipFiyati.Text = "0,00";
                aracTip = new EntityLayer.Arac.AracTip();
            }
            else
                bildirim.Hata("Güncellerken bir hata oluştu.", "Uyarı");
            Listele();

        }
        void Listele()
        {
            gridControl1.DataSource = null;
            aracTipList = new List<EntityLayer.Arac.AracTip>();
            aracTipList = BsaracTip.AracTipGetir();
            gridControl1.DataSource = aracTipList;
        }

        private void AracTipleriForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void duzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aracTip = new EntityLayer.Arac.AracTip();
            aracTip.Id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));
            aracTip.Fiyat = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("Fiyat"));
            aracTip.Adi = Convert.ToString(gridView1.GetFocusedRowCellValue("Adi"));
            txtAracTipAdi.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("Adi"));
            txtAracTipFiyati.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("Fiyat"));
            btnDuzenle.Visible = true;
            btnYeniEkle.Visible = false;
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bildirim.Soru("Silmek istiyor musunuz?", "Soru"))
            {
                int Id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));
                if (BsaracTip.AracTipSil(Id))
                    bildirim.Bilgi("Başarıyla silindi", "Bilgi");
                else
                    bildirim.Hata("Silerken bir hata oluştu", "Hata");
            }
            Listele();
        }
    }
}