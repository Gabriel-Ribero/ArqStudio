using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArqStudio.Model
{
    internal class Cliente
    {
        private int idCliente;
        private string nome;
        private string sobreNome;
        private string rG;
        private string cPF;
        private DateTime dataNasc;
        private string dDD;
        private string telefone;
        private string profissao;
        private int idUsuario;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Nome { get => nome; set => nome = value; }
        public string SobreNome { get => sobreNome; set => sobreNome = value; }
        public string RG { get => rG; set => rG = value; }
        public string CPF { get => cPF; set => cPF = value; }
        public DateTime DataNasc { get => dataNasc; set => dataNasc = value; }
        public string DDD { get => dDD; set => dDD = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Profissao { get => profissao; set => profissao = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
    }
}
