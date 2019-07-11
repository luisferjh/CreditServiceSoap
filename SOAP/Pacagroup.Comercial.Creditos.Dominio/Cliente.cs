﻿using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pacagroup.Comercial.Creditos.Dominio
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public int IdCliente { get; set; }

        [DataMember]
        public string Nombre { get; set; }

        [DataMember]
        public string ApellidoPaterno { get; set; }

        [DataMember]
        public string ApellidoMaterno { get; set; }

        [DataMember]
        public string TipoDocumento { get; set; }

        [DataMember]
        public string NumeroDocumento { get; set; }

        [DataMember]
        public string Sexo { get; set; }

        [DataMember]
        public DateTime FechaNacimiento { get; set; }

        [DataMember]
        public string Dirrecion { get; set; }

        [DataMember]
        public string CodigoPostal { get; set; }

        [DataMember]
        public string EstadoCivil { get; set; }
    }
}
