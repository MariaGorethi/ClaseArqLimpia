using Microsoft.EntityFrameworkCore;
using ReservacionesRestFul.Bussines.Services;
using ReservacionesRestFul.Data;
using ReservacionesRestFul.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//inyectar contexto de BD (Crear el objeto en tiempo de ejecucion)
builder.Services.AddDbContext<AppDBContext>(
        context =>
        {
            context.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection"));
        }
    );
//inyectar repositorios

builder.Services.AddScoped<UserRepository>();
builder.Services.AddScoped<RoomRepository>();
builder.Services.AddScoped<ReservationRepository>();

//inyectar el servicios
builder.Services.AddScoped<IReservationService, ReservationServiceImpl>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
