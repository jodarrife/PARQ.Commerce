
using Customer.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Persistence.Database.Configuration
{
    public class ClientConfiguration
    {
        public ClientConfiguration(EntityTypeBuilder<Client> entityBuilder)
        {
            entityBuilder.HasIndex(e => e.ClientId);
            entityBuilder.Property(e => e.Name).IsRequired().HasMaxLength(100);

            //creacion de los clientes
            var clientes = new List<Client>();
            for (int i = 1; i <= 100; i++)
            {
                clientes.Add(new Client
                {
                    ClientId = i,
                    Name = $"Nombre del cliente {i}",
                });
            }

            entityBuilder.HasData(clientes);
        }
    }
}
