using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Imobiliaria.Models;

namespace Imobiliaria.Data
{
    public class ImobiliariaContext : DbContext
    {
        public ImobiliariaContext (DbContextOptions<ImobiliariaContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Imobiliaria.Models.Lote>? Lote { get; set; }

        
    }
}
