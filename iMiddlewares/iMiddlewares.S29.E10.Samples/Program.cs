using iMiddlewares.S29.E10.Samples;

var builder = WebApplication.CreateBuilder(args);

var app = builder.ConfigureServices().ConfigurePipeLine();

app.Run();
