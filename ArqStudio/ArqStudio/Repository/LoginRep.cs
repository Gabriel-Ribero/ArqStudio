using ArqStudio.DataTransferObject.Login;
using ArqStudio.Interface;
using ArqStudio.Model;
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
                SqlConnectionExecute("Insert Into Usuarios(Email, Senha, Adm)" +
                                     $"Values ('{lcp.Usuario.Email}', '{lcp.Usuario.Senha}', '{lcp.Usuario.Adm}')");

                int id = 0;
                SqlDataReader dr = SqlConnectionRead("Select IdUsuario From Usuarios Order By IdUsuario Desc");
                while (dr.Read())
                {
                    id = int.Parse(dr[0].ToString());
                }
                dr.Close();

                if(lcp.Usuario.Adm == 0)
                {
                    SqlConnectionExecute("Insert Into Cliente(Nome, SobreNome, RG, CPF, DataNasc, DDD, Telefone, Profissao, IdUsuario)" +
                                     $"Values ('{lcp.Cliente.Nome}', '{lcp.Cliente.SobreNome}', '{lcp.Cliente.RG}', '{lcp.Cliente.CPF}', '{lcp.Cliente.DataNasc}'," +
                                     $"'{lcp.Cliente.DDD}', '{lcp.Cliente.Telefone}', '{lcp.Cliente.Profissao}', '{id}')");

                    foreach (Endereco item in lcp.ListaEndereco)
                    {
                        SqlConnectionExecute("Insert Into Endereco(Rua, Nº, Bairro, Loteamento, Quadra, Lote, Cidade, Estado, EnderecoProjeto, IdUsuario)" +
                                             $"Values ('{item.Rua}', '{item.Numero}', '{item.Bairro}', '{item.Loteamento}', '{item.Quadra}', '{item.Lote}', '{item.Cidade}', '{item.Estado}', '{item.EnderecoProjeto}', '{id}')");
                    }
                }
                else
                {
                    SqlConnectionExecute("Insert Into Profissional(Nome, SobreNome, CAU, CPF, IdUsuario)" +
                                     $"Values ('{lcp.Profissional.Nome}', '{lcp.Profissional.SobreNome}', '{lcp.Profissional.CAU}', '{lcp.Profissional.CPF}', '{id}')");
                }

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

        public bool updateSenha(string senha, string cpf, bool adm)
        {
            try
            {
                if (!adm)
                {
                    SqlConnectionExecute($"Update Usuarios u Set Senha = {senha}" +
                                         $"Inner Join Cliente c on c.IdUsuario = u.IdUsuario" +
                                         $"Where c.CPF Like {cpf}");
                }
                else
                {
                    SqlConnectionExecute($"Update Usuarios u Set Senha = {senha}" +
                                         $"Inner Join Profissional p on p.IdUsuario = u.IdUsuario" +
                                         $"Where p.CPF Like {cpf}");
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public Usuario getUsuario(string email, string senha)
        {
            SqlDataReader dr = SqlConnectionRead($"Select * From Usuarios Where Email like '{email}' And Senha like '{senha}'");

            Usuario u = new Usuario();
            while (dr.Read())
            {
                u.IdUsuario = int.Parse(dr[0].ToString());
                u.Adm = int.Parse(dr[3].ToString());
            }
            dr.Close();
            return u;
        }

        public void SqlConnectionExecute(string query)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server = MY_NOTEBOOK; Database = ArqStudio; UID = sa; PWD = Cap123;";
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
            conn.ConnectionString = "Server = MY_NOTEBOOK; Database = ArqStudio; UID = sa; PWD = Cap123;";
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
