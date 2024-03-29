﻿using Pacagroup.Comercial.Creditos.ContRepositorio;
using Pacagroup.Comercial.Creditos.Dominio;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Dapper;

namespace Pacagroup.Comercial.Creditos.SqlRepositorio
{
    public class ClienteRepositorio:IClienteRepositorio
    {
        public Cliente ObtenerCliente(string NumeroDocumento)
        {
            using (IDbConnection conexion = new SqlConnection(ConexionRepositorio.ObtenerCadenaConexion()))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("pNumeroDocumento", NumeroDocumento);

                var cliente = conexion.QuerySingle<Cliente>("dbo.sp_cliente_obtener", param: parametros,
                    commandType: CommandType.StoredProcedure);

                return cliente;
            }
        }

        public IEnumerable<Cliente> ListarCliente()
        {
            using (IDbConnection conexion = new SqlConnection(ConexionRepositorio.ObtenerCadenaConexion()))
            {
                conexion.Open();               

                var Clientes = conexion.Query<Cliente>("dbo.sp_cliente_listar",
                    commandType: CommandType.StoredProcedure);

                return Clientes;
            }
        }
    }
}
