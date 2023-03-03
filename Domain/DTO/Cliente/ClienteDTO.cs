using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace safi_gerenciamento_xml.Domain.DTO.Cliente
{
    public class ClienteDTO
    {
        public Guid? Id_Cliente {get;}
        public string? Nome_Cliente {get; set;}
        public string? Email_Cliente {get; set;}
        public Guid? Id_Contador {get; set;}

        public ClienteDTO(string nomeCliente, string emailCliente, Guid idContador)
        {
            Nome_Cliente = nomeCliente;
            Email_Cliente = emailCliente;
            Id_Contador = idContador;
        }
    }
}