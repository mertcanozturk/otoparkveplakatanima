using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Otopark
    {
        public string OtoparkAdi { get; set; }
        public int AracKapasitesi { get; set; }

        public class Arac
        {
            public int Id { get; set; }
            public string Plaka { get; set; }
            public string AracTipAdi { get; set; }
            public int AracTipNo { get; set; }
            public int AboneNo { get; set; }
            public bool AboneMi { get; set; }
            public DateTime GirisTarihi { get; set; }
            public bool Kontak { get; set; }
        }
    }
}
