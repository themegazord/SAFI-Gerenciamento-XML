using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Cassandra.Mapping.Attributes;

namespace safi_gerenciamento_xml.ManipulaExcel.Domain.DTO.Contador
{
    public class Contadores
    {
        [PartitionKey]
        public Guid id_Contador {get; private set;}
        public string nome_Contador {get; set;}
        public string email_Contador {get; set;}

        public Contadores(string nomeContador, string emailContador)
        {
            id_Contador = Guid.NewGuid();
            nome_Contador = nomeContador;
            email_Contador = emailContador;
        }
    }
}