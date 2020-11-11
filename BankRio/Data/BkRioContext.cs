using BankRio.Models;
using Microsoft.EntityFrameworkCore;

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

