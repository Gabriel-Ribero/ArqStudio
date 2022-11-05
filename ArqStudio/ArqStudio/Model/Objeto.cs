using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArqStudio.Model
{
    public class Objeto
    {
        private int id;
        private string nome;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}
