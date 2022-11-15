using ArqStudio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArqStudio.Interface
{
    internal interface IFormulario
    {
        bool incluir(Formulario p);

        bool alterar(Formulario p);

        bool excluir(int IdFormulario);

        Formulario getFormulario(int id);

        List<Formulario> getPerguntas(int id);

        List<Endereco> getEndereco(int id);
    }
}
