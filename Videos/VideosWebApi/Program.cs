using Microsoft.EntityFrameworkCore;
using VideosWebApi.DAL;
using VideosWebApi.DAL.Repositories;
using VideosWebApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Injetando repositórios: AddScoped - Uma nova instância por request
builder.Services.AddScoped<CategoriumRepository>();
// Injetando repositórios: AddTransient - Uma nova instância cada vez que necessário
builder.Services.AddTransient<CategoriaService>();
builder.Services.AddTransient<ResponsavelService>();
builder.Services.AddScoped<ResponsavelRepository>();

// Recupera DefaultConnection da sessão de connections strings do arquivo appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<VideosContext>(options => options.UseSqlServer(connectionString));



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
