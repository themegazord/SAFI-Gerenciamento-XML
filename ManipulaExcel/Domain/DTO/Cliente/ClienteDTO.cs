using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace safi_gerenciamento_xml.ManipulaExcel.Domain.DTO.Cliente
{
    public class ClienteDTO
    {
        public Guid id_Cliente {get;}
        public string? nome_Cliente {get; set;}
        public string? email_Cliente {get; set;}
        public Guid id_Contador {get; set;}

        public ClienteDTO(string nomeCliente, string emailCliente, Guid idContador)
        {
            nome_Cliente = nomeCliente;
            email_Cliente = emailCliente;
            id_Contador = idContador;
        }
    }
}