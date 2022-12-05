using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Parking.Domain.Models;

namespace Parking.Persistence.Database.Configuracion
{
    public class BahiaConfiguration
    {
        public BahiaConfiguration(EntityTypeBuilder<Bahia> entityBuider)
        {
            entityBuider.HasIndex(x => x.Id);
            entityBuider.Property(x => x.Nombre).IsRequired().HasMaxLength(100);
            entityBuider.Property(x => x.Disponible).IsRequired().HasMaxLength(100);
        }
    }
}
