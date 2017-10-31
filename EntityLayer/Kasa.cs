using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Kasa
    {
        public int Id { get; set; }
        public string KasaAdi { get; set; }
        public string ParaBirimi { get; set; }
        public DateTime SonIslemTarihi { get; set; }
    }
    public class KasaIslemi
    {
        public int Id { get; set; }
        public string IslemTipi { get; set; }
        public decimal Ucret { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }

    }
}
