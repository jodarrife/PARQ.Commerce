﻿// <auto-generated />
using Customer.Persistence.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Customer.Persistence.Databasee.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Customer")
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Customer.Domain.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ClientId");

                    b.HasIndex("ClientId");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            ClientId = 1,
                            Name = "Nombre del cliente 1"
                        },
                        new
                        {
                            ClientId = 2,
                            Name = "Nombre del cliente 2"
                        },
                        new
                        {
                            ClientId = 3,
                            Name = "Nombre del cliente 3"
                        },
                        new
                        {
                            ClientId = 4,
                            Name = "Nombre del cliente 4"
                        },
                        new
                        {
                            ClientId = 5,
                            Name = "Nombre del cliente 5"
                        },
                        new
                        {
                            ClientId = 6,
                            Name = "Nombre del cliente 6"
                        },
                        new
                        {
                            ClientId = 7,
                            Name = "Nombre del cliente 7"
                        },
                        new
                        {
                            ClientId = 8,
                            Name = "Nombre del cliente 8"
                        },
                        new
                        {
                            ClientId = 9,
                            Name = "Nombre del cliente 9"
                        },
                        new
                        {
                            ClientId = 10,
                            Name = "Nombre del cliente 10"
                        },
                        new
                        {
                            ClientId = 11,
                            Name = "Nombre del cliente 11"
                        },
                        new
                        {
                            ClientId = 12,
                            Name = "Nombre del cliente 12"
                        },
                        new
                        {
                            ClientId = 13,
                            Name = "Nombre del cliente 13"
                        },
                        new
                        {
                            ClientId = 14,
                            Name = "Nombre del cliente 14"
                        },
                        new
                        {
                            ClientId = 15,
                            Name = "Nombre del cliente 15"
                        },
                        new
                        {
                            ClientId = 16,
                            Name = "Nombre del cliente 16"
                        },
                        new
                        {
                            ClientId = 17,
                            Name = "Nombre del cliente 17"
                        },
                        new
                        {
                            ClientId = 18,
                            Name = "Nombre del cliente 18"
                        },
                        new
                        {
                            ClientId = 19,
                            Name = "Nombre del cliente 19"
                        },
                        new
                        {
                            ClientId = 20,
                            Name = "Nombre del cliente 20"
                        },
                        new
                        {
                            ClientId = 21,
                            Name = "Nombre del cliente 21"
                        },
                        new
                        {
                            ClientId = 22,
                            Name = "Nombre del cliente 22"
                        },
                        new
                        {
                            ClientId = 23,
                            Name = "Nombre del cliente 23"
                        },
                        new
                        {
                            ClientId = 24,
                            Name = "Nombre del cliente 24"
                        },
                        new
                        {
                            ClientId = 25,
                            Name = "Nombre del cliente 25"
                        },
                        new
                        {
                            ClientId = 26,
                            Name = "Nombre del cliente 26"
                        },
                        new
                        {
                            ClientId = 27,
                            Name = "Nombre del cliente 27"
                        },
                        new
                        {
                            ClientId = 28,
                            Name = "Nombre del cliente 28"
                        },
                        new
                        {
                            ClientId = 29,
                            Name = "Nombre del cliente 29"
                        },
                        new
                        {
                            ClientId = 30,
                            Name = "Nombre del cliente 30"
                        },
                        new
                        {
                            ClientId = 31,
                            Name = "Nombre del cliente 31"
                        },
                        new
                        {
                            ClientId = 32,
                            Name = "Nombre del cliente 32"
                        },
                        new
                        {
                            ClientId = 33,
                            Name = "Nombre del cliente 33"
                        },
                        new
                        {
                            ClientId = 34,
                            Name = "Nombre del cliente 34"
                        },
                        new
                        {
                            ClientId = 35,
                            Name = "Nombre del cliente 35"
                        },
                        new
                        {
                            ClientId = 36,
                            Name = "Nombre del cliente 36"
                        },
                        new
                        {
                            ClientId = 37,
                            Name = "Nombre del cliente 37"
                        },
                        new
                        {
                            ClientId = 38,
                            Name = "Nombre del cliente 38"
                        },
                        new
                        {
                            ClientId = 39,
                            Name = "Nombre del cliente 39"
                        },
                        new
                        {
                            ClientId = 40,
                            Name = "Nombre del cliente 40"
                        },
                        new
                        {
                            ClientId = 41,
                            Name = "Nombre del cliente 41"
                        },
                        new
                        {
                            ClientId = 42,
                            Name = "Nombre del cliente 42"
                        },
                        new
                        {
                            ClientId = 43,
                            Name = "Nombre del cliente 43"
                        },
                        new
                        {
                            ClientId = 44,
                            Name = "Nombre del cliente 44"
                        },
                        new
                        {
                            ClientId = 45,
                            Name = "Nombre del cliente 45"
                        },
                        new
                        {
                            ClientId = 46,
                            Name = "Nombre del cliente 46"
                        },
                        new
                        {
                            ClientId = 47,
                            Name = "Nombre del cliente 47"
                        },
                        new
                        {
                            ClientId = 48,
                            Name = "Nombre del cliente 48"
                        },
                        new
                        {
                            ClientId = 49,
                            Name = "Nombre del cliente 49"
                        },
                        new
                        {
                            ClientId = 50,
                            Name = "Nombre del cliente 50"
                        },
                        new
                        {
                            ClientId = 51,
                            Name = "Nombre del cliente 51"
                        },
                        new
                        {
                            ClientId = 52,
                            Name = "Nombre del cliente 52"
                        },
                        new
                        {
                            ClientId = 53,
                            Name = "Nombre del cliente 53"
                        },
                        new
                        {
                            ClientId = 54,
                            Name = "Nombre del cliente 54"
                        },
                        new
                        {
                            ClientId = 55,
                            Name = "Nombre del cliente 55"
                        },
                        new
                        {
                            ClientId = 56,
                            Name = "Nombre del cliente 56"
                        },
                        new
                        {
                            ClientId = 57,
                            Name = "Nombre del cliente 57"
                        },
                        new
                        {
                            ClientId = 58,
                            Name = "Nombre del cliente 58"
                        },
                        new
                        {
                            ClientId = 59,
                            Name = "Nombre del cliente 59"
                        },
                        new
                        {
                            ClientId = 60,
                            Name = "Nombre del cliente 60"
                        },
                        new
                        {
                            ClientId = 61,
                            Name = "Nombre del cliente 61"
                        },
                        new
                        {
                            ClientId = 62,
                            Name = "Nombre del cliente 62"
                        },
                        new
                        {
                            ClientId = 63,
                            Name = "Nombre del cliente 63"
                        },
                        new
                        {
                            ClientId = 64,
                            Name = "Nombre del cliente 64"
                        },
                        new
                        {
                            ClientId = 65,
                            Name = "Nombre del cliente 65"
                        },
                        new
                        {
                            ClientId = 66,
                            Name = "Nombre del cliente 66"
                        },
                        new
                        {
                            ClientId = 67,
                            Name = "Nombre del cliente 67"
                        },
                        new
                        {
                            ClientId = 68,
                            Name = "Nombre del cliente 68"
                        },
                        new
                        {
                            ClientId = 69,
                            Name = "Nombre del cliente 69"
                        },
                        new
                        {
                            ClientId = 70,
                            Name = "Nombre del cliente 70"
                        },
                        new
                        {
                            ClientId = 71,
                            Name = "Nombre del cliente 71"
                        },
                        new
                        {
                            ClientId = 72,
                            Name = "Nombre del cliente 72"
                        },
                        new
                        {
                            ClientId = 73,
                            Name = "Nombre del cliente 73"
                        },
                        new
                        {
                            ClientId = 74,
                            Name = "Nombre del cliente 74"
                        },
                        new
                        {
                            ClientId = 75,
                            Name = "Nombre del cliente 75"
                        },
                        new
                        {
                            ClientId = 76,
                            Name = "Nombre del cliente 76"
                        },
                        new
                        {
                            ClientId = 77,
                            Name = "Nombre del cliente 77"
                        },
                        new
                        {
                            ClientId = 78,
                            Name = "Nombre del cliente 78"
                        },
                        new
                        {
                            ClientId = 79,
                            Name = "Nombre del cliente 79"
                        },
                        new
                        {
                            ClientId = 80,
                            Name = "Nombre del cliente 80"
                        },
                        new
                        {
                            ClientId = 81,
                            Name = "Nombre del cliente 81"
                        },
                        new
                        {
                            ClientId = 82,
                            Name = "Nombre del cliente 82"
                        },
                        new
                        {
                            ClientId = 83,
                            Name = "Nombre del cliente 83"
                        },
                        new
                        {
                            ClientId = 84,
                            Name = "Nombre del cliente 84"
                        },
                        new
                        {
                            ClientId = 85,
                            Name = "Nombre del cliente 85"
                        },
                        new
                        {
                            ClientId = 86,
                            Name = "Nombre del cliente 86"
                        },
                        new
                        {
                            ClientId = 87,
                            Name = "Nombre del cliente 87"
                        },
                        new
                        {
                            ClientId = 88,
                            Name = "Nombre del cliente 88"
                        },
                        new
                        {
                            ClientId = 89,
                            Name = "Nombre del cliente 89"
                        },
                        new
                        {
                            ClientId = 90,
                            Name = "Nombre del cliente 90"
                        },
                        new
                        {
                            ClientId = 91,
                            Name = "Nombre del cliente 91"
                        },
                        new
                        {
                            ClientId = 92,
                            Name = "Nombre del cliente 92"
                        },
                        new
                        {
                            ClientId = 93,
                            Name = "Nombre del cliente 93"
                        },
                        new
                        {
                            ClientId = 94,
                            Name = "Nombre del cliente 94"
                        },
                        new
                        {
                            ClientId = 95,
                            Name = "Nombre del cliente 95"
                        },
                        new
                        {
                            ClientId = 96,
                            Name = "Nombre del cliente 96"
                        },
                        new
                        {
                            ClientId = 97,
                            Name = "Nombre del cliente 97"
                        },
                        new
                        {
                            ClientId = 98,
                            Name = "Nombre del cliente 98"
                        },
                        new
                        {
                            ClientId = 99,
                            Name = "Nombre del cliente 99"
                        },
                        new
                        {
                            ClientId = 100,
                            Name = "Nombre del cliente 100"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
