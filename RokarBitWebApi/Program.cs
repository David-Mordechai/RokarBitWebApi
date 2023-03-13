using RokarBitWebApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Reading settings
var settings = builder.Configuration.GetSection(nameof(Settings)).Get<Settings>();
builder.Services.AddSingleton(settings);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run($"http://*:{settings.HttpPort}/");
