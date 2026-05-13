using Microsoft.EntityFrameworkCore;
using LifeHacksThatMakesItWorseAPI.Data.Context;
using LifeHacksThatMakesItWorseAPI.Data.AdviceRepo;
using LifeHacksThatMakesItWorseAPI.Data.Interfaces;
using LifeHacksThatMakesItWorseAPI.Core.Interfaces;
using LifeHacksThatMakesItWorseAPI.Core.Services;
using LifeHacksThatMakesItWorseAPI.Data.MockData;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IAdviceRepo, AdviceRepo>();
builder.Services.AddScoped<ILifeHackService, LifeHackService>();

var app = builder.Build();

using ( var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    await context.Database.MigrateAsync();
    await DataSeeder.SeedDataAsync(context);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();



app.Run();

