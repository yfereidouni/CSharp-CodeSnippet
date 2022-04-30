using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iEFCore.S25.E05.EFMigrations.Migrations;

public partial class addFullName : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<string>
            (
            name: "FullName",
            table: "People",
            nullable: true);

        migrationBuilder.Sql("UPDATE People SET Fullname = Firstname + ' ' + LastName");

        migrationBuilder.DropColumn(
            name: "FirstName",
            table: "People");

        migrationBuilder.DropColumn(
            name: "LastName",
            table: "People");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "FullName",
            table: "People");

        migrationBuilder.AddColumn<string>(
            name: "FirstName",
            table: "People");

        migrationBuilder.AddColumn<string>(
            name: "LastName",
            table: "People");
    }
}
