using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Minicore_Rivadeneira.Models
{
    public class miniCoreDBContext : DbContext
    {
        public DbSet<Pase> Pases { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}