using ArqStudio.Interface;
using ArqStudio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ArqStudio.Repository
{
    internal class ProjetoRep : IProjeto
    {
        private RepositoryBase rb = new RepositoryBase();

        public bool incluir(Projetos p)
        {
            try
            {
                rb.SqlConnectionExecute("Insert Into Projeto(Descricao, NomeProjeto, DataInicio, DataConclusao, IdFormulario)" +
                                     $"Values ('{p.Descricao}', '{p.NomeProjeto}', '{p.DataInicio}', '{p.DataConclusao}',{p.IdFormulario})");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public Projetos getProjeto(int id)
        {

            SqlDataReader dr = rb.SqlConnectionRead($"Select * From Projeto Where IdProjeto = '{id}'");

            Projetos f = new Projetos();
            if (dr.Read())
            {
                f.IdProjeto = int.Parse(dr[0].ToString());
                f.Descricao = dr[1].ToString();
                f.NomeProjeto = dr[2].ToString();
                f.DataInicio = DateTime.Parse(dr[3].ToString());
                f.DataConclusao = DateTime.Parse(dr[4].ToString());
                f.IdFormulario = int.Parse(dr[5].ToString());
            }
            dr.Close();
            return f;
        }
    }
}
