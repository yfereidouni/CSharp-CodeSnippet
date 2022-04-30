using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Migrations.Operations.Builders;

namespace iEFCore.S25.E05.EFMigrations.Migrations;

public static class EFExtension
{
    public static OperationBuilder<SqlOperation> CreateUser(this MigrationBuilder migrationBuilder, string userName, string password)
    {
        return migrationBuilder.Sql($"CREATE User {userName} WITH PASSWORD '{password}'");
    }
}

public partial class addUsers : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateUser("User01", "1qaz!QAZ");
        migrationBuilder.CreateUser("User02", "1qaz!QAZ");
        migrationBuilder.CreateUser("User03", "1qaz!QAZ");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {

    }
}
