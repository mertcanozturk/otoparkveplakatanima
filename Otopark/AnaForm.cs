using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Otopark
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Classlar.Bildirim bildirim = new Classlar.Bildirim();
        public AnaForm()
        {
            InitializeComponent();
        }
        public bool aracDurumu = true;
        public Timer timer4 = new Timer();

        private void AnaForm_Load(object sender, EventArgs e)
        {
            serialPort1.Open();
            GenelForm frm = new GenelForm();
            frm.MdiParent = this;
            frm.Show();
            timer1.Interval = 1000;
            timer1.Start();
            timer2.Start();
            timer3.Start();
            barTarih.Caption = "Tarih: " + DateTime.Now;
        }
        ~AnaForm()
        {
            serialPort1.Close();
        }

        private void btnAracGiris_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["AracGirisForm"] == null)
            {
                AracGirisForm frm = new AracGirisForm();
                frm.MdiParent = this;
                frm.Show();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            barTarih.Caption = "Tarih: " + DateTime.Now;
          

        }

        private void btnSatislar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        private void btnAraclar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["AraclarForm"] == null)
            {
                AraclarForm frm = new AraclarForm();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnYeniAbone_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            YeniAboneForm frm = new YeniAboneForm();
            frm.ShowDialog();
        }

        private void btnAboneListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["AboneListesiForm"] == null)
            {
                AboneListesiForm frm = new AboneListesiForm();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!bildirim.Soru("Çıkmak istiyor musunuz?", "Soru"))
            {
                e.Cancel = true;
            }
        }

        private void btnOtopark_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["GenelForm"] == null)
            {
                GenelForm frm = new GenelForm();
                frm.MdiParent = this;
                frm.Show();
            }
        }
        int oncekiMesafe = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                int aracMesafesi = int.Parse(serialPort1.ReadLine());
                Console.WriteLine(aracMesafesi);
              
                if (aracMesafesi < 30 && aracMesafesi!=0 && oncekiMesafe >= 30)
                {   
                    timer2.Stop();
                    if (Application.OpenForms["AracGirisForm"] == null)
                    {
                        AracGirisForm f = new AracGirisForm();
                        f.MdiParent = this;
                        f.Show();
                        
                    }
                }
                oncekiMesafe = aracMesafesi;
            }
            catch (Exception)
            {
            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (Application.OpenForms["AracGirisForm"] == null)
            {
                timer2.Start();
            }
        }
    }
}
