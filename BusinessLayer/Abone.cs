using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Abone
    {
        DataAccessLayer.Abone aboneControl = new DataAccessLayer.Abone();
        public List<EntityLayer.Abone> Listele()
        {
            List<EntityLayer.Abone> aboneList = new List<EntityLayer.Abone>();
            EntityLayer.Abone abone = new EntityLayer.Abone();
            DataTable dt = aboneControl.Listele();
            foreach (DataRow dr in dt.Rows)
            {
                abone.Adi = dr["ADI"].ToString();
                abone.Soyadi = dr["SOYADI"].ToString();
                abone.Adres = dr["ADRES"].ToString();
                abone.Telefon = dr["TELEFON"].ToString();
                abone.Plaka = dr["PLAKA"].ToString();
                abone.AracTipAdi = dr["ARACTIPADI"].ToString();
                abone.GirisTarihi = Convert.ToDateTime(dr["GIRISTARIH"]);
                abone.AbonelikAdi = dr["ABONELIKADI"].ToString();
                abone.BitisTarihi = Convert.ToDateTime(dr["BITISTARIHI"]);
                abone.Fiyat = Convert.ToDecimal(dr["FIYAT"]);
                abone.Id = Convert.ToInt32(dr["ID"]);
                aboneList.Add(abone);
            }
            return aboneList;
        }
        public List<EntityLayer.Abone> Listele(string Plaka,string Adi,string Soyadi,string aracTipi,string Telefon)
        {
            List<EntityLayer.Abone> aboneList = new List<EntityLayer.Abone>();
            EntityLayer.Abone abone = new EntityLayer.Abone();
            DataTable dt = aboneControl.Listele(Plaka,Adi,Soyadi,aracTipi,Telefon);
            foreach (DataRow dr in dt.Rows)
            {
                abone = new EntityLayer.Abone();
                abone.Adi = dr["ADI"].ToString();
                abone.Soyadi = dr["SOYADI"].ToString();
                abone.Adres = dr["ADRES"].ToString();
                abone.Telefon = dr["TELEFON"].ToString();
                abone.Plaka = dr["PLAKA"].ToString();
                abone.AracTipAdi = dr["ARACTIPADI"].ToString();
                abone.GirisTarihi = Convert.ToDateTime(dr["GIRISTARIH"]);
                abone.AbonelikAdi = dr["ABONELIKADI"].ToString();
                abone.BitisTarihi = Convert.ToDateTime(dr["BITISTARIHI"]);
                abone.Fiyat = Convert.ToDecimal(dr["FIYAT"]);
                abone.Id = Convert.ToInt32(dr["ID"]);
                aboneList.Add(abone);
            }
            return aboneList;
        }
    }
}
