using Microsoft.EntityFrameworkCore;
using LifeHacksThatMakesItWorseAPI.Data.Context;
using LifeHacksThatMakesItWorseAPI.Data.AdviceRepo;
using LifeHacksThatMakesItWorseAPI.Data.Interfaces;
/*
    Konflikt i main

    
*/

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IAdviceRepo, AdviceRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();



app.Run();

