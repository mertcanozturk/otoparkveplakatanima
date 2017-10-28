using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Otopark
    {
        dbConnection baglanti;
        public Otopark()
        {
            baglanti = new dbConnection();
        }

       
        public bool aracOtoparktaMi(string Plaka)
        {
            string query = "SELECT * FROM TBLARACLAR WHERE PLAKA=@PLAKA";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@PLAKA", SqlDbType.VarChar);
            sqlParameters[0].Value = Plaka;
            DataTable dt = baglanti.executeSelectQuery(query, sqlParameters);
            if (dt.Rows.Count > 0)
                return true;
            return false;
          
        }
        public bool aracSil(string Plaka)
        {
            string query = "DELETE FROM TBLARACLAR WHERE PLAKA=@PLAKA";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@PLAKA", SqlDbType.VarChar);
            sqlParameters[0].Value = Plaka;
            bool durum = baglanti.executeInsertQuery(query, sqlParameters);
            if (durum)
                return true;
            return false;
        }
        public DataTable AracListele(string Plaka, bool Kontak, string AracTipAdi)
        {
            string query = "SELECT * FROM VARACLAR WHERE PLAKA LIKE '%' + @PLAKA + '%' AND ARACTIPADI LIKE '%' + @ARACTIPADI + '%' AND KONTAK=@KONTAK  ";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@PLAKA", SqlDbType.VarChar);
            sqlParameters[0].Value = Plaka;
            sqlParameters[1] = new SqlParameter("@KONTAK", SqlDbType.Bit);
            sqlParameters[1].Value = Kontak?1:0;
            sqlParameters[2] = new SqlParameter("@ARACTIPADI", SqlDbType.VarChar);
            sqlParameters[2].Value = AracTipAdi;
            DataTable dt = baglanti.executeSelectQuery(query, sqlParameters);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }
        public DataTable belliSayidaAracListele(int AracSayisi)
        {
            string query = "SELECT TOP 20 * FROM VARACLAR";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            
            DataTable dt = baglanti.executeSelectQuery(query, null);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }

        public int OtomobilSayisi()
        {
            string query = "SELECT * FROM VARACLAR WHERE ARACTIPADI='Otomobil'";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            DataTable dt = baglanti.executeSelectQuery(query, null);
            if (dt.Rows.Count > 0)
                return dt.Rows.Count;
            return 0;

        }
        public int MinibusSayisi()
        {
            string query = "SELECT * FROM VARACLAR WHERE ARACTIPADI='Minibüs'";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            DataTable dt = baglanti.executeSelectQuery(query, null);
            if (dt.Rows.Count > 0)
                return dt.Rows.Count;
            return 0;

        }
        public int KamyonSayisi()
        {
            string query = "SELECT * FROM VARACLAR WHERE ARACTIPADI='Kamyon'";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            DataTable dt = baglanti.executeSelectQuery(query, null);
            if (dt.Rows.Count > 0)
                return dt.Rows.Count;
            return 0;

        }
        public int TirSayisi()
        {
            string query = "SELECT * FROM VARACLAR WHERE ARACTIPADI='Tır'";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            DataTable dt = baglanti.executeSelectQuery(query, null);
            if (dt.Rows.Count > 0)
                return dt.Rows.Count;
            return 0;

        }
        public int OtobusSayisi()
        {
            string query = "SELECT * FROM VARACLAR WHERE ARACTIPADI='Otobüs'";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            DataTable dt = baglanti.executeSelectQuery(query, null);
            if (dt.Rows.Count > 0)
                return dt.Rows.Count;
            return 0;

        }
        public DataRow AracGetir(string Plaka)
        {
            string query = "SELECT * FROM TBLARACLAR WHERE PLAKA=@PLAKA";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@PLAKA", SqlDbType.VarChar);
            sqlParameters[0].Value = Plaka;

            DataTable dt = baglanti.executeSelectQuery(query, sqlParameters);
            DataRow row = dt.Rows[0];
            if (dt.Rows.Count > 0)
                return row;
            return null;
        }
        public DataTable AracListele()
        {
            DataTable dt = baglanti.Listele();
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }

        public bool Kaydet(EntityLayer.Otopark.Arac arac)
        {
            string query = "INSERT INTO TBLARACLAR (PLAKA,ARACTIPNO,ABONENO,GIRISTARIHI,KONTAK,ABONEMI) VALUES (@PLAKA,@ARACTIPNO,@ABONENO,@GIRISTARIHI,@KONTAK,@ABONEMI)";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@PLAKA", SqlDbType.VarChar);
            sqlParameters[0].Value = arac.Plaka;
            sqlParameters[1] = new SqlParameter("@ARACTIPNO", SqlDbType.VarChar);
            sqlParameters[1].Value = arac.AracTipNo;
            sqlParameters[2] = new SqlParameter("@ABONENO", SqlDbType.VarChar);
            sqlParameters[2].Value = arac.AboneNo;
            sqlParameters[3] = new SqlParameter("@GIRISTARIHI", SqlDbType.VarChar);
            sqlParameters[3].Value = arac.GirisTarihi;
            sqlParameters[4] = new SqlParameter("@KONTAK", SqlDbType.VarChar);
            sqlParameters[4].Value = arac.Kontak;
            sqlParameters[5] = new SqlParameter("@ABONEMI", SqlDbType.VarChar);
            sqlParameters[5].Value = arac.AboneMi;
            return baglanti.executeInsertQuery(query, sqlParameters);

        }


        public bool AracOtoparktaMi(string Plaka)
        {
            string sorgu = string.Format("SELECT * FROM TBLARACLAR where PLAKA=@PLAKA");
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@PLAKA", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(Plaka);
            DataTable dt = baglanti.executeSelectQuery(sorgu, sqlParameters);
            if (dt.Rows.Count > 0)
                return true;
            return false;

        }

    }
}
