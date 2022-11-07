using ArqStudio.DataTransferObject.Login;
using ArqStudio.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArqStudio.Repository
{
    internal class LoginRep : ILogin
    {
        private string sql;
        

        public bool incluir(DtoLoginClienteProfissional lcp)
        {
            try
            {
                SqlConnectionExecute("Insert Into Usuario(Email, Senha)" +
                                     $"Values ('{lcp.Usuario.Email}', '{lcp.Usuario.Senha}'");

                int id = 0;
                SqlDataReader dr = SqlConnectionRead("Select IdUsuario From Usuario Order By IdUsuario Desc");
                while (dr.Read())
                {
                    id = int.Parse(dr[0].ToString());
                }
                SqlConnectionExecute("Insert Into Cliente(Nome, SobreNome, RG, CPF, DataNasc, DDD, Telefone, Profissao, IdUsuario" +
                                     $"Values ('{lcp.Cliente.Nome}', '{lcp.Cliente.SobreNome}', '{lcp.Cliente.RG}', '{lcp.Cliente.CPF}', '{lcp.Cliente.DataNasc}'," +
                                     $"'{lcp.Cliente.DDD}', '{lcp.Cliente.Telefone}', '{lcp.Cliente.Profissao}', '{id}'");


                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool update(DtoLoginClienteProfissional lcp)
        {
            throw new NotImplementedException();
        }

        public bool delete(DtoLoginClienteProfissional lcp)
        {
            throw new NotImplementedException();
        }


        public void SqlConnectionExecute(string query)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server = .\\MY_NOTEBOOK; Database = ArqStudio; UID = sa; PWD = Cap123;";
            conn.Open();

            sql = query;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public SqlDataReader SqlConnectionRead(string query)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server = .\\MY_NOTEBOOK; Database = ArqStudio; UID = sa; PWD = Cap123;";
            conn.Open();

            sql = query;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
    }
}
