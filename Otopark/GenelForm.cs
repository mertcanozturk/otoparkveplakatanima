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
            aracList = Bsotopark.belliSayidaAracListele(20);
            var source = new BindingSource();
            source.DataSource = aracList;
            gridControl1.DataSource = source;
        }
        private void GenelForm_Load(object sender, EventArgs e)
        {
            Listele();

        }
    }
}