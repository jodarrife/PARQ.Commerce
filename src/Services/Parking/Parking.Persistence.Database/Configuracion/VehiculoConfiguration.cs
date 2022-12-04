using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Parking.Domain;

namespace Parking.Persistence.Database.Configuracion
{
    public class VehiculoConfiguration
    {
        public VehiculoConfiguration(EntityTypeBuilder<Vehiculo> entityBuider)
        {
            entityBuider.HasIndex(x => x.Id);
            entityBuider.Property(x => x.Marca).IsRequired().HasMaxLength(100);
            entityBuider.Property(x => x.Tipo).IsRequired().HasMaxLength(100);
            entityBuider.Property(x => x.Placa).IsRequired().HasMaxLength(100);
        }
    }
}
