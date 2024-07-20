using APICatalogo.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//Refer�ncias aos servi�os do swagger Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Configuration.AddEnvironmentVariables();

//String de conex�o
string mySqlConnection = builder.Configuration.GetConnectionString("DefaultConnection");

// Verifica se a string de conex�o foi encontrada
if (string.IsNullOrEmpty(mySqlConnection))
{
    throw new InvalidOperationException("A string de conex�o 'DefaultConnection' n�o foi encontrada nas vari�veis de ambiente.");
}


//Registro do contexto Entity Framework
builder.Services.AddDbContext<AppDbContext>(options =>
                                            options.UseMySql(mySqlConnection,
                                            ServerVersion.AutoDetect(mySqlConnection)));

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
