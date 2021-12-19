using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iEFCore.Fundamentals.Migrations
{
    public partial class addIndexes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_tbl_People_FirstName_LastName",
                schema: "YFO",
                table: "tbl_People",
                columns: new[] { "FirstName", "LastName" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_tbl_People_FirstName_LastName",
                schema: "YFO",
                table: "tbl_People");
        }
    }
}
