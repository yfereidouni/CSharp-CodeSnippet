using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iEFCore.S23.E13.Sequence.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateSequence(
                name: "SampleSeq",
                schema: "dbo",
                startValue: 101L,
                incrementBy: 20,
                minValue: 100L,
                maxValue: 2000L,
                cyclic: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropSequence(
                name: "SampleSeq",
                schema: "dbo");
        }
    }
}
