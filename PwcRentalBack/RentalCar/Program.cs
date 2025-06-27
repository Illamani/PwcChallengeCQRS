using Carter;
using RentalCar.Api;
using RentalCar.Application;
using RentalCar.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCarter();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(DemoLibraryEntryPointMediatr).Assembly));

builder.Services.ConfigurePersistence(builder.Configuration);

var app = builder.Build();

app.AddInitialMigration();

app.ConfigureSwagger();

app.ConfigureErrorHandler();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapCarter();

app.MapControllers();

app.Run();
