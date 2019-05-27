using Microsoft.EntityFrameworkCore.Migrations;

namespace Sun.Infra.Data.Migrations
{
    public partial class maxlengthAdjust : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cities",
                type: "varchar(100)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VarChar",
                oldMaxLength: 150);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cities",
                type: "VarChar",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 150);
        }
    }
}
