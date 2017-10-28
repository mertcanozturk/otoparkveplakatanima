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
        BusinessLayer.Otopark Bsotopark = new BusinessLayer.Otopark();
        private void GenelForm_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = Bsotopark.Listele("",true,"");

        }
    }
}