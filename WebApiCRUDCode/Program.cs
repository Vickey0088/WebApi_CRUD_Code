using Microsoft.EntityFrameworkCore;
using WebApiCRUDCode.Models;
using WebApiCRUDCode.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>
    (item => item.UseSqlServer(builder.Configuration.GetConnectionString("constr")));

builder.Services.AddControllers();

//builder.Services.AddScoped<ApplicationDbContext, ApplicationDbContext>();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddScoped<IStudentRepository, StudentRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();



// DELL\SQLEXPRESS
