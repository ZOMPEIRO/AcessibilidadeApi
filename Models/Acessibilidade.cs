using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoTCC.Models
{
    public class Acessibilidade
    {
        [Key]
        public int idAcessibilidade { get; set; }

        public int idUsuario { get; set; }

        public bool modoContraste { get; set; }

        public string tamanhoFonte { get; set; }

        public bool alertaSonoro { get; set; }  

        public bool vibração { get; set; }  
        
    }
}