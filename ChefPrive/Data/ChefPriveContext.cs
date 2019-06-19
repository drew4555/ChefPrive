using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Domain
{
    public class ChefPriveContext : DbContext
    {
        public ChefPriveContext (DbContextOptions<ChefPriveContext> options)
            : base(options)
        {
        }

        public DbSet<Domain.Client> Client { get; set; }
    }
}
