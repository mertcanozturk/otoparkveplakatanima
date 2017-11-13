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
        public bool AracTipEkle(EntityLayer.Arac.AracTip aracTip)
        {
            string query = "INSERT INTO TBLARACTIP (ARACTIPADI,FIYAT) VALUES (@ARACTIPADI,@FIYAT)";
            SqlParameter[] parameter = new SqlParameter[2];
            parameter[0] = new SqlParameter("@ARACTIPADI", SqlDbType.VarChar);
            parameter[0].Value = aracTip.Adi;
            parameter[1] = new SqlParameter("@FIYAT", SqlDbType.Decimal);
            parameter[1].Value = aracTip.Fiyat;
            baglanti.executeInsertQuery(query, parameter);
            return true;
        }

        public bool AracTipGuncelle(EntityLayer.Arac.AracTip aracTip)
        {
            string query = "UPDATE TBLARACTIP SET ARACTIPADI=@ARACTIPADI, FIYAT=@FIYAT WHERE ID=@ID";
            SqlParameter[] parameter = new SqlParameter[3];
            parameter[0] = new SqlParameter("@ARACTIPADI", SqlDbType.VarChar);
            parameter[0].Value = aracTip.Adi;
            parameter[1] = new SqlParameter("@FIYAT", SqlDbType.Decimal);
            parameter[1].Value = aracTip.Fiyat;
            parameter[2] = new SqlParameter("@ID", SqlDbType.Int);
            parameter[2].Value = aracTip.Id;
            baglanti.executeInsertQuery(query, parameter);
            return true;
        }
        public bool AracTipSil(int Id)
        {
            string query = "DELETE FROM TBLARACTIP WHERE ID=@ID";
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@ID", SqlDbType.Int);
            parameter[0].Value = Id;
            baglanti.executeInsertQuery(query, parameter);
            return true;
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
            DataTable dt = baglanti.executeSelectQuery(sorgu, null);
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