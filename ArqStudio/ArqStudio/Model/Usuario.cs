using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArqStudio.Model
{
    internal class Usuario
    {
        private int idUsuario;
        private string email;
        private string senha;
        private int adm;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
        public int Adm { get => adm; set => adm = value; }
    }
}
