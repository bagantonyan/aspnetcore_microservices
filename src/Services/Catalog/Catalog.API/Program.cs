var builder = WebApplication.CreateBuilder(args);

// Add services to the container

builder.Services.AddCarter();

var assembly = typeof(Program).Assembly;
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(assembly);
});

var app = builder.Build();

// Configure the HTTP request pipeline

app.MapCarter();

app.Run();