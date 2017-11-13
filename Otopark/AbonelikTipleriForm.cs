using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark
{
    public partial class AbonelikTipleriForm : Form
    {
        EntityLayer.AboneTip aboneTip = new EntityLayer.AboneTip();
        List<EntityLayer.AboneTip> aboneList = new List<EntityLayer.AboneTip>();
        BusinessLayer.Abone BsAbone = new BusinessLayer.Abone();
        Classlar.Bildirim bildirim = new Classlar.Bildirim();
        public AbonelikTipleriForm()
        {
            InitializeComponent();
        }
        void Listele()
        {
            gridControl1.DataSource = null;
            aboneList = new List<EntityLayer.AboneTip>();
            aboneList = BsAbone.AboneTipListesiGetir();
            gridControl1.DataSource = aboneList;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            aboneTip = new EntityLayer.AboneTip();
            string s = txtFiyat.Text; // . yerine , gelmesi gerekir.
            s = s.Replace('.', ',');
            aboneTip.Adi = txtAbonelikAdi.Text;
            aboneTip.Sure = int.Parse(txtSure.Text);
            aboneTip.Ucret = Convert.ToDecimal(s);
            if (!BsAbone.AboneTipKaydet(aboneTip))
                bildirim.Hata("Kaydederken bir hata oluştu", "Hata");
            Boşalt();
            Listele();
            
        }
        private void AbonelikTipleriForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Boşalt()
        {
            aboneTip = new EntityLayer.AboneTip();
            aboneList = new List<EntityLayer.AboneTip>();
            txtAbonelikAdi.Text = "";
            txtFiyat.Text = "";
            txtSure.Text = "";
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Boşalt();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            
            string s = txtFiyat.Text; // . yerine , gelmesi gerekir.
            s = s.Replace('.', ',');
            aboneTip.Adi = txtAbonelikAdi.Text;
            aboneTip.Sure = int.Parse(txtSure.Text);
            aboneTip.Ucret = Convert.ToDecimal(s);
            if (!BsAbone.AboneTipGuncelle(aboneTip))
                bildirim.Hata("Kaydederken bir hata oluştu", "Hata");
            Listele();
            Boşalt();
            btnYeniEkle.Visible = true;
            btnGuncelle.Visible = false;
        }

        private void duzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boşalt();
            aboneTip.Id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));
            aboneTip.Adi = Convert.ToString(gridView1.GetFocusedRowCellValue("Adi"));
            aboneTip.Sure = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Sure"));
            aboneTip.Ucret = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("Ucret"));
            txtAbonelikAdi.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("Adi"));
            txtFiyat.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("Ucret"));
            txtSure.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("Sure"));
            btnGuncelle.Visible = true;
            btnYeniEkle.Visible = false;
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));
            if (bildirim.Soru("Silmek istiyor musunuz?", "Soru"))
                if (BsAbone.AboneTipSil(Id))
                    bildirim.Bilgi("Başarıyla silindi.", "Bilgi");
                else
                    bildirim.Hata("Silerken bir hata oluştu.", "Hata");

            Listele();
        }
    }
}
