using ArqStudio.DataTransferObject.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArqStudio.Interface
{
    internal interface ILogin
    {
        bool incluir(DtoLoginClienteProfissional lcp);

        bool update(DtoLoginClienteProfissional lcp);

        bool delete(DtoLoginClienteProfissional lcp);

    }
}
