using entityframework_.net_lab3.Data.Context;
using entityframework_.net_lab3.Interfaces;
using entityframework_.net_lab3.Repository.Implementations;
using entityframework_.net_lab3.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICargoService, CargoService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IFactoryService, FactoryService>();
builder.Services.AddScoped<IProductService, ProductService>();


builder.Services.AddRepositoryLayer(); //bunu yazdim ki yuxardaki kimi bir bir addscoped etmeyim.bunu service ler ucunde yazmaq olar

builder.Services.AddDbContext<CargoDbContext>(opts =>
       opts.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection")));

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
