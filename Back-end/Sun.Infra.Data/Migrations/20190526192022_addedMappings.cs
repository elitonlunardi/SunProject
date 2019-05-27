using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sun.Infra.Data.Migrations
{
    public partial class addedMappings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weathers_Cities_CityId",
                table: "Weathers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Weathers",
                type: "DateTime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Minimum",
                table: "Weathers",
                type: "Float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "Maximum",
                table: "Weathers",
                type: "Float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Weathers",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Weathers",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<Guid>(
                name: "CityId",
                table: "Weathers",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Cities",
                type: "DateTime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cities",
                type: "VarChar",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Cities",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddForeignKey(
                name: "FK_Weathers_Cities_CityId",
                table: "Weathers",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weathers_Cities_CityId",
                table: "Weathers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Weathers",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Minimum",
                table: "Weathers",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "Float");

            migrationBuilder.AlterColumn<double>(
                name: "Maximum",
                table: "Weathers",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "Float");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Weathers",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Weathers",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");

            migrationBuilder.AlterColumn<Guid>(
                name: "CityId",
                table: "Weathers",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Cities",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cities",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Cities",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");

            migrationBuilder.AddForeignKey(
                name: "FK_Weathers_Cities_CityId",
                table: "Weathers",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
