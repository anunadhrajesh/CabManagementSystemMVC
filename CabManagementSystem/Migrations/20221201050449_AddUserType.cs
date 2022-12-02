using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CabManagementSystem.Migrations
{
    public partial class AddUserType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlightData");

            migrationBuilder.AddColumn<int>(
                name: "UserTypes",
                table: "AspNetUsers",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserTypes",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "FlightData",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlightName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlightNumber = table.Column<long>(type: "bigint", nullable: false),
                    FlightType = table.Column<int>(type: "int", nullable: false),
                    TotalCapacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightData", x => x.Id);
                });
        }
    }
}
