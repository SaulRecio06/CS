global using CS.models;
global using CS.Services.CharacterService;
global using CSApi.Dtos.Character;
global using AutoMapper;
global using Microsoft.EntityFrameworkCore;
global using CSApi.Data;
global using DotNetEnv;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddEnvironmentVariables();
DotNetEnv.Env.Load();



var DB_HOST = Environment.GetEnvironmentVariable("DB_HOST");
var DB_NAME = Environment.GetEnvironmentVariable("DB_NAME");

var DbConnection = $"Server={DB_HOST}; Database={DB_NAME}; Trusted_Connection=true;TrustServerCertificate=true;";

// Add services to the container.
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(DbConnection));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddScoped<INterCharacter, CharacterService>();

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
