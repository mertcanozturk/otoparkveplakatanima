
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccessLayer
{
    public class dbConnection
    {
        private SqlConnection baglanti;
        private SqlDataAdapter komut;
        public dbConnection()
        {
            komut = new SqlDataAdapter();
            SqlConnection baglanti = new SqlConnection("Data Source=MERT;Initial Catalog=otopark;Integrated Security=True;");
            baglanti.Open();
        }


        private SqlConnection openConnection()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=MERT;Initial Catalog=otopark;Integrated Security=True;");

            if (baglanti.State == ConnectionState.Closed || baglanti.State == ConnectionState.Broken)
            {
                baglanti.Open();
            }
            return baglanti;
        }
        public DataTable executeSelectQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand sorgu = new SqlCommand();
            DataTable dataTable = new DataTable();
            dataTable = null;
            DataSet ds = new DataSet();
            try
            {
                sorgu.Connection = openConnection();
                sorgu.CommandText = _query;
                if(sqlParameter!=null)
                    sorgu.Parameters.AddRange(sqlParameter);
                sorgu.ExecuteNonQuery();
                komut.SelectCommand = sorgu;
                komut.Fill(ds);
                dataTable = ds.Tables[0];
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeSelectQuery - Query: " + _query + " \nException: " + e.StackTrace.ToString());
                return null;
            }
            finally
            {

            }
            return dataTable;
        }

        public DataTable Listele()
        {
            DataTable tablo = new DataTable();
            SqlCommand komut = new SqlCommand();
            SqlDataAdapter adaptor = new SqlDataAdapter();
            tablo.Clear();
            komut.Connection = baglanti;
            komut.CommandText = "Select * from TBLKULLANICI";
            adaptor.SelectCommand = komut;
            adaptor.Fill(tablo);
            return tablo;

        }

        public bool executeInsertQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand sorgu = new SqlCommand();
            try
            {
                sorgu.Connection = openConnection();
                sorgu.CommandText = _query;
                sorgu.Parameters.AddRange(sqlParameter);
                komut.InsertCommand = sorgu;
                sorgu.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeInsertQuery - Query: " + _query + " \nException: \n" + e.StackTrace.ToString());
                return false;
            }
            finally
            {
            }
            return true;
        }

        public bool executeUpdateQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand sorgu = new SqlCommand();
            try
            {
                sorgu.Connection = openConnection();
                sorgu.CommandText = _query;
                sorgu.Parameters.AddRange(sqlParameter);
                komut.UpdateCommand = sorgu;
                sorgu.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeUpdateQuery - Query: " + _query + " \nException: " + e.StackTrace.ToString());
                return false;
            }
            finally
            {
            }
            return true;
        }
    }
}