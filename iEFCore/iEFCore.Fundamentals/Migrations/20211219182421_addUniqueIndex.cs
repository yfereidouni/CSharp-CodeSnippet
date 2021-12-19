using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iEFCore.Fundamentals.Migrations
{
    public partial class addUniqueIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_tbl_People_FirstName_LastName",
                schema: "YFO",
                table: "tbl_People");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_People_FirstName_LastName",
                schema: "YFO",
                table: "tbl_People",
                columns: new[] { "FirstName", "LastName" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_tbl_People_FirstName_LastName",
                schema: "YFO",
                table: "tbl_People");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_People_FirstName_LastName",
                schema: "YFO",
                table: "tbl_People",
                columns: new[] { "FirstName", "LastName" });
        }
    }
}
