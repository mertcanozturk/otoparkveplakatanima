using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{

    public class Arac
    {
        private DataAccessLayer.Arac _arac;
        public Arac()
        {
            _arac = new DataAccessLayer.Arac();
        }
        public bool AboneMi(string plaka)
        {
            try
            {
                if (_arac.AboneMi(plaka))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public EntityLayer.Arac.AboneBilgileri AboneGetir(string Plaka)
        {
            EntityLayer.Arac.AboneBilgileri abone = new EntityLayer.Arac.AboneBilgileri();

            try
            {
                DataTable dt = _arac.AboneGetir(Plaka);
                foreach (DataRow dr in dt.Rows)
                {
                    abone.Id = Convert.ToInt32(dr["ID"].ToString());
                    abone.Adi = dr["ADI"].ToString();
                    abone.Plaka = dr["PLAKA"].ToString();
                    abone.Telefon = dr["TELEFON"].ToString();
                    abone.Soyadi = dr["SOYADI"].ToString();
                    abone.BaslangicTarihi = Convert.ToDateTime(dr["GIRISTARIH"].ToString());
                    abone.BitisTarihi = Convert.ToDateTime(dr["BITISTARIHI"].ToString());
                    abone.AracTipAdi = dr["ARACTIPADI"].ToString();
                    abone.Fiyat = Convert.ToDecimal(dr["FIYAT"].ToString());
                    abone.AbonelikAdi = dr["ABONELIKADI"].ToString();

                }
            }
            catch (Exception)
            {
                throw;
            }

            return abone;

        }
        public List<EntityLayer.Arac.AracTip> AracTipGetir()
        {
            List<EntityLayer.Arac.AracTip> aracTips = new List<EntityLayer.Arac.AracTip>();
            EntityLayer.Arac.AracTip aracTip = new EntityLayer.Arac.AracTip();
            try
            {
                DataTable dt = _arac.AracTipGetir();
                foreach (DataRow dr in dt.Rows)
                {
                    aracTip = new EntityLayer.Arac.AracTip();
                    aracTip.Id = Convert.ToInt32(dr["ID"].ToString());
                    aracTip.Adi = dr["ARACTIPADI"].ToString();
                    aracTip.Fiyat = Convert.ToDecimal(dr["FIYAT"].ToString());
                    aracTips.Add(aracTip);

                }
            }
            catch (Exception)
            {

            }
            return aracTips;
        }
        public bool AracTipEkle(EntityLayer.Arac.AracTip aracTip)
        {
            try
            {
                _arac.AracTipEkle(aracTip);
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
        public bool AracTipGuncelle(EntityLayer.Arac.AracTip aracTip)
        {
            try
            {
                _arac.AracTipGuncelle(aracTip);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool AracTipSil(int Id)
        {
            try
            {
                _arac.AracTipSil(Id);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public int AracTipIdGetir(string AracTipAdi)
        {
            try
            {
                return _arac.AracTipIdGetir(AracTipAdi);

            }
            catch (Exception)
            {
                return -1;
            }
        }

    }
}
