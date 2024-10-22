using Practica_Gorethi.Data.Repositories;
using Practica_Gorethi.Data;
using Practica_Gorethi.Bussines.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDBContext>(
        context =>
        {
            context.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection"));
        }
    );
//inyectar repositorios

builder.Services.AddScoped<BookRepository>();
builder.Services.AddScoped<AutorRepository>();

//inyectar el servicios
builder.Services.AddScoped<IBookService, BookServiceImpl>();

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
