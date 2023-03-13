using RokarBitWebApi.Models;
using RokarBitWebApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Mapping appsettings.json to Settings class and registering
// to IocContainer as singleton for dependency injection
var settings = builder.Configuration.GetSection(nameof(Settings)).Get<Settings>();
builder.Services.AddSingleton(settings);

// register BitService to IocContainer for dependency injection
builder.Services.AddScoped<IBitService, BitService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("cors", policyBuilder =>
    {
        policyBuilder
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowAnyOrigin();
    });
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("cors");

app.UseAuthorization();

app.MapControllers();

// configuring http listener to http port from settings
app.Run($"http://*:{settings.HttpPort}/");
