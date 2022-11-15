using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ArqStudio.Model;
using System.Data;
using ArqStudio.DataTransferObject.Avaliação;

namespace ArqStudio.Repository
{
    internal class AvaliacaoRep : IAvaliacao
    {

        private RepositoryBase rb = new RepositoryBase();

        public bool adiciona(Avaliacao a)
        {
            try
            {
                rb.SqlConnectionExecute($"Insert into Avaliacao(IdCliente, IdProfissional, Descricao, Nota) " +
                $"values ('{a.IdCliente}','{a.IdProfissional}','{a.Descricao}','{a.Nota}')");

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool altera(Avaliacao a)
        {
            try
            {
                rb.SqlConnectionExecute($"Update Avaliacao Set IdProfissional = {a.IdProfissional}, Descricao = '{a.Descricao}', Nota = {a.Nota} Where IdAvaliacao = {a.IdAvaliacao}");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleta(int IdAvaliacao)
        {
            try
            {
                rb.SqlConnectionExecute($"Delete From Avaliacao Where IdAvaliacao = {IdAvaliacao}");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Avaliacao getAvaliacao(int id)
        {
            SqlDataReader dr = rb.SqlConnectionRead($"Select * From Avaliacao Where IdAvaliacao = '{id}'");

            Avaliacao a = new Avaliacao();
            if (dr.Read())
            {
                a.IdAvaliacao = int.Parse(dr[0].ToString());
                a.IdCliente = int.Parse(dr[1].ToString());
                a.IdProfissional = int.Parse(dr[2].ToString());
                a.Descricao = dr[3].ToString();
                a.Nota = int.Parse(dr[4].ToString());
            }
            return a;
        }

        public List<DtoGridAvaliacao> getListaAvaliacao(int IdCliente)
        {
            SqlDataReader dr = rb.SqlConnectionRead($"Select a.IdAvaliacao, p.Nome Profissional, a.Descricao, a.Nota From Avaliacao a Inner Join Profissional p on p.IdProfissional = a.IdProfissional Where IdCliente = '{IdCliente}'");

            List<DtoGridAvaliacao> a = new List<DtoGridAvaliacao>();
            while (dr.Read())
            {
                DtoGridAvaliacao aa = new DtoGridAvaliacao();
                aa.IdAvaliacao = int.Parse(dr[0].ToString());
                aa.Profissional = dr[1].ToString();
                aa.Descricao = dr[2].ToString();
                aa.Nota = int.Parse(dr[3].ToString());
                a.Add(aa);
            }
            return a;
        }

        public List<DtoGridAvalicaoProfissional> getListaAvaliacaoProfissional()
        {
            SqlDataReader dr = rb.SqlConnectionRead($"Select a.IdAvaliacao, c.Nome Cliente, a.Descricao, a.Nota From Avaliacao a Inner Join Cliente c on c.IdCliente = a.IdCliente Order By c.Nome");

            List<DtoGridAvalicaoProfissional> a = new List<DtoGridAvalicaoProfissional>();
            while (dr.Read())
            {
                DtoGridAvalicaoProfissional aa = new DtoGridAvalicaoProfissional();
                aa.IdAvaliacao = int.Parse(dr[0].ToString());
                aa.Cliente = dr[1].ToString();
                aa.Descricao = dr[2].ToString();
                aa.Nota = int.Parse(dr[3].ToString());
                a.Add(aa);
            }
            return a;
        }

        public Objeto getCliente(int IdUsuario)
        {
            SqlDataReader dr = rb.SqlConnectionRead($"Select IdCliente, Nome From Cliente Where IdUsuario = '{IdUsuario}'");

            Objeto o = new Objeto();
            if (dr.Read())
            {
                o.Id = int.Parse(dr[0].ToString());
                o.Nome = dr[1].ToString();
            }
            return o;
        }

        public IEnumerable<Objeto> getProfissional()
        {
            SqlDataReader dr = rb.SqlConnectionRead($"Select IdProfissional, Nome From Profissional");

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
