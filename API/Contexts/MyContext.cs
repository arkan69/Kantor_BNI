using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Contexts
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }

        public DbSet<Pelanggan> Pelanggans { get; set; }
        public DbSet<SektorEkonomi> SektorEkonomis { get; set; }
        public DbSet<SubSE> SubSEs { get; set; }
        public DbSet<SubSubSE> SubSubSEs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pelanggan>().HasAlternateKey(p => p.NoHP);
            modelBuilder.Entity<Pelanggan>().HasAlternateKey(p => p.NoIdentitasPasangan);
        }
    }
}
