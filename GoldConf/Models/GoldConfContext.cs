using GoldConf.Models.Maps;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldConf.Models
{
    public class GoldConfContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Conferencia> Conferencias { get; set; }
        public DbSet<Ponente> Ponentes { get; set; }
        public DbSet<Comprar> Compras { get; set; }

        public GoldConfContext(DbContextOptions<GoldConfContext> options)
           : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Esto se hace por cada tabla de base de datos
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new ConferenciaMap());
            modelBuilder.ApplyConfiguration(new PonenteMap());
            modelBuilder.ApplyConfiguration(new ComprarMap());

        }
    }
}
