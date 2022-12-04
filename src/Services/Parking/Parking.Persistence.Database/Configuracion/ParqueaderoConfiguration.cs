using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Parking.Domain;

namespace Parking.Persistence.Database.Configuracion
{
    public class ParqueaderoConfiguration
    {
        public ParqueaderoConfiguration(EntityTypeBuilder<Parqueadero> entityBuider)
        {
            entityBuider.HasIndex(x => x.Id);
            entityBuider.Property(x => x.Nombre).IsRequired().HasMaxLength(100);
            entityBuider.Property(x => x.Descripcion).IsRequired().HasMaxLength(100);

            // Parqueadero Por default
            //var parqueadero = new List<Parqueadero>();

           
        }
    }
}
