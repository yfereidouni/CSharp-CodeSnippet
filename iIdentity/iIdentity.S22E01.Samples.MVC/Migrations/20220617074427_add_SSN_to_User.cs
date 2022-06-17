using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iIdentity.S22E01.Samples.MVC.Migrations
{
    public partial class add_SSN_to_User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SSN",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SSN",
                table: "AspNetUsers");
        }
    }
}
