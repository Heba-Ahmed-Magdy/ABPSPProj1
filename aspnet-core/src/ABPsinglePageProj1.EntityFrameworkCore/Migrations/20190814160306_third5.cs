using Microsoft.EntityFrameworkCore.Migrations;

namespace ABPsinglePageProj1.Migrations
{
    public partial class third5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ExtensionData",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExtensionData",
                table: "Employees");
        }
    }
}
