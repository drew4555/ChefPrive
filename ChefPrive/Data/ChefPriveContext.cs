using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ChefPrive.Models
{
    public class ChefPriveContext : DbContext
    {
        public ChefPriveContext (DbContextOptions<ChefPriveContext> options)
            : base(options)
        {
        }

        public DbSet<ChefPrive.Models.Client> Client { get; set; }
    }
}
