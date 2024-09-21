using MoneyChangeAPI.BussinesLogic;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(); //Esto es para leer los controladores desde la carpeta Controllers
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Agregar el acceso a las configuraciones y la cadena de conexión
builder.Services.AddSingleton<IConfiguration>(builder.Configuration);
// Configurar dependencias del repositorio
builder.Services.AddScoped<MetaBL>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapControllers(); //Mapear los controlares dentro de la carpeta Controllers

app.Run();

// record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
// {
//     public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
// }
