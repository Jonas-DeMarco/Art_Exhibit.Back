using Art_Exhibit.Back.Application.Interfaces;
using Art_Exhibit.Back.Application.Interfaces.Repositories;
using Art_Exhibit.Back.Application.Interfaces.Services;
using Art_Exhibit.Back.Application.Services;
using Art_Exhibit.Back.Infrastructure.Data;
using Art_Exhibit.Back.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();



// Register the database context
builder.Services.AddDbContext<ApplicationDBContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register services and repositories
//users
builder.Services.AddScoped<IUsersRepository, UserRepository>();
builder.Services.AddScoped<IUsersServices, UsersServices>();
//typeusers
builder.Services.AddScoped<ITypeUserServices,TypeUserServices>();
builder.Services.AddScoped<ITypeUserRepository, TypeUserRepository>();



builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowBlazor",
        policy =>
        {
            policy
                .WithOrigins("https://localhost:7045") // Blazor WASM URL
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "v1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("AllowBlazor");

app.MapControllers();

app.Run();
