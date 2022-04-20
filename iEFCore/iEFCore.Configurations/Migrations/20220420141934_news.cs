using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iEFCore.Configurations.Migrations
{
    public partial class news : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "ReadOnlyFluent",
                newName: "ReadOnlyFluent",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "ReadOnlyAttributes",
                newName: "ReadOnlyAttributes",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "PrimaryKeyFluents",
                newName: "PrimaryKeyFluents",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "PrimaryKeyAttributes",
                newName: "PrimaryKeyAttributes",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "IndexUsingFluentAPIs",
                newName: "IndexUsingFluentAPIs",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "IndexUsingAttributes",
                newName: "IndexUsingAttributes",
                newSchema: "dbo");

            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "dbo",
                table: "tbl_People",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "Family",
                schema: "dbo",
                table: "tbl_People",
                newName: "LastName");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                schema: "dbo",
                table: "tbl_People",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                schema: "dbo",
                table: "tbl_People",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "News",
                schema: "dbo",
                columns: table => new
                {
                    NewsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.NewsId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "News",
                schema: "dbo");

            migrationBuilder.RenameTable(
                name: "ReadOnlyFluent",
                schema: "dbo",
                newName: "ReadOnlyFluent");

            migrationBuilder.RenameTable(
                name: "ReadOnlyAttributes",
                schema: "dbo",
                newName: "ReadOnlyAttributes");

            migrationBuilder.RenameTable(
                name: "PrimaryKeyFluents",
                schema: "dbo",
                newName: "PrimaryKeyFluents");

            migrationBuilder.RenameTable(
                name: "PrimaryKeyAttributes",
                schema: "dbo",
                newName: "PrimaryKeyAttributes");

            migrationBuilder.RenameTable(
                name: "IndexUsingFluentAPIs",
                schema: "dbo",
                newName: "IndexUsingFluentAPIs");

            migrationBuilder.RenameTable(
                name: "IndexUsingAttributes",
                schema: "dbo",
                newName: "IndexUsingAttributes");

            migrationBuilder.RenameColumn(
                name: "LastName",
                schema: "dbo",
                table: "tbl_People",
                newName: "Family");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                schema: "dbo",
                table: "tbl_People",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Family",
                schema: "dbo",
                table: "tbl_People",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "tbl_People",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
