using APICalendarPet;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.Net.Http.Headers;
using APICalendarPet.API;
using APICalendarPet.Users;
using APICalendarPet.Agenda;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddHttpClient<IUsersRepository, UsersRepository>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
ConfigurationManager configuration = builder.Configuration;
string? connection = configuration.GetConnectionString("APIContext");
string? SERVER = configuration.GetConnectionString("SERVER");
string? DATABASE = configuration.GetConnectionString("DATABASE");
string? USERDB = configuration.GetConnectionString("USERDB");
string? PASSWORDUSER = configuration.GetConnectionString("PASSWORDUSER");
builder.Services.AddDbContext<APIDataContext>(options =>
    options.UseSqlServer(connection));
builder.Services.AddCors();
builder.Services.AddScoped<IUsersRepository, UsersRepository>();
builder.Services.AddScoped<IAgendaRepository, AgendaRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection(); 

app.UseAuthorization();
app.UseCors(c =>
{
    c.AllowAnyHeader();
    c.AllowAnyMethod();
    c.AllowAnyOrigin();
}); // Use a pol�tica CORS configurada
app.MapControllers();

app.Run();
