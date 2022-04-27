using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iEFCore.S24.E11.FromSQLInterpolated.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 1, "Yasser", "Fereidouni" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 2, "Alireza", "Oroumand" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
