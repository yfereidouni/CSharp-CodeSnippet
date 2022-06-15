var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

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

//This Middleware
app.UseCors(c =>
{
    c.AllowAnyOrigin();              // Any Origin
    c.WithOrigins(new[] { "", "" }); // Specific Origin
    c.AllowAnyHeader();              // Any Header   
    c.WithHeaders(new[] { "", "" }); // Specific Header
    c.AllowAnyMethod();              // Any Method
    c.WithMethods(new[] { "", "" }); // Specific Method
});

app.UseAuthorization();

app.MapControllers();

app.Run();
