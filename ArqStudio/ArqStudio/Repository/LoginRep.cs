using ArqStudio.DataTransferObject.Login;
using ArqStudio.Interface;
using ArqStudio.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                if (dr.Read())
                {
                    id = int.Parse(dr[0].ToString());
                }
                dr.Close();

                if (lcp.Usuario.Adm == 0)
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
            try
            {
                if (lcp.Usuario.Adm == 0)
                {
                    SqlConnectionExecute($"Update Cliente Set Nome = '{lcp.Cliente.Nome}', SobreNome = '{lcp.Cliente.SobreNome}', RG = '{lcp.Cliente.RG}'," +
                                         $"CPF = '{lcp.Cliente.CPF}', DataNasc = '{lcp.Cliente.DataNasc}', DDD = '{lcp.Cliente.DDD}', Telefone = '{lcp.Cliente.Telefone}', Profissao = '{lcp.Cliente.Profissao}'" +
                                         $"Where IdUsuario = {lcp.Usuario.IdUsuario}");
                }
                else
                {
                    SqlConnectionExecute($"Update Profissional Set Nome = '{lcp.Profissional.Nome}', SobreNome = '{lcp.Profissional.SobreNome}', CAU = '{lcp.Profissional.CAU}'," +
                                                             $"CPF = '{lcp.Profissional.CPF}'" +
                                                             $"Where IdUsuario = {lcp.Usuario.IdUsuario}");
                }
                return true;
            }
            catch
            {
                return false;
            }
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
                    SqlDataReader dr = SqlConnectionRead($"Select u.IdUsuario From Usuarios u Inner Join Cliente c on c.IdUsuario = u.IdUsuario Where c.CPF = {cpf}");
                    int id = 0;
                    if (dr.Read())
                    {
                        id = int.Parse(dr[0].ToString());
                    }
                    SqlConnectionExecute($"Update Usuarios Set Senha = {senha} Where IdUsuario = {id}");
                }
                else
                {
                    SqlDataReader dr = SqlConnectionRead($"Select u.IdUsuario From Usuarios u Inner Join Profissional p on p.IdUsuario = u.IdUsuario Where p.CPF = {cpf}");
                    int id = 0;
                    if (dr.Read())
                    {
                        id = int.Parse(dr[0].ToString());
                    }
                    SqlConnectionExecute($"Update Usuarios Set Senha = {senha} Where IdUsuario = {id}");
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

        public DtoLoginClienteProfissional getCliente(int id)
        {
            SqlDataReader dr = SqlConnectionRead($"Select u.IdUsuario, c.Nome, c.SobreNome, c.RG, c.CPF, c.DataNasc, c.DDD, c.Telefone, c.Profissao From Usuarios u Inner Join Cliente c on c.IdUsuario = u.IdUsuario Where u.IdUsuario = {id}");

            DtoLoginClienteProfissional clp = new DtoLoginClienteProfissional();
            while (dr.Read())
            {
                clp.Usuario.IdUsuario = int.Parse(dr[0].ToString());
                clp.Cliente.Nome = dr[1].ToString();
                clp.Cliente.SobreNome = dr[2].ToString();
                clp.Cliente.RG = dr[3].ToString();
                clp.Cliente.CPF = dr[4].ToString();
                clp.Cliente.DataNasc = DateTime.Parse(dr[5].ToString());
                clp.Cliente.DDD = dr[6].ToString();
                clp.Cliente.Telefone = dr[7].ToString();
                clp.Cliente.Profissao = dr[8].ToString();
            }
            dr.Close();
            return clp;
        }

        public DtoLoginClienteProfissional getProfissional(int id)
        {
            SqlDataReader dr = SqlConnectionRead($"Select u.IdUsuario, p.Nome, p.SobreNome, p.CAU, p.CPF From Usuarios u Inner Join Profissional p on p.IdUsuario = u.IdUsuario Where u.IdUsuario = {id}");

            DtoLoginClienteProfissional clp = new DtoLoginClienteProfissional();
            while (dr.Read())
            {
                clp.Usuario.IdUsuario = int.Parse(dr[0].ToString());
                clp.Profissional.Nome = dr[1].ToString();
                clp.Profissional.SobreNome = dr[2].ToString();
                clp.Profissional.CAU = dr[3].ToString();
                clp.Profissional.CPF = dr[4].ToString();
            }
            dr.Close();
            return clp;
        }


        #region "Funções"

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

        #endregion
    }
}
