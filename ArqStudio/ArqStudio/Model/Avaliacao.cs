using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArqStudio.Model
{
    internal class Avaliacao
    {
        private int idAvaliacao;
        private int idCliente;
        private int idProfissional;
        private string descricao;
        private int nota;

        public int IdAvaliacao { get => idAvaliacao; set => idAvaliacao = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdProfissional { get => idProfissional; set => idProfissional = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int Nota { get => nota; set => nota = value; }
    }
}
