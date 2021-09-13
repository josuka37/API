using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace API.Domínio
{
    public class Receita
    {
        [Key]
        public int Id { get; set; }
        public List<Medicamento> ListaMedicamento { get; set; }
        public Pessoa Pessoa { get; set; }
        public string NomeMédico { get; set; }
    }
}
