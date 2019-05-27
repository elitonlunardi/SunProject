using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sun.Infra.Data.Migrations
{
    public partial class FieldsCorrections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdCity",
                table: "Weathers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "IdCity",
                table: "Weathers",
                nullable: true);
        }
    }
}
