using Microsoft.EntityFrameworkCore;
using QuinceaneraEvents.Backend.Data;

var builder = WebApplication.CreateBuilder(args);

//Configuracion de la conexion a la base de datos PostgresSQL
var connectionsString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionsString));

//prueba temporal de conexion
//builder.Services.AddHealthChecks().AddDbContextCheck<AppDbContext>();

//Servicios
builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

//app.MapHealthChecks("/health/database");

app.MapControllers();

app.Run();
