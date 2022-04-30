using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Migrations.Operations.Builders;

namespace iEFCore.S25.E05.EFMigrations.MyMigrationOperation;

public class CreateUserOperation : MigrationOperation
{
    public string UserName { get; set; }
    public string Password { get; set; }
}

public static class EFExtension
{
    public static OperationBuilder<CreateUserOperation> CreateUser(this MigrationBuilder migrationBuilder, string userName, string password)
    {
        var operation = new CreateUserOperation
        {
            UserName = userName,
            Password = password,
        };
        migrationBuilder.Operations.Add(operation);
        return new OperationBuilder<CreateUserOperation>(operation);
    }
}

public class MySqlMigrationgenerator : SqlServerMigrationsSqlGenerator
{
    public MySqlMigrationgenerator(MigrationsSqlGeneratorDependencies dependencies, IRelationalAnnotationProvider migrationsAnnotations) : base(dependencies, migrationsAnnotations)
    {
    }
    protected override void Generate(MigrationOperation operation, IModel? model, MigrationCommandListBuilder builder)
    {
        if (operation is CreateUserOperation createUserOperation)
        {

        }
        else
        {
            base.Generate(operation, model, builder);
        }
    }
}
