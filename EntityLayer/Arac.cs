using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Arac
    {
        public string Plaka { get; set; }
        public string AracTipAdi { get; set; }
        public decimal Fiyat { get; set; }
        public DateTime GirisTarihi { get; set; }
        public bool Kontak { get; set; }
        public DateTime CikisTarihi { get; set; }
        public bool AboneMi { get; set; }


        public class AboneTip
        {
            public int Id { get; set; }
            public string Adi { get; set; }
            public int Sure { get; set; }
            public decimal Ucret { get; set; }

        }

        public class AboneBilgileri
        {
            public int Id { get; set; }
            public string Adi { get; set; }
            public string Soyadi { get; set; }
            public string Adres { get; set; }
            public string Telefon { get; set; }
            public string Plaka { get; set; }
            public string AracTipAdi { get; set; }
            public decimal Fiyat { get; set; }
            public DateTime BaslangicTarihi { get; set; }
            public AboneTip aboneTip { get; set; }
            public DateTime BitisTarihi { get; set; }
            public string AbonelikAdi { get; set; }

        }

        public class AracTip
        {
            public int Id { get; set; }
            public string Adi { get; set; }
            public decimal Fiyat { get; set; }

        }

        AboneBilgileri abone = new AboneBilgileri();

        public string okuZaman(TimeSpan span)
        {
            string formatted = string.Format("{0}{1}{2}",
        span.Duration().Days > 0 ? string.Format("{0:0} Gün{1}, ", span.Days, span.Days == 1 ? String.Empty : "") : string.Empty,
        span.Duration().Hours > 0 ? string.Format("{0:0} Saat{1}, ", span.Hours, span.Hours == 1 ? String.Empty : "") : string.Empty,
        span.Duration().Minutes > 0 ? string.Format("{0:0} Dakika{1} ", span.Minutes, span.Minutes == 1 ? String.Empty : "") : string.Empty);
            // span.Duration().Seconds > 0 ? string.Format("{0:0} second{1}", span.Seconds, span.Seconds == 1 ? String.Empty : "") : string.Empty);

            if (formatted.EndsWith(", ")) formatted = formatted.Substring(0, formatted.Length - 2);

            if (string.IsNullOrEmpty(formatted)) formatted = "0 seconds";

            return formatted;
        }

    }
}
