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
    public partial class AboneListesiForm : DevExpress.XtraEditors.XtraForm
    {
        BusinessLayer.Abone aboneControl = new BusinessLayer.Abone();
        List<EntityLayer.Abone> aboneList = new List<EntityLayer.Abone>();
        public AboneListesiForm()
        {
            InitializeComponent();
        }

        private void AboneListesiForm_Load(object sender, EventArgs e)
        {

        }

        void Listele()
        {
            gridControl1.DataSource = null;
            aboneList = null;
            aboneList = aboneControl.Listele(txtPlaka.Text,txtAdi.Text,txtSoyadi.Text,comboAracTipi.Text,txtTelefon.Text);
            var source = new BindingSource();
            source.DataSource = aboneList;
            gridControl1.DataSource = source;
        }
        private void btnAramaYap_Click(object sender, EventArgs e)
        {
           
            Listele();
        }
    }
}