using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChargerInfo.API.Entities
{
    public class ChargerInfoContext : DbContext
    {
        public ChargerInfoContext(DbContextOptions<ChargerInfoContext> Options)
            : base(Options)
            {
               Database.Migrate();
            }
     public DbSet<Charger> chargers { get; set; }
      public DbSet<Session> sessions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Charger>()                .Property(n => n.chargerStationType).HasMaxLength(50)                .IsRequired();
            modelBuilder.Entity<Charger>()
               .Property(n => n.powerInVolt).HasMaxLength(50)
               .IsRequired();
            modelBuilder.Entity<Session>()
               .Property(n => n.status).HasMaxLength(7)
               .IsRequired();  

        }
    }
}
