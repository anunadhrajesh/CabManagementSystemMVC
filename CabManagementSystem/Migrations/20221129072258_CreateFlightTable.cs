using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CabManagementSystem.Migrations
{
    public partial class CreateFlightTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FlightData",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightNumber = table.Column<long>(type: "bigint", nullable: false),
                    FlightName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlightType = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalCapacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightData", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlightData");
        }
    }
}
