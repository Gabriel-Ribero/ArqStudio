using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ArqStudio.Model
{
    internal interface IAvaliacao
    {
        void adiciona(Avaliacao Ava);

        void altera(Avaliacao Ava);

        void deleta(Avaliacao Ava);

        Avaliacao GetAvaliacao(int id);

        List<Objeto> GetCliente(int id);
        List<Objeto> GetProfissional(int id);

        DataSet Get(int pesquisa);
    }
}
