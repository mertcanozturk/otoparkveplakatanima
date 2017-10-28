using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Abone
    {

        private dbConnection baglanti;

        public Abone()
        {
            baglanti = new dbConnection();
        }

        public bool AboneEkle(EntityLayer.Abone abone, EntityLayer.AboneTip aboneTip)
        {
            string query = "INSERT INTO TBLABONE (ADI,SOYADI,ADRES,TELEFON,PLAKA,ARACTIPNO,GIRISTARIH,BITISTARIHI,ABONELIKTIPINO,KULLANICIID) VALUES(@ADI,@SOYADI,@ADRES,@TELEFON,@PLAKA,@ARACTIPNO,@GIRISTARIH,@BITISTARIHI,@ABONELIKTIPINO,@BITISTARIHI,@KULLANICIID)";
            SqlParameter[] parameter = new SqlParameter[10];
            parameter[0] = new SqlParameter("@ADI", SqlDbType.VarChar);
            parameter[0].Value = abone.Adi;
            parameter[1] = new SqlParameter("@SOYADI", SqlDbType.VarChar);
            parameter[1].Value = abone.Soyadi;
            parameter[2] = new SqlParameter("@ADRES", SqlDbType.VarChar);
            parameter[2].Value = abone.Adres;
            parameter[3] = new SqlParameter("@TELEFON", SqlDbType.VarChar);
            parameter[3].Value = abone.Telefon;
            parameter[4] = new SqlParameter("@PLAKA", SqlDbType.VarChar);
            parameter[4].Value = abone.Plaka;
            parameter[5] = new SqlParameter("@ARACTIPNO", SqlDbType.VarChar);
            parameter[5].Value = abone.AracTipId;
            parameter[6] = new SqlParameter("@GIRISTARIH", SqlDbType.VarChar);
            parameter[6].Value = abone.GirisTarihi;
            parameter[7] = new SqlParameter("@BITISTARIHI", SqlDbType.VarChar);
            parameter[7].Value = abone.BitisTarihi;
            parameter[8] = new SqlParameter("@ABONELIKTIPINO", SqlDbType.VarChar);
            parameter[8].Value = abone.AbonelikTipiNo;
            parameter[9] = new SqlParameter("@KULLANICIID", SqlDbType.VarChar);
            parameter[9].Value = abone.KullaniciId;
            baglanti.executeInsertQuery(query, parameter);
            return true;
        }

        public DataTable Listele()
        {
            string sorgu = string.Format("SELECT * FROM VABONE");
            SqlParameter[] sqlParameters = new SqlParameter[1];
            DataTable dt = baglanti.executeSelectQuery(sorgu, null);
            if (dt.Rows.Count > 0)
                return dt;
            return dt;
        }
        public DataTable Listele(string Plaka, string Adi, string Soyadi, string aracTipi, string Telefon)
        {
            string sorgu = string.Format("SELECT * FROM VABONE WHERE ADI LIKE '%' + @ADI + '%' AND SOYADI LIKE '%' + @SOYADI + '%' AND PLAKA LIKE '%' + @PLAKA + '%' AND ARACTIPADI LIKE '%' + @ARACTIPADI + '%' AND TELEFON LIKE '%' + @TELEFON + '%'");
            SqlParameter[] parameter = new SqlParameter[5];
            parameter[0] = new SqlParameter("@ADI", SqlDbType.VarChar);
            parameter[0].Value = Adi;
            parameter[1] = new SqlParameter("@SOYADI", SqlDbType.VarChar);
            parameter[1].Value = Soyadi;
            parameter[2] = new SqlParameter("@ARACTIPADI", SqlDbType.VarChar);
            parameter[2].Value = aracTipi;
            parameter[3] = new SqlParameter("@TELEFON", SqlDbType.VarChar);
            parameter[3].Value = Telefon;
            parameter[4] = new SqlParameter("@PLAKA", SqlDbType.VarChar);
            parameter[4].Value = Plaka;
            DataTable dt = baglanti.executeSelectQuery(sorgu, parameter);
            if (dt.Rows.Count > 0)
                return dt;
            return dt;
        }
    }
}
