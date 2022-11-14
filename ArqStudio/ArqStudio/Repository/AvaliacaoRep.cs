using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ArqStudio.Model;
using System.Data;

namespace ArqStudio.Repository
{
    internal class AvaliacaoRep : IAvaliacao
    {

        public void adiciona(Avaliacao Ava)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server = MY_NOTEBOOK; Database = ArqStudio; UID = sa; PWD = Cap123;";
            conn.Open();
            string sql = $"Insert into Avaliacao(IdCliente, IdProfissional, Descricao, Nota) " +
                $"values ('{Ava.IdCliente}','{Ava.IdUsuario}','{Ava.Descricao}','{Ava.Nota}')";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void altera(Avaliacao Ava)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server = MY_NOTEBOOK; Database = ArqStudio; UID = sa; PWD = Cap123;";
            conn.Open();
            string sql = $"Update Avaliacao set IdCliente = {Ava.IdCliente}, " +
                $"IdProfissional = {Ava.IdUsuario}, Descricao = '{Ava.Descricao}', Nota = '{Ava.Nota}' where IdAvaliacao = {Ava.IdAvaliacao}";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void deleta(Avaliacao Ava)
        {
            throw new NotImplementedException();
        }

        public void exclui(Avaliacao Ava)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server = MY_NOTEBOOK; Database = ArqStudio; UID = sa; PWD = Cap123;";
            conn.Open();
            string sql = $"Delete Avaliacao where IdAvaliacao = '{Ava.IdAvaliacao}'";

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataSet Get(int pesquisa)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server = MY_NOTEBOOK; Database = ArqStudio; UID = sa; PWD = Cap123;";
            conn.Open();

            string sql = $"select A.IdAvaliacao, C.Nome, P.Nome, A.Descricao, A.Nota" +
                $" from Avaliacao A INNER JOIN Cliente C on A.IdCliente = C.IdCliente " +
                $" Avaliacao A INNER JOIN Profissional P on A.IdProfissional = P.IdProfissional" +
                $"where IdCliente = {pesquisa}";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            return ds;

        }

        public Avaliacao GetAvaliacao(int id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server = MY_NOTEBOOK; Database = ArqStudio; UID = sa; PWD = Cap123;";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"Select * from Avaliacao where IdCliente = {id}";

            SqlDataReader dr = cmd.ExecuteReader();
            Avaliacao Ava = new Avaliacao();

            if (dr.Read())
            {
                Ava.IdAvaliacao = int.Parse(dr[0].ToString());
                Ava.IdCliente = int.Parse(dr[1].ToString());
                Ava.IdUsuario = int.Parse(dr[2].ToString());
                Ava.Descricao = dr[3].ToString();
                Ava.Nota = int.Parse(dr[4].ToString());
            }
            return Ava;
        }

        public IEnumerable<Objeto> GetCliente(int id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server = MY_NOTEBOOK; Database = ArqStudio; UID = sa; PWD = Cap123;";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"Select * from Cliente";

            SqlDataReader dr = cmd.ExecuteReader();
            List<Objeto> ob = new List<Objeto>();

            while (dr.Read())
            {
                Objeto Aux = new Objeto();
                Aux.Id = int.Parse(dr[0].ToString());
                Aux.Nome = dr[1].ToString();
                ob.Add(Aux);
            }
            return ob;
        }

        public IEnumerable<Objeto> GetProfissional()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server = MY_NOTEBOOK; Database = ArqStudio; UID = sa; PWD = Cap123;";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"Select * from Profissional";

            SqlDataReader dr = cmd.ExecuteReader();
            List<Objeto> ob = new List<Objeto>();

            while (dr.Read())
            {
                Objeto Aux = new Objeto();
                Aux.Id = int.Parse(dr[0].ToString());
                Aux.Nome = dr[1].ToString();
                ob.Add(Aux);
            }
            return ob;
        }
    }
}
