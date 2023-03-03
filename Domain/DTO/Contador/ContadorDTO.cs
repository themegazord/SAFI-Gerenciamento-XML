using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace safi_gerenciamento_xml.Domain.DTO.Contador
{
    public class ContadorDTO
    {
        [Key]
        public Guid? Id_Contador {get;}
        public string? Nome_Contador {get; set;}
        public string? Email_Contador {get; set;}

        public ContadorDTO(string nomeContador, string emailContador)
        {
            Nome_Contador = nomeContador;
            Email_Contador = emailContador;
        }
    }
}