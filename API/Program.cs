using API.Services;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(optionsBuilder =>
    optionsBuilder.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddScoped<ICoffeeShopService, CoffeeShopService>();

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();
