using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
{
    public class APIContext : DbContext
    {
       public DbSet<User> users { get; set; }
        public APIContext
            (DbContextOptions<APIContext>options) : base(options)
        {

        }
    }
}
