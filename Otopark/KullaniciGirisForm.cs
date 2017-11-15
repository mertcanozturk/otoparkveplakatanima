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
using BusinessLayer;
namespace Otopark
{

    public partial class KullaniciGirisForm : DevExpress.XtraEditors.XtraForm
    {
        public KullaniciGirisForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            BusinessLayer.Kullanici BsKullanici = new Kullanici();
            if (BsKullanici.Getir(txtKullaniciAdi.Text, txtParola.Text))
            {

                this.Hide();

                AnaForm frm = new AnaForm();
                frm.Show();
            }
            else lblHata.Visible = true;
        }

        private void KullaniciGirisForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}