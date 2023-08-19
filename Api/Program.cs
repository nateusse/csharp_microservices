using Services.Interfaces;
using Services.Services;
using Infrastructure.Data;
using Infrastructure.Infrastructure;
using Infrastructure.Reposotories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICarsService, CarServices>();
builder.Services.AddScoped<ICarRepository, CarRepository>();
builder.Services.AddDbContext<AutomovilesContext>(e => e.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Automoviles;Integrated Security=True;"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
