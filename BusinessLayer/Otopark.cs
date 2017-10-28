using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Otopark
    {
        
        private DataAccessLayer.dbConnection baglanti;
        public Otopark()
        {
            baglanti = new DataAccessLayer.dbConnection();
        }
        DataAccessLayer.Otopark otopark = new DataAccessLayer.Otopark();
        EntityLayer.Otopark.Arac arac = new EntityLayer.Otopark.Arac();

        public bool aracKaydet(EntityLayer.Otopark.Arac arac)
        {
            DataTable dt = new DataTable();
            try
            {
                if (otopark.Kaydet(arac))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool aracSil(string Plaka)
        {
            try
            {
                if (otopark.aracSil(Plaka))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {

                return false;
            }
        }
    
        public bool aracOtoparktaMi(string plaka)
        {
            try
            {
                if (otopark.aracOtoparktaMi(plaka))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable Listele(string Plaka, bool Kontak, string AracTipAdi)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = otopark.AracListele(Plaka, Kontak, AracTipAdi);
            }
            catch (Exception)
            {
                throw;
            }

            return dt;
        }
        public List<EntityLayer.Otopark.Arac> belliSayidaAracListele(int aracSayisi)
        {
            List<EntityLayer.Otopark.Arac> aracList = new List<EntityLayer.Otopark.Arac>();
            EntityLayer.Otopark.Arac arac = new EntityLayer.Otopark.Arac();
            try
            {
                DataTable dt = otopark.belliSayidaAracListele(aracSayisi);
                foreach (DataRow dr in dt.Rows)
                {
                    arac = new EntityLayer.Otopark.Arac();
                    arac.Plaka = dr["PLAKA"].ToString();
                    arac.GirisTarihi = Convert.ToDateTime(dr["GIRISTARIHI"]);
                    arac.Kontak = Convert.ToBoolean(dr["KONTAK"]);
                    arac.AboneMi = Convert.ToBoolean(dr["ABONEMI"]);
                    arac.AracTipAdi = dr["ARACTIPADI"].ToString();
                    aracList.Add(arac);
                }
            }
            catch (Exception)
            {

            }
            return aracList;
        }

        public int anlikOtomobilSayisi()
        {
            return otopark.OtomobilSayisi();
        }
        public int anlikTirSayisi()
        {
            return otopark.TirSayisi();
        }
        public int anlikOtobusSayisi()
        {
            return otopark.OtobusSayisi();

        }
        public int anlikMinibusSayisi()
        {
            return otopark.MinibusSayisi();
        }
        public int anlikKamyonSayisi()
        {
            return otopark.KamyonSayisi();
        }

        public DataRow AracGetir(string plaka)
        {
            DataRow row;
            try
            {
                row = otopark.AracGetir(plaka);
            }
            catch (Exception e)
            {
                throw;
            }

            return row;
        }

        public DataTable Listele()
        {

            arac = new EntityLayer.Otopark.Arac();
            DataTable dt = otopark.AracListele();
            try
            {
            }
            catch (Exception)
            {
                throw;
            }

            return dt;
        }


    }
}
