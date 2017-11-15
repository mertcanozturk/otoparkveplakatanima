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
    public partial class KasaDurumuForm : DevExpress.XtraEditors.XtraForm
    {
        BusinessLayer.Kasa BsKasa = new BusinessLayer.Kasa();
        decimal Para = 0;
        public KasaDurumuForm()
        {
            InitializeComponent();
        }
        void Yenile()
        {
            Para = BsKasa.ParaGoster();
            lblPara.Text = Para.ToString() + " ₺";
            gridGirisler.DataSource = null;
            gridCikislar.DataSource = null;
            gridGirisler.DataSource = BsKasa.SonKasaIslemListele("Kasa Giriş");
            gridCikislar.DataSource = BsKasa.SonKasaIslemListele("Kasa Çıkış");
        }
        private void KasaDurumuForm_Load(object sender, EventArgs e)
        {
            Yenile();
        }
    }
}