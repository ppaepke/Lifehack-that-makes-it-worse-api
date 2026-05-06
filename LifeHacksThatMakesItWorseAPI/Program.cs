var builder = WebApplication.CreateBuilder(args);
/*
    kommmentarer som kommen skap konflikter i git









Hola
ö
















    Ta bort detta vid konfliikten 

    


*/
// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();



app.Run();

