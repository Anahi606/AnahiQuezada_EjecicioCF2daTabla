using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AnahiQuezada_EjecicioCF.Models;

namespace AnahiQuezada_EjecicioCF.Data
{
    public class AnahiQuezada_EjecicioCFContext : DbContext
    {
        public AnahiQuezada_EjecicioCFContext (DbContextOptions<AnahiQuezada_EjecicioCFContext> options)
            : base(options)
        {
        }

        public DbSet<AnahiQuezada_EjecicioCF.Models.Burger> Burger { get; set; } = default!;
        public DbSet<AnahiQuezada_EjecicioCF.Models.Promo> Promo { get; set; } = default!;
    }
}
