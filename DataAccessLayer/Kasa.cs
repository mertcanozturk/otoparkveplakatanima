using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Kasa
    {
        private dbConnection baglanti;
        private decimal para = 0;
        public Kasa()
        {
            baglanti = new dbConnection();
        }
        // KASA GUNCELLEME ISLEMI
        // KASA GIRIS CIKIS ISLEMI

        public void parayiAl()
        {

            string sorgu = string.Format("SELECT PARA FROM TBLKASA");
            DataTable dt = baglanti.executeSelectQuery(sorgu, null);
            if (dt.Rows.Count > 0)
            {
                this.para = Convert.ToDecimal(dt.Rows[0][0]);
            }
        }

        public bool ParaEkle(decimal miktar)
        {
            parayiAl();
            string sorgu = string.Format("UPDATE TBLKASA SET PARA=@PARA");
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@PARA", SqlDbType.Decimal);
            sqlParameters[0].Value = this.para+miktar;
            if (baglanti.executeUpdateQuery(sorgu, sqlParameters))
                return true;
            return false;
        }

        public bool IslemEkle(EntityLayer.KasaIslemi islem)
        {
            string query = "INSERT INTO TBLKASAISLEM (ISLEM,UCRET,ACIKLAMA,TARIH) VALUES (@ISLEM,@UCRET,@ACIKLAMA,@TARIH)";
            SqlParameter[] parameter = new SqlParameter[4];
            parameter[0] = new SqlParameter("@ISLEM", SqlDbType.VarChar);
            parameter[0].Value = islem.IslemTipi;
            parameter[1] = new SqlParameter("@UCRET", SqlDbType.Decimal);
            parameter[1].Value = islem.Ucret;
            parameter[2] = new SqlParameter("@ACIKLAMA", SqlDbType.Text);
            parameter[2].Value = islem.Aciklama;
            parameter[3] = new SqlParameter("@TARIH", SqlDbType.DateTime);
            parameter[3].Value = islem.Tarih;
            baglanti.executeInsertQuery(query, parameter);
            return true;
        }

    }
}
