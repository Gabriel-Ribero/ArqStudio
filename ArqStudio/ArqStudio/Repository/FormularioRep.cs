using ArqStudio.Interface;
using ArqStudio.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArqStudio.DataTransferObject.Projeto;

namespace ArqStudio.Repository
{
    internal class FormularioRep : IFormulario
    {

        private RepositoryBase rb = new RepositoryBase();

        public bool alterar(Formulario p)
        {
            try
            {
                rb.SqlConnectionExecute($"Update Formulario Set QuantPessoasHabitam = '{p.QuantPessoasHabitam}', PessoasDeficientes = '{p.PessoasDeficientes}', DescricaoDeficiente = '{p.DescricaoDeficientes}'," +
                                         $"AnimaisEstimacao = '{p.AnimaisEstimacao}', DescricaoAnimais = '{p.DescricaoAnimais}', PessoasTrabalhaEmCasa = '{p.PessoasTrabalhaEmCasa}', EstiloArquitetonico = '{p.EstiloArquitetonico}', Status = '{p.Status}', IdEndereco = '{p.IdEndereco}', IdUsuario = '{p.IdUsuario}'" +
                                         $"Where IdFormulario = {p.IdFormulario}");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool excluir(int IdFormulario)
        {
            try
            {
                rb.SqlConnectionExecute($"Delete From Formulario Where IdFormulario = {IdFormulario}");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool incluir(Formulario p)
        {
            try
            {
                rb.SqlConnectionExecute("Insert Into Formulario(QuantPessoasHabitam, PessoasDeficientes, DescricaoDeficiente, AnimaisEstimacao," +
                                        "DescricaoAnimais, PessoasTrabalhaEmCasa, EstiloArquitetonico, Status, IdEndereco, IdUsuario)" +
                                     $"Values ({p.QuantPessoasHabitam}, {p.PessoasDeficientes}, '{p.DescricaoDeficientes}', {p.AnimaisEstimacao},'{p.DescricaoAnimais}', {p.PessoasTrabalhaEmCasa}, '{p.EstiloArquitetonico}', '{p.Status}', {p.IdEndereco}, {p.IdUsuario})");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                ff.DescricaoAnimais = dr[5].ToString();
                ff.PessoasTrabalhaEmCasa = int.Parse(dr[6].ToString());
                ff.EstiloArquitetonico = dr[7].ToString();
                ff.Status = dr[8].ToString();
                ff.IdEndereco = int.Parse(dr[9].ToString());
                ff.IdUsuario = int.Parse(dr[10].ToString());
                f.Add(ff);
            }
            dr.Close();
            return f;
        }

        public Formulario getFormulario(int id)
        {

            SqlDataReader dr = rb.SqlConnectionRead($"Select * From Formulario Where IdFormulario = '{id}'");

            Formulario f = new Formulario();
            if (dr.Read())
            {
                f.IdFormulario = int.Parse(dr[0].ToString());
                f.QuantPessoasHabitam = int.Parse(dr[1].ToString());
                f.PessoasDeficientes = int.Parse(dr[2].ToString());
                f.DescricaoDeficientes = dr[3].ToString();
                f.AnimaisEstimacao = int.Parse(dr[4].ToString());
                f.DescricaoAnimais = dr[5].ToString();
                f.PessoasTrabalhaEmCasa = int.Parse(dr[6].ToString());
                f.EstiloArquitetonico = dr[7].ToString();
                f.Status = dr[8].ToString();
                f.IdEndereco = int.Parse(dr[9].ToString());
                f.IdUsuario = int.Parse(dr[10].ToString());
            }
            dr.Close();
            return f;
        }

        public List<DtoGridProjetoProfissional> getListaFormularioProfissional()
        {
            SqlDataReader dr = rb.SqlConnectionRead($"Select f.IdFormulario, c.Nome Cliente, f.QuantPessoasHabitam, f.PessoasDeficientes, f.DescricaoDeficiente, f.AnimaisEstimacao, f.DescricaoAnimais, f.PessoasTrabalhaEmCasa, f.EstiloArquitetonico, f.Status, e.Rua, e.Nº, e.Bairro From Formulario f Inner Join Cliente c on c.IdUsuario = f.IdUsuario Inner Join Endereco e on f.IdEndereco = e.IdEndereco Order By c.Nome");

            List<DtoGridProjetoProfissional> f = new List<DtoGridProjetoProfissional>();
            while (dr.Read())
            {
                DtoGridProjetoProfissional ff = new DtoGridProjetoProfissional();
                ff.IdFormulario = int.Parse(dr[0].ToString());
                ff.Cliente = dr[1].ToString();
                ff.QuantPessoasHabitam = int.Parse(dr[2].ToString());
                ff.PessoasDeficientes = int.Parse(dr[3].ToString());
                ff.DescricaoDeficientes = dr[4].ToString();
                ff.AnimaisEstimacao = int.Parse(dr[5].ToString());
                ff.DescricaoAnimais = dr[6].ToString();
                ff.PessoasTrabalhamEmCasa = int.Parse(dr[7].ToString());
                ff.EstiloArquitetonico = dr[8].ToString();
                ff.Status = dr[9].ToString();
                ff.Rua = dr[10].ToString();
                ff.Numero = int.Parse(dr[11].ToString());
                ff.Bairro = dr[12].ToString();

                f.Add(ff);
            }
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
