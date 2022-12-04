using Microsoft.EntityFrameworkCore.Migrations;

namespace Parking.Persistence.Database.Migrations
{
    public partial class Initializable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Parking");

            migrationBuilder.CreateTable(
                name: "Parqueadero",
                schema: "Parking",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parqueadero", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                schema: "Parking",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca = table.Column<string>(nullable: true),
                    Tipo = table.Column<string>(nullable: true),
                    Placa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bahias",
                schema: "Parking",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Disponible = table.Column<string>(nullable: true),
                    ParqueaderoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bahias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bahias_Parqueadero_ParqueaderoId",
                        column: x => x.ParqueaderoId,
                        principalSchema: "Parking",
                        principalTable: "Parqueadero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bahias_ParqueaderoId",
                schema: "Parking",
                table: "Bahias",
                column: "ParqueaderoId");

            migrationBuilder.CreateIndex(
                name: "IX_Parqueadero_Id",
                schema: "Parking",
                table: "Parqueadero",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bahias",
                schema: "Parking");

            migrationBuilder.DropTable(
                name: "Vehiculos",
                schema: "Parking");

            migrationBuilder.DropTable(
                name: "Parqueadero",
                schema: "Parking");
        }
    }
}
