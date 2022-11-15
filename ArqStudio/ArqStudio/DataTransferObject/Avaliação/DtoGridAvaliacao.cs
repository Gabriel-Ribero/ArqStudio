using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArqStudio.DataTransferObject.Avaliação
{
    public class DtoGridAvaliacao
    {
        private int idAvaliacao;
        private string profissional;
        private string descricao;
        private int nota;

        public int IdAvaliacao { get => idAvaliacao; set => idAvaliacao = value; }
        public string Profissional { get => profissional; set => profissional = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int Nota { get => nota; set => nota = value; }
    }
}
