using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArqStudio.Model
{
    internal class Foto
    {
        private int idFoto;
        private string url;
        private int idProjeto;

        public int IdFoto { get => idFoto; set => idFoto = value; }
        public string Url { get => url; set => url = value; }
        public int IdProjeto { get => idProjeto; set => idProjeto = value; }
    }
}
