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
            parayiAl();
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

        public decimal ParaGoster()
        {
            string sorgu = string.Format("SELECT PARA FROM TBLKASA");
            DataTable dt = baglanti.executeSelectQuery(sorgu, null);
            if (dt.Rows.Count > 0)
            {
                this.para = Convert.ToDecimal(dt.Rows[0][0]);
            }
            return this.para;
        }
        public bool ParaEkle(decimal miktar)
        {
            parayiAl();
            string sorgu = string.Format("UPDATE TBLKASA SET PARA=@PARA");
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@PARA", SqlDbType.Decimal);
            sqlParameters[0].Value = this.para + miktar;
            if (baglanti.executeUpdateQuery(sorgu, sqlParameters))
                return true;
            return false;
        }
        public bool ParaCikar(decimal miktar)
        {
            parayiAl();
            string sorgu = string.Format("UPDATE TBLKASA SET PARA=@PARA");
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@PARA", SqlDbType.Decimal);
            sqlParameters[0].Value = this.para - miktar;
            if (baglanti.executeUpdateQuery(sorgu, sqlParameters))
                return true;
            return false;
        }
        public bool SonKayitSil()
        {
            string query = "DELETE FROM TBLKASAISLEM ORDER BY ID DESC LIMIT 1";
            baglanti.executeInsertQuery(query, null);
            return true;
        }

        public List<EntityLayer.KasaIslemi> SonKasaGirisleriGetir(string Tipi)
        {
            List<EntityLayer.KasaIslemi> kasaIslemiListe = new List<EntityLayer.KasaIslemi>();
            EntityLayer.KasaIslemi kasaIslemi = new EntityLayer.KasaIslemi();
            string query = "SELECT TOP 15 * FROM TBLKASAISLEM WHERE ISLEM=@Tipi ORDER BY ID DESC";
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@Tipi", SqlDbType.VarChar);
            parameter[0].Value = Tipi;
            DataTable dt = baglanti.executeSelectQuery(query, parameter);
            foreach (DataRow dr in dt.Rows)
            {
                kasaIslemi = new EntityLayer.KasaIslemi();
                kasaIslemi.Aciklama = dr["ACIKLAMA"].ToString();
                kasaIslemi.Id = Convert.ToInt32(dr["ID"]);
                kasaIslemi.IslemTipi = Convert.ToString(dr["ISLEM"]);
                kasaIslemi.Tarih = Convert.ToDateTime(dr["TARIH"]);
                kasaIslemi.Ucret = Convert.ToDecimal(dr["UCRET"]);
                kasaIslemiListe.Add(kasaIslemi);
            }
            return kasaIslemiListe;
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
