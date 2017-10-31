using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataAccessLayer
{
    public class Arac
    {
        private dbConnection baglanti;

        public Arac()
        {
            baglanti = new dbConnection();
        }

        public bool AboneMi(string plaka)
        {
            string sorgu = string.Format("SELECT * FROM TBLABONE where PLAKA=@PLAKA");
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@PLAKA", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(plaka);
            DataTable dt = baglanti.executeSelectQuery(sorgu, sqlParameters);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        public DataTable AboneGetir(string plaka)
        {
            string sorgu = string.Format("SELECT * FROM VABONE where PLAKA=@PLAKA");
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@PLAKA", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(plaka);
            DataTable dt = baglanti.executeSelectQuery(sorgu, sqlParameters);
            if (dt.Rows.Count > 0)
                return dt;
            return dt;
        }
        public bool AracEkle(EntityLayer.Arac.AboneBilgileri abone,EntityLayer.Arac.AboneTip aboneTip,EntityLayer.Arac.AracTip aracTip,EntityLayer.Arac arac)
        {
            string query = "INSERT INTO TBLARACLAR (PLAKA,ARACTIPNO,ABONENO,GIRISTARIHI,KONTAK) VALUES (@PLAKA,@ARACTIPNO,@ABONENO,@GIRISTARIHI,@KONTAK)";
            SqlParameter[] parameter = new SqlParameter[5];
            parameter[0] = new SqlParameter("@PLAKA", SqlDbType.VarChar);
            parameter[0].Value = 

            baglanti.executeInsertQuery(query, parameter);

            return true;
        }
        public DataTable AracTipGetir(int Id)
        {
            string sorgu = string.Format("SELECT * FROM TBLARACTIP where ID=@ID");
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ID", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(Id);
            DataTable dt = baglanti.executeSelectQuery(sorgu, sqlParameters);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }
        public int AracTipIdGetir(string AracTipAdi)
        {
            string sorgu = string.Format("SELECT * FROM TBLARACTIP WHERE ARACTIPADI=@ARACTIPADI");
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ARACTIPADI", SqlDbType.VarChar);
            sqlParameters[0].Value = AracTipAdi;
            DataTable dt = baglanti.executeSelectQuery(sorgu, sqlParameters);
            if (dt.Rows.Count > 0)
                return Convert.ToInt32(dt.Rows[0][0]);
            return 0;
        }
        public DataTable AracTipGetir()
        {
            string sorgu = string.Format("SELECT * FROM TBLARACTIP");
            DataTable dt = baglanti.executeSelectQuery(sorgu,null);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }

        public DataTable AboneTipGetir(int Id)
        {
            string sorgu = string.Format("SELECT * FROM TBLABONELIKTIPI where ID=@ID");
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ID", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(Id);
            DataTable dt = baglanti.executeSelectQuery(sorgu, sqlParameters);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }
    }
}
