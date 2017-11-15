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
            return kasa.ParaEkle(miktar);

        }
        public bool ParaCikar(decimal miktar)
        {
            return kasa.ParaCikar(miktar);
        }
        public bool SonKayitSil()
        {
            return kasa.SonKayitSil();
        }
        public List<EntityLayer.KasaIslemi> SonKasaIslemListele(string tipi)
        {
            return kasa.SonKasaGirisleriGetir(tipi);
        }
        public bool IslemEkle(EntityLayer.KasaIslemi islem)  //durum true ise kasagiris   
        {
            return kasa.IslemEkle(islem);
        }
        public decimal ParaGoster()
        {
            return kasa.ParaGoster();
        }
    }
}
