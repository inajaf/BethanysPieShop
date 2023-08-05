var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

if ()
app.UseDeveloperExceptionPage();

app.Run();
