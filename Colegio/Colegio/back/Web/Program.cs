using Web.Extendes;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMapperApp();

// Bd
builder.Services.AddDb("PgAdmin", builder.Configuration);

// Controladores
builder.Services.AddInject();

//Validaciones
builder.Services.AddHelpersValidation();
builder.Services.AddCustomCors(builder.Configuration);



var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors();
app.UseAuthorization();

app.MapControllers();

app.Run();
