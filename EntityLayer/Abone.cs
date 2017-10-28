using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Abone
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Plaka { get; set; }
        public string AracTipAdi { get; set; }
        public int AracTipId { get; set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public int AbonelikTipiNo { get; set; }
        public string AbonelikAdi { get; set; }
        public decimal Fiyat { get; set; }
        public int KullaniciId { get; set; }

    }
    public class AboneTip
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public int Sure { get; set; }
        public decimal Ucret { get; set; }

    }
}
