
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Kullanici
    {
        private dbConnection baglanti;

        public Kullanici()
        {
            baglanti = new dbConnection();
        }

        public bool GirisYapildiMi(string _KullaniciAdi, string _Parola)
        {
            string sorgu = string.Format("SELECT * FROM TBLKULLANICI where KULLANICIADI=@KULLANICIADI AND PAROLA=@PAROLA");
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@KULLANICIADI", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(_KullaniciAdi);
            sqlParameters[1] = new SqlParameter("@PAROLA", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(_Parola);
            DataTable dt = baglanti.executeSelectQuery(sorgu, sqlParameters);
            if (dt.Rows.Count > 0) return true;
            else return false;

        }
    }
}