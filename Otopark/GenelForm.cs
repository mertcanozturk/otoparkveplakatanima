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
    public partial class GenelForm : DevExpress.XtraEditors.XtraForm
    {
        public GenelForm()
        {
            InitializeComponent();
        }
        List<EntityLayer.Otopark.Arac> aracList = new List<EntityLayer.Otopark.Arac>();
        EntityLayer.Otopark.Arac arac = new EntityLayer.Otopark.Arac();
        BusinessLayer.Otopark Bsotopark = new BusinessLayer.Otopark();

        void Listele()
        {
            aracList = new List<EntityLayer.Otopark.Arac>();
            arac = new EntityLayer.Otopark.Arac();
            aracList = Bsotopark.belliSayidaAracListele(14);
            var source = new BindingSource();
            source.DataSource = aracList;
            gridControl1.DataSource = source;
            lblAnlikKamyonSayisi.Text = Bsotopark.anlikKamyonSayisi().ToString();
            lblAnlikMinibusSayisi.Text = Bsotopark.anlikMinibusSayisi().ToString();
            lblAnlikOtobüsSayisi.Text = Bsotopark.anlikOtobusSayisi().ToString();
            lblAnlikOtomobilSayisi.Text = Bsotopark.anlikOtomobilSayisi().ToString();
            lblAnlikTirSayisi.Text = Bsotopark.anlikTirSayisi().ToString();
            lblGunlukKamyonSayisi.Text = Bsotopark.GunlukCikanKamyonSayisi().ToString();
            lblGunlukOtobusSayisi.Text= Bsotopark.GunlukCikanOtobusSayisi().ToString();
            lblGunlukOtomobilSayisi.Text= Bsotopark.GunlukCikanOtomobilSayisi().ToString();
            lblGunlukTirSayisi.Text= Bsotopark.GunlukCikanTirSayisi().ToString();
            lblMinibusSayisi.Text= Bsotopark.GunlukCikanMinibusSayisi().ToString();
        }
        private void GenelForm_Load(object sender, EventArgs e)
        {
            Listele();

        }

        private void btnPlakaArama_Click(object sender, EventArgs e)
        {
            AraclarForm frm = new AraclarForm(txtAracPlaka.Text);
            frm.MdiParent = AnaForm.ActiveForm;
            frm.Show();
        }

        private void btnAboneArama_Click(object sender, EventArgs e)
        {

        }

        private void btnAracSayiDetay_Click(object sender, EventArgs e)
        {

        }



        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}