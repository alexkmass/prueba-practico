using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPractico
{
    public class Context : DbContext
    {
        public DbSet<Team> teams { get; set; }
        public DbSet<Player> players { get; set; }
    }
}
