using Pacagroup.Comercial.Creditos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacagroup.Comercial.Creditos.ContRepositorio
{
    public interface IClienteRepositorio
    {
        Cliente ObtenerCliente(string NumeroDocumento);

        IEnumerable<Cliente> ListarCliente();
    }
}
