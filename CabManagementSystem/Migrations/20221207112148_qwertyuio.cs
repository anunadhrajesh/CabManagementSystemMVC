using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CabManagementSystem.Migrations
{
    public partial class qwertyuio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarModel",
                table: "DriverDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarModel",
                table: "DriverDetails");
        }
    }
}
