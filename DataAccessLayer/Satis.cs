using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Satis
    {
        private dbConnection baglanti;

        public Satis()
        {
            baglanti = new dbConnection();
        }

        public bool Kaydet(EntityLayer.Satis satis)
        {
            string query = "INSERT INTO TBLSATISLAR (ARACTIPNO,PLAKA,ABONENO,GIRISTARIHI,CIKISTARIHI,KONTAK,UCRET,KULLANICIID) VALUES (@ARACTIPNO,@PLAKA,@ABONENO,@GIRISTARIHI,@CIKISTARIHI,@KONTAK,@UCRET,@KULLANICIID)";
            SqlParameter[] sqlParameters = new SqlParameter[8];
            sqlParameters[0] = new SqlParameter("@PLAKA", SqlDbType.VarChar);
            sqlParameters[0].Value = satis.Plaka;
            sqlParameters[1] = new SqlParameter("@ARACTIPNO", SqlDbType.Int);
            sqlParameters[1].Value = satis.AracTipNo;
            sqlParameters[2] = new SqlParameter("@ABONENO", SqlDbType.Int);
            sqlParameters[2].Value = satis.AboneNo;
            sqlParameters[3] = new SqlParameter("@GIRISTARIHI", SqlDbType.DateTime);
            sqlParameters[3].Value = satis.GirisTarihi;
            sqlParameters[4] = new SqlParameter("@CIKISTARIHI", SqlDbType.DateTime);
            sqlParameters[4].Value = satis.CikisTarihi;
            sqlParameters[5] = new SqlParameter("@KONTAK", SqlDbType.Bit);
            sqlParameters[5].Value = satis.Kontak;
            sqlParameters[6] = new SqlParameter("@UCRET", SqlDbType.Decimal);
            sqlParameters[6].Value = satis.Ucret;
            sqlParameters[7] = new SqlParameter("@KULLANICIID", SqlDbType.Int);
            sqlParameters[7].Value = satis.KullaniciId;
            return baglanti.executeInsertQuery(query, sqlParameters);

        }
    }
}
