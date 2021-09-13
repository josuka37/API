using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Domínio
{
    public class Farmacia
    {
        [Key]
        public int Id { get; set; }
        public List<Medicamento> ListaMedicamentos { get; set; }
        public string Endereço { get; set; }
       
    }
}
