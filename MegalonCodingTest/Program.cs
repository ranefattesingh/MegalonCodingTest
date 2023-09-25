using Microsoft.EntityFrameworkCore;
using RaneFattesingh.Persistance.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CustomerContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
