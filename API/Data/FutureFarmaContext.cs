using API.Domínio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class FutureFarmaContext : DbContext
    {
        public DbSet<Medicamento> Medicamentos { get; set; }
        public DbSet<Receita> Receitas { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }



    }
}
