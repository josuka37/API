using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Domínio
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public int Idade { get; set; }
        public bool Médico { get; set; }
    }
}
