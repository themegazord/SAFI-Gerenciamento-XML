using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Cassandra.Data.Linq;

namespace safi_gerenciamento_xml.Domain.DTO.Contador
{
    public class ContadorDTO
    {
        public Guid id_Contador {get;}
        public string? nome_Contador {get; set;}
        public string? email_Contador {get; set;}

        public ContadorDTO(string nomeContador, string emailContador)
        {
            nome_Contador = nomeContador;
            email_Contador = emailContador;
        }
    }
}