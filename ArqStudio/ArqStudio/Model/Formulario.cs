using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArqStudio.Model
{
    internal class Formulario
    {
        private int idFormulario;
        private int quantPessoasHabitam;
        private int pessoaDeficiente;
        private string descricaoDeficiente;
        private int animaisEstimacao;
        private string quaisAnimais;
        private int pessoaTrabalhaEmCasa;
        private string estiloArquitetonico;
        private string status;
        private int idEndereco;
        private int idUsuario;

        public int IdFormulario { get => idFormulario; set => idFormulario = value; }
        public int QuantPessoasHabitam { get => quantPessoasHabitam; set => quantPessoasHabitam = value; }
        public int PessoaDeficiente { get => pessoaDeficiente; set => pessoaDeficiente = value; }
        public string DescricaoDeficiente { get => descricaoDeficiente; set => descricaoDeficiente = value; }
        public int AnimaisEstimacao { get => animaisEstimacao; set => animaisEstimacao = value; }
        public string QuaisAnimais { get => quaisAnimais; set => quaisAnimais = value; }
        public int PessoaTrabalhaEmCasa { get => pessoaTrabalhaEmCasa; set => pessoaTrabalhaEmCasa = value; }
        public string EstiloArquitetonico { get => estiloArquitetonico; set => estiloArquitetonico = value; }
        public string Status { get => status; set => status = value; }
        public int IdEndereco { get => idEndereco; set => idEndereco = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
    }
}
