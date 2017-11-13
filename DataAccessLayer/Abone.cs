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


        public bool AboneTipGuncelle(EntityLayer.AboneTip aboneTip)
        {
            string query = string.Format("UPDATE TBLABONELIKTIPI SET ABONELIKADI=@ABONELIKADI, SURE=@SURE, FIYAT=@FIYAT WHERE ID=@ID");
            SqlParameter[] parameter = new SqlParameter[4];
            parameter[0] = new SqlParameter("@ABONELIKADI", SqlDbType.VarChar);
            parameter[0].Value = aboneTip.Adi;
            parameter[1] = new SqlParameter("@SURE", SqlDbType.Int);
            parameter[1].Value = aboneTip.Sure;
            parameter[2] = new SqlParameter("@FIYAT", SqlDbType.Decimal);
            parameter[2].Value = aboneTip.Ucret;
            parameter[3] = new SqlParameter("@ID", SqlDbType.Int);
            parameter[3].Value = aboneTip.Id;
            baglanti.executeInsertQuery(query, parameter);
            return true;
        }
        public bool AboneTipSil(int Id)
        {
            string query = string.Format("DELETE FROM TBLABONELIKTIPI WHERE ID=@ID");
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@ID", SqlDbType.Int);
            parameter[0].Value = Id;
            baglanti.executeInsertQuery(query, parameter);
            return true;
        }

        public bool AboneTipEkle(EntityLayer.AboneTip aboneTip)
        {
            string query = string.Format("INSERT INTO TBLABONELIKTIPI (ABONELIKADI,SURE,FIYAT) VALUES (@ABONELIKADI,@SURE,@FIYAT)");
            SqlParameter[] parameter = new SqlParameter[3];
            parameter[0] = new SqlParameter("@ABONELIKADI", SqlDbType.VarChar);
            parameter[0].Value = aboneTip.Adi;
            parameter[1] = new SqlParameter("@SURE", SqlDbType.Int);
            parameter[1].Value = aboneTip.Sure;
            parameter[2] = new SqlParameter("@FIYAT", SqlDbType.Decimal);
            parameter[2].Value = aboneTip.Ucret;
            baglanti.executeInsertQuery(query, parameter);
            return true;
        }


        public bool AboneEkle(EntityLayer.Abone abone)
        {
            try
            {
                string query = string.Format("INSERT INTO TBLABONE (ADI,SOYADI,ADRES,TELEFON,PLAKA,ARACTIPNO,GIRISTARIH,BITISTARIHI,ABONELIKTIPINO,KULLANICIID) VALUES(@ADI,@SOYADI,@ADRES,@TELEFON,@PLAKA,@ARACTIPNO,@GIRISTARIH,@BITISTARIHI,@ABONELIKTIPINO,@KULLANICIID)");
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
                parameter[6] = new SqlParameter("@GIRISTARIH", SqlDbType.DateTime);
                parameter[6].Value = abone.GirisTarihi;
                parameter[7] = new SqlParameter("@BITISTARIHI", SqlDbType.DateTime);
                parameter[7].Value = abone.BitisTarihi;
                parameter[8] = new SqlParameter("@ABONELIKTIPINO", SqlDbType.Int);
                parameter[8].Value = abone.AbonelikTipiNo;
                parameter[9] = new SqlParameter("@KULLANICIID", SqlDbType.Int);
                parameter[9].Value = abone.KullaniciId;
                baglanti.executeInsertQuery(query, parameter);
                return true;

            }
            catch (Exception)
            {
                return false;
            }
           
           
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

        public List<EntityLayer.AboneTip> AboneTipListesiGetir()
        {
            string sorgu = string.Format("SELECT * FROM TBLABONELIKTIPI");
            DataTable dt = baglanti.executeSelectQuery(sorgu, null);
            List<EntityLayer.AboneTip> aboneTips = new List<EntityLayer.AboneTip>();
            EntityLayer.AboneTip aboneTip = new EntityLayer.AboneTip();
            foreach (DataRow dr in dt.Rows)
            {
                aboneTip = new EntityLayer.AboneTip();
                aboneTip.Id = Convert.ToInt32(dr[0]);
                aboneTip.Adi = dr[1].ToString();
                aboneTip.Sure= Convert.ToInt32(dr[2]);
                aboneTip.Ucret = Convert.ToDecimal(dr[3]);
                aboneTips.Add(aboneTip);
            }
            return aboneTips;
        }

        public int AbonelikTipiIdGetir(string aboneTipAdi)
        {
            string sorgu = string.Format("SELECT * FROM TBLABONELIKTIPI WHERE ABONELIKADI=@ABONELIKADI");
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@ABONELIKADI", SqlDbType.VarChar);
            parameter[0].Value = aboneTipAdi;
            DataTable dt = baglanti.executeSelectQuery(sorgu, parameter);
            if (dt.Rows.Count > 0)
                return Convert.ToInt32(dt.Rows[0][0]);
            return 0;
        }
        public EntityLayer.AboneTip AboneTipGetir(string aboneTipAdi)
        {
            EntityLayer.AboneTip aboneTip = new EntityLayer.AboneTip();
            string sorgu = string.Format("SELECT * FROM TBLABONELIKTIPI WHERE ABONELIKADI=@ABONELIKADI");
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@ABONELIKADI", SqlDbType.VarChar);
            parameter[0].Value = aboneTipAdi;
            DataTable dt = baglanti.executeSelectQuery(sorgu, parameter);
            if (dt.Rows.Count > 0)
            {
                aboneTip.Id = Convert.ToInt32(dt.Rows[0][0]);
                aboneTip.Adi = dt.Rows[0][1].ToString();
                aboneTip.Sure = Convert.ToInt32(dt.Rows[0][2]);
                aboneTip.Ucret = Convert.ToDecimal(dt.Rows[0][3]);
            }
            return aboneTip;

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
