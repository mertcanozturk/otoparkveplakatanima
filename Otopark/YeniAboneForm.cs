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
        List<EntityLayer.Arac.AracTip> aracTips = new List<EntityLayer.Arac.AracTip>();
        BusinessLayer.Arac BsArac = new BusinessLayer.Arac();
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
        }
    }
}