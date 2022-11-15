using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArqStudio.DataTransferObject.Avaliação
{
    public class DtoGridAvalicaoProfissional
    {
        private int idAvaliacao;
        private string cliente;
        private string descricao;
        private int nota;

        public int IdAvaliacao { get => idAvaliacao; set => idAvaliacao = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int Nota { get => nota; set => nota = value; }
    }
}
