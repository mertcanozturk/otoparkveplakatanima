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
        BusinessLayer.Arac BsArac = new BusinessLayer.Arac();
        List<EntityLayer.Arac.AracTip> aracTips = new List<EntityLayer.Arac.AracTip>();
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
            comboAracTipi.SelectedIndex = 0;
        }

        private void btnAramaYap_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = null;
           gridControl1.DataSource = Bsotopark.Listele(txtPlaka.Text, checkKontak.Checked, comboAracTipi.Text);

        }

        private void menuSonlandir_Click(object sender, EventArgs e)
        {
            foreach (int i in gridView1.GetSelectedRows())
            {
                //row[0]= PLAKA
                DataRow row = gridView1.GetDataRow(i);
                if (Bsotopark.aracSil(row[0].ToString()))
                    MessageBox.Show("Basarili");

            }
        }
    }
}