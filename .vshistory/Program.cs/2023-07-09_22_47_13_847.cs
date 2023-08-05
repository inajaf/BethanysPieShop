var builder = WebApplication.CreateBuilder(args);

builder.

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
