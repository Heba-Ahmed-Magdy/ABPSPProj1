using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ABPsinglePageProj1.Migrations
{
    public partial class third2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Employees",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Employees");
        }
    }
}
