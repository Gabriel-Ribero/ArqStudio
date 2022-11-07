using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArqStudio.Model
{
    internal class Endereco
    {
        private int idEndereco;
        private string rua;
        private int numero;
        private string bairro;
        private string loteamento;
        private string quadra;
        private string lote;
        private string cidade;
        private string estado;
        private char enderecoProjeto;
        private int idUsuario;

        public int IdEndereco { get => idEndereco; set => idEndereco = value; }
        public string Rua { get => rua; set => rua = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Loteamento { get => loteamento; set => loteamento = value; }
        public string Quadra { get => quadra; set => quadra = value; }
        public string Lote { get => lote; set => lote = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public char EnderecoProjeto { get => enderecoProjeto; set => enderecoProjeto = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
    }
}
