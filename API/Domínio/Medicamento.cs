using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace API.Domínio
{
    public class Medicamento
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeComercial { get; set; }
        public string PrincipioAtivo { get; set; }
        public double ConcentracaoMg { get; set; }
        public bool HumanoOuPet { get; set; }
        public bool Restrito { get; set; }
    }
}
