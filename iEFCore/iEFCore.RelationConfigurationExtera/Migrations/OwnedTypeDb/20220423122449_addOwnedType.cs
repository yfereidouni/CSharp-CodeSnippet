using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iEFCore.RelationConfigurationExtera.Migrations.OwnedTypeDb
{
    public partial class addOwnedType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_Street = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    CarName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_Cars_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Money",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Money", x => new { x.PersonId, x.Id });
                    table.ForeignKey(
                        name: "FK_Money_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "FirstName", "LastName", "Address_City", "Address_Street" },
                values: new object[] { 1, "Yasser", "Fereidouni", "Karaj", "1st Dehghanvilla" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "PersonId", "CarName" },
                values: new object[] { 1, "Persia" });

            migrationBuilder.InsertData(
                table: "Money",
                columns: new[] { "Id", "PersonId", "Value" },
                values: new object[] { 1, 1, 1000 });

            migrationBuilder.InsertData(
                table: "Money",
                columns: new[] { "Id", "PersonId", "Value" },
                values: new object[] { 2, 1, 5000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Money");

            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
