using MicroserviciosPerros.Bussines.Services;
using MicroserviciosPerros.Data;
using MicroserviciosPerros.Data.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

/*Preparar inyeccion*/

var ConnectionString = Environment.GetEnvironmentVariable("CONN_STR");
builder.Services.AddDbContext<AppDBContext>(
    contexto =>
    {
        contexto.UseMySQL(ConnectionString ??
            builder.Configuration.GetConnectionString("DefaultConnection") ?? "");
    });
/*INYECTAR REPOSITORIO*/
builder.Services.AddScoped<DogRepository>();

/*inyectar servicio*/
builder.Services.AddScoped<IDogService, DogServiceImpl>();
/*Allow origins*/
builder.Services.AddCors(
    options =>
    {
        options.AddPolicy(name: "AlowAny",
            configurePolicy: policy =>
            {
                policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
            });
    }
    );
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();
/*Active cors*/
app.UseCors("AllowAny");

app.Run();
