using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArqStudio.Repository
{
    public class RepositoryBase
    {
        public void SqlConnectionExecute(string query)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server = MY_NOTEBOOK; Database = ArqStudio; UID = sa; PWD = Cap123;";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public SqlDataReader SqlConnectionRead(string query)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server = MY_NOTEBOOK; Database = ArqStudio; UID = sa; PWD = Cap123;";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
    }
}
