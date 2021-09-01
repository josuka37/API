using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Domínio
{
    public class Receita
    {
        public int Id { get; set; }
        public List<Medicamento> ListaMedicamento { get; set; }
        public Pessoa Pessoa { get; set; }
        public string NomeMédico { get; set; }
    }
}
