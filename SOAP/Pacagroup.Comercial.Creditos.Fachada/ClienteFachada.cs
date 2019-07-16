using Pacagroup.Comercial.Creditos.Dominio;
using System;
using System.Collections.Generic;
using Pacagroup.Comercial.Creditos.SqlRepositorio;
using Pacagroup.Comercial.Creditos.ContRepositorio;

namespace Pacagroup.Comercial.Creditos.Fachada
{
    public class ClienteFachada: IDisposable
    {
        public Cliente ObtenerCliente(string NumeroDocumento)
        {
            IClienteRepositorio instancia = new ClienteRepositorio();
            return instancia.ObtenerCliente(NumeroDocumento);
        }


        public IEnumerable<Cliente> ListarCliente()
        {
            IClienteRepositorio instancia = new ClienteRepositorio();
            return instancia.ListarCliente();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
