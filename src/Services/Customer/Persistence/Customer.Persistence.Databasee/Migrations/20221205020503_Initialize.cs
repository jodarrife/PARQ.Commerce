using Microsoft.EntityFrameworkCore.Migrations;

namespace Customer.Persistence.Databasee.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Customer");

            migrationBuilder.CreateTable(
                name: "Clients",
                schema: "Customer",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                });

            migrationBuilder.InsertData(
                schema: "Customer",
                table: "Clients",
                columns: new[] { "ClientId", "Name" },
                values: new object[,]
                {
                    { 1, "Nombre del cliente 1" },
                    { 73, "Nombre del cliente 73" },
                    { 72, "Nombre del cliente 72" },
                    { 71, "Nombre del cliente 71" },
                    { 70, "Nombre del cliente 70" },
                    { 69, "Nombre del cliente 69" },
                    { 68, "Nombre del cliente 68" },
                    { 67, "Nombre del cliente 67" },
                    { 66, "Nombre del cliente 66" },
                    { 65, "Nombre del cliente 65" },
                    { 64, "Nombre del cliente 64" },
                    { 63, "Nombre del cliente 63" },
                    { 62, "Nombre del cliente 62" },
                    { 61, "Nombre del cliente 61" },
                    { 60, "Nombre del cliente 60" },
                    { 59, "Nombre del cliente 59" },
                    { 58, "Nombre del cliente 58" },
                    { 57, "Nombre del cliente 57" },
                    { 56, "Nombre del cliente 56" },
                    { 55, "Nombre del cliente 55" },
                    { 54, "Nombre del cliente 54" },
                    { 53, "Nombre del cliente 53" },
                    { 74, "Nombre del cliente 74" },
                    { 52, "Nombre del cliente 52" },
                    { 75, "Nombre del cliente 75" },
                    { 77, "Nombre del cliente 77" },
                    { 98, "Nombre del cliente 98" },
                    { 97, "Nombre del cliente 97" },
                    { 96, "Nombre del cliente 96" },
                    { 95, "Nombre del cliente 95" },
                    { 94, "Nombre del cliente 94" },
                    { 93, "Nombre del cliente 93" },
                    { 92, "Nombre del cliente 92" },
                    { 91, "Nombre del cliente 91" },
                    { 90, "Nombre del cliente 90" },
                    { 89, "Nombre del cliente 89" },
                    { 88, "Nombre del cliente 88" },
                    { 87, "Nombre del cliente 87" },
                    { 86, "Nombre del cliente 86" },
                    { 85, "Nombre del cliente 85" },
                    { 84, "Nombre del cliente 84" },
                    { 83, "Nombre del cliente 83" }
                });

            migrationBuilder.InsertData(
                schema: "Customer",
                table: "Clients",
                columns: new[] { "ClientId", "Name" },
                values: new object[,]
                {
                    { 82, "Nombre del cliente 82" },
                    { 81, "Nombre del cliente 81" },
                    { 80, "Nombre del cliente 80" },
                    { 79, "Nombre del cliente 79" },
                    { 78, "Nombre del cliente 78" },
                    { 76, "Nombre del cliente 76" },
                    { 51, "Nombre del cliente 51" },
                    { 50, "Nombre del cliente 50" },
                    { 49, "Nombre del cliente 49" },
                    { 22, "Nombre del cliente 22" },
                    { 21, "Nombre del cliente 21" },
                    { 20, "Nombre del cliente 20" },
                    { 19, "Nombre del cliente 19" },
                    { 18, "Nombre del cliente 18" },
                    { 17, "Nombre del cliente 17" },
                    { 16, "Nombre del cliente 16" },
                    { 15, "Nombre del cliente 15" },
                    { 14, "Nombre del cliente 14" },
                    { 13, "Nombre del cliente 13" },
                    { 12, "Nombre del cliente 12" },
                    { 11, "Nombre del cliente 11" },
                    { 10, "Nombre del cliente 10" },
                    { 9, "Nombre del cliente 9" },
                    { 8, "Nombre del cliente 8" },
                    { 7, "Nombre del cliente 7" },
                    { 6, "Nombre del cliente 6" },
                    { 5, "Nombre del cliente 5" },
                    { 4, "Nombre del cliente 4" },
                    { 3, "Nombre del cliente 3" },
                    { 2, "Nombre del cliente 2" },
                    { 23, "Nombre del cliente 23" },
                    { 24, "Nombre del cliente 24" },
                    { 25, "Nombre del cliente 25" },
                    { 26, "Nombre del cliente 26" },
                    { 48, "Nombre del cliente 48" },
                    { 47, "Nombre del cliente 47" },
                    { 46, "Nombre del cliente 46" },
                    { 45, "Nombre del cliente 45" },
                    { 44, "Nombre del cliente 44" },
                    { 43, "Nombre del cliente 43" },
                    { 42, "Nombre del cliente 42" },
                    { 41, "Nombre del cliente 41" }
                });

            migrationBuilder.InsertData(
                schema: "Customer",
                table: "Clients",
                columns: new[] { "ClientId", "Name" },
                values: new object[,]
                {
                    { 40, "Nombre del cliente 40" },
                    { 39, "Nombre del cliente 39" },
                    { 99, "Nombre del cliente 99" },
                    { 38, "Nombre del cliente 38" },
                    { 36, "Nombre del cliente 36" },
                    { 35, "Nombre del cliente 35" },
                    { 34, "Nombre del cliente 34" },
                    { 33, "Nombre del cliente 33" },
                    { 32, "Nombre del cliente 32" },
                    { 31, "Nombre del cliente 31" },
                    { 30, "Nombre del cliente 30" },
                    { 29, "Nombre del cliente 29" },
                    { 28, "Nombre del cliente 28" },
                    { 27, "Nombre del cliente 27" },
                    { 37, "Nombre del cliente 37" },
                    { 100, "Nombre del cliente 100" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_ClientId",
                schema: "Customer",
                table: "Clients",
                column: "ClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients",
                schema: "Customer");
        }
    }
}
