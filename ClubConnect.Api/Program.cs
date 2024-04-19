using ClubConnect.Data;
using ClubConnect.Data.Repositorios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var mySQLConfiguracion = new MySQLConfiguracion(builder.Configuration.GetConnectionString("MySqlConnection"));
builder.Services.AddSingleton(mySQLConfiguracion);

builder.Services.AddScoped<SociosRepositorio, SociosRepositorio>();



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
