using System;
using Microsoft.EntityFrameworkCore;
using Parking.Domain;
using Parking.Persistence.Database.Configuracion;

namespace Parking.Persistence.Database
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options): base(options) { }

        public DbSet<Parqueadero> Parqueadero { get; set; }
        public DbSet<Bahia> Bahias { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Esquema
            modelBuilder.HasDefaultSchema("Parking");
            ModelConfig(modelBuilder);
        }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new ParqueaderoConfiguration(modelBuilder.Entity<Parqueadero>());
        }

    }
}
