using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iEFCore.Fundamentals.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "YFO");

            migrationBuilder.CreateTable(
                name: "tbl_People",
                schema: "YFO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Contacts",
                schema: "YFO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_Contacts_tbl_People_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "YFO",
                        principalTable: "tbl_People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Contacts_PersonId",
                schema: "YFO",
                table: "tbl_Contacts",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Contacts",
                schema: "YFO");

            migrationBuilder.DropTable(
                name: "tbl_People",
                schema: "YFO");
        }
    }
}
