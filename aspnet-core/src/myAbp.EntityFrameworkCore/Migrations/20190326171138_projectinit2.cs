using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace myAbp.Migrations
{
    public partial class projectinit2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "FatherId",
                table: "Families",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "MotherId",
                table: "Families",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FatherId",
                table: "Families");

            migrationBuilder.DropColumn(
                name: "MotherId",
                table: "Families");
        }
    }
}
