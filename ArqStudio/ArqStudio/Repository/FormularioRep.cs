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
    internal class FormularioRep : IFormulario
    {

        private RepositoryBase rb = new RepositoryBase();

        bool IFormulario.alterar(Formulario p)
        {
            throw new NotImplementedException();
        }

        bool IFormulario.excluir(Formulario p)
        {
            throw new NotImplementedException();
        }

        public bool incluir(Formulario p)
        {
            try
            {
                rb.SqlConnectionExecute("Insert Into Formulario(QuantPessoasHabitam, PessoasDeficientes, DescricaoDeficiente, AnimaisEstimacao," +
                                        "DescricaoAnimais, PessoasTrabalhaEmCasa, EstiloArquitetonico, Status, IdEndereco, IdUsuario)" +
                                     $"Values ('{p.QuantPessoasHabitam}', '{p.PessoasDeficientes}', '{p.DescricaoDeficientes}, '{p.AnimaisEstimacao}'" +
                                     $"'{p.DescricaoAnimais}', '{p.PessoasTrabalhaEmCasa}', '{p.EstiloArquitetonico}', '{p.Status}', '{p.IdEndereco}', '{p.IdUsuario}'')");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Formulario> getPerguntas(int id)
        {

            SqlDataReader dr = rb.SqlConnectionRead($"Select * From Formulario Where IdUsuario = '{id}'");

            List<Formulario> f = new List<Formulario>();
            while (dr.Read())
            {
                Formulario ff = new Formulario();
                ff.IdFormulario = int.Parse(dr[0].ToString());
                ff.QuantPessoasHabitam = int.Parse(dr[1].ToString());
                ff.PessoasDeficientes = int.Parse(dr[2].ToString());
                ff.DescricaoDeficientes = dr[3].ToString();
                ff.AnimaisEstimacao = int.Parse(dr[4].ToString());
                ff.DescricaoDeficientes = dr[5].ToString();
                ff.PessoasTrabalhaEmCasa = int.Parse(dr[6].ToString());
                ff.EstiloArquitetonico = dr[7].ToString();
                ff.IdEndereco = int.Parse(dr[8].ToString());
                ff.Status = dr[9].ToString();
                f.Add(ff);
            }
            dr.Close();
            return f;
        }

        public List<Endereco> getEndereco(int id)
        {
            SqlDataReader dr = rb.SqlConnectionRead($"Select IdEndereco, 'Rua ' + Rua + ' - Bairro ' + Bairro Rua From Endereco Where IdUsuario = '{id}'");

            List<Endereco> e = new List<Endereco>();
            while (dr.Read())
            {
                Endereco ee = new Endereco();
                ee.IdEndereco = int.Parse(dr[0].ToString());
                ee.Rua = dr[1].ToString();
                e.Add(ee);
            }
            dr.Close();
            return e;
        }

    }
}
