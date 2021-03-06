using Microsoft.EntityFrameworkCore;
using Infrastructure.Context;

var builder = WebApplication.CreateBuilder(args);

// Connection with SQL Server
var dbConnect = builder.Configuration.GetConnectionString("UniversityDB");

// Add Context
builder.Services.AddDbContext<UniversityDbContext>(options =>
    options.UseSqlServer(dbConnect)
);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
