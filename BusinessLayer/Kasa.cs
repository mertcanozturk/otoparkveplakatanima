using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Kasa
    {
        DataAccessLayer.Kasa kasa = new DataAccessLayer.Kasa();
        public bool ParaEkle(decimal miktar)
        {
            if (kasa.ParaEkle(miktar))
                return true;
            else
                return false;
        }
    }
}
