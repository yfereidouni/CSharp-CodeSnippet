using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iEFCore.Configurations.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "IndexUsingAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndexUsingAttributes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IndexUsingFluentAPIs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Filtered = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndexUsingFluentAPIs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrimaryKeyAttributes",
                columns: table => new
                {
                    MyPrimaryKey = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrimaryKeyAttributes", x => x.MyPrimaryKey);
                });

            migrationBuilder.CreateTable(
                name: "PrimaryKeyFluents",
                columns: table => new
                {
                    Pk01 = table.Column<int>(type: "int", nullable: false),
                    Pk02 = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrimaryKeyFluents", x => new { x.Pk01, x.Pk02 });
                });

            migrationBuilder.CreateTable(
                name: "ReadOnlyAttributes",
                columns: table => new
                {
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ReadOnlyFluent",
                columns: table => new
                {
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_People",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Family = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Contact",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Contact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Contact_tbl_People_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "dbo",
                        principalTable: "tbl_People",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Name_USING_ATTRIBUTE",
                table: "IndexUsingAttributes",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Name_USING_FLUENT",
                table: "IndexUsingFluentAPIs",
                column: "Name",
                unique: true,
                filter: "[Filtered] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Contact_PersonId",
                schema: "dbo",
                table: "tbl_Contact",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IndexUsingAttributes");

            migrationBuilder.DropTable(
                name: "IndexUsingFluentAPIs");

            migrationBuilder.DropTable(
                name: "PrimaryKeyAttributes");

            migrationBuilder.DropTable(
                name: "PrimaryKeyFluents");

            migrationBuilder.DropTable(
                name: "ReadOnlyAttributes");

            migrationBuilder.DropTable(
                name: "ReadOnlyFluent");

            migrationBuilder.DropTable(
                name: "tbl_Contact",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tbl_People",
                schema: "dbo");
        }
    }
}
