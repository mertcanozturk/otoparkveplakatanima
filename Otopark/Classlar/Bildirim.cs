using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Otopark.Classlar
{
    public class Bildirim
    {
        //Mybildirm
        public void Uyari(string mesaj,string baslik)
        {
            MessageBox.Show(mesaj, baslik, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void Hata(string mesaj,string baslik)
        {
            MessageBox.Show(mesaj, baslik, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public bool Soru(string mesaj,string baslik)
        {
           DialogResult dr= MessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                return true;
            else if (dr == DialogResult.No)
                return false;
            else
                return false;
        }

        public void Bilgi(string mesaj,string baslik)
        {
            MessageBox.Show(mesaj, baslik, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
