using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Satis
    {
        public int Id { get; set; }
        public int AracTipNo { get; set; }
        public string Plaka { get; set; }
        public string AracTipAdi { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Telefon { get; set; }
        public int AboneNo { get; set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public bool Kontak { get; set; }
        public decimal Ucret { get; set; }
        public int KullaniciId { get; set; }
    }
}
