using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DataAccessLayer;
namespace BusinessLayer
{
    /// <summary>
    /// kullaniciBUS için özet açıklama
    /// </summary>
    public class Kullanici
    {

        private DataAccessLayer.Kullanici _kullanici;
        
        /// <constructor>
        /// kullaniciBUS yapılandırıcı
        /// </constructor>
        public Kullanici()
        {
            _kullanici = new DataAccessLayer.Kullanici();
        }

        /// <method>
        /// KullaniciAdi ve kullaniciSoyadi ile Kullanici e-mail'inin alınması ve return VO
        /// </method>
        public bool Getir(string kAdi,string kParola)
        {
            bool durum = _kullanici.GirisYapildiMi(kAdi, kParola);
            return durum;

        }

   
    }
}