using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AnahiQuezada_EjecicioCF.Models;

namespace BurgerCF.Data
{
    public class BurgerCFContext : DbContext
    {
        public BurgerCFContext (DbContextOptions<BurgerCFContext> options)
            : base(options)
        {
        }

        public DbSet<AnahiQuezada_EjecicioCF.Models.Burger> Burger { get; set; } = default!;
    }
}
