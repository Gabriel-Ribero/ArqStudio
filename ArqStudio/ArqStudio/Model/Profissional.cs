using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArqStudio.Model
{
    internal class Profissional : Usuario
    {
        private int idProfissional;
        private string nome;
        private string sobreNome;
        private string cAU;
        private string cPF;
        private int idUsuario;

        public int IdProfissional { get => idProfissional; set => idProfissional = value; }
        public string Nome { get => nome; set => nome = value; }
        public string SobreNome { get => sobreNome; set => sobreNome = value; }
        public string CAU { get => cAU; set => cAU = value; }
        public string CPF { get => cPF; set => cPF = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
    }
}
