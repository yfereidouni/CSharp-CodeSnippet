using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iEFCore.Configurations.Migrations
{
    public partial class backingFieldConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                schema: "dbo",
                table: "BackingFieldSamples",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                schema: "dbo",
                table: "BackingFieldSamples");
        }
    }
}
