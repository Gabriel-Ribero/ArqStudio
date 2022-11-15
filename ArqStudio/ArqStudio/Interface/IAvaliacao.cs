using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ArqStudio.DataTransferObject.Avaliação;

namespace ArqStudio.Model
{
    internal interface IAvaliacao
    {
        bool adiciona(Avaliacao Ava);

        bool altera(Avaliacao Ava);

        bool deleta(int IdAvaliacao);

        Avaliacao getAvaliacao(int id);

        List<DtoGridAvaliacao> getListaAvaliacao(int IdCliente);

        List<DtoGridAvalicaoProfissional> getListaAvaliacaoProfissional();

        Objeto getCliente(int id);

        IEnumerable<Objeto> getProfissional();
    }
}
