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
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigin", builder =>
    {
        builder
            .WithOrigins("http://localhost:3000") // Permita as solicitações do seu frontend
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});
builder.Services.AddScoped<IUsersRepository, UsersRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors("AllowOrigin"); // Use a política CORS configurada
app.MapControllers();

app.Run();
