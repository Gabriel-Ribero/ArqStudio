using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArqStudio.Model
{
    internal class Projetos
    {
        private int idProjeto;
        private string descricao;
        private string nomeProjeto;
        private DateTime dataInicio;
        private DateTime dataConclusao;
        private int idFormulario;

        public int IdProjeto { get => idProjeto; set => idProjeto = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string NomeProjeto { get => nomeProjeto; set => nomeProjeto = value; }
        public DateTime DataInicio { get => dataInicio; set => dataInicio = value; }
        public DateTime DataConclusao { get => dataConclusao; set => dataConclusao = value; }
        public int IdFormulario { get => idFormulario; set => idFormulario = value; }
    }
}
