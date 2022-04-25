using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iEFCore.ComputedColumn.Migrations
{
    public partial class addDefaultValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "People",
                type: "int",
                nullable: false,
                defaultValue: 100);

            migrationBuilder.AddColumn<DateTime>(
                name: "RegisterDate",
                table: "People",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GetDate()");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "People");

            migrationBuilder.DropColumn(
                name: "RegisterDate",
                table: "People");
        }
    }
}
