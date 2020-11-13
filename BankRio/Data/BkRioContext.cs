using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BankRio.Models;
using BankRio.Models;

namespace BankRio.Data
{
    public class BkRioContext : DbContext
    {
        public BkRioContext(DbContextOptions<BkRioContext> options) 
            : base(options)
        {

        }

        public DbSet<Advisor> Advisor{ get; set; }
        public DbSet<Product> Product { get; set; }
    }
}

