using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArqStudio.DataTransferObject.Projeto
{
    internal class DtoGridProjetoProfissional
    {
        private int idFormulario;
        private string cliente;
        private int quantPessoasHabitam;
        private int pessoasDeficientes;
        private string descricaoDeficientes;
        private int animaisEstimacao;
        private string descricaoAnimais;
        private int pessoasTrabalhamEmCasa;
        private string estiloArquitetonico;
        private string status;
        private string rua;
        private int numero;
        private string bairro;

        public int IdFormulario { get => idFormulario; set => idFormulario = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public int QuantPessoasHabitam { get => quantPessoasHabitam; set => quantPessoasHabitam = value; }
        public int PessoasDeficientes { get => pessoasDeficientes; set => pessoasDeficientes = value; }
        public string DescricaoDeficientes { get => descricaoDeficientes; set => descricaoDeficientes = value; }
        public int AnimaisEstimacao { get => animaisEstimacao; set => animaisEstimacao = value; }
        public string DescricaoAnimais { get => descricaoAnimais; set => descricaoAnimais = value; }
        public int PessoasTrabalhamEmCasa { get => pessoasTrabalhamEmCasa; set => pessoasTrabalhamEmCasa = value; }
        public string EstiloArquitetonico { get => estiloArquitetonico; set => estiloArquitetonico = value; }
        public string Status { get => status; set => status = value; }
        public string Rua { get => rua; set => rua = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Bairro { get => bairro; set => bairro = value; }
    }
}
