using ArqStudio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArqStudio.DataTransferObject.Login
{
    public class DtoLoginClienteProfissional
    {
        public DtoLoginClienteProfissional()
        {
            usuario = new Usuario();
            cliente = new Cliente();
            profissional = new Profissional();
        }
        private Usuario usuario;
        private Cliente cliente;
        private Profissional profissional;

        internal Usuario Usuario { get => usuario; set => usuario = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }
        public Profissional Profissional { get => profissional; set => profissional = value; }
    }
}
