using iCourseStore.YFereidouni.DAL.CourseStoreDB;
using iCourseStore.YFereidouni.DAL.Framework;
using Microsoft.EntityFrameworkCore;
using MediatR;
using iCourseStore.YFereidouni.BLL.Tags.Commands;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<CourseStoreDbContext>(c => c.UseSqlServer("Server =.; Initial Catalog = S27E02.YF.iCourseStore_DB; User Id = dbuser; Password = 1qaz!QAZ;")
.AddInterceptors(new AddAuditFieldInterceptor()));

builder.Services.AddMediatR(typeof(CreateTagHandler).Assembly);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
