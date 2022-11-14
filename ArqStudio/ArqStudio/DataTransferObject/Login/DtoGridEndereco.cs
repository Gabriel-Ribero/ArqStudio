using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArqStudio.DataTransferObject.Login
{
    public class DtoGridEndereco
    {
        private int id;
        private string rua;
        private string bairro;
        private string numero;
        private string cidade;
        private string estado;

        public int Id { get => id; set => id = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
