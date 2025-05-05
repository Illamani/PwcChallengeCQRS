using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RentalCar.Application.Repository.ModelRepository;
using RentalCar.Application.Service;
using RentalCar.Persistence.Context;
using RentalCar.Persistence.Repository.ModelRepository;
using RentalCar.Persistence.Service;

namespace RentalCar.Persistence
{
	public static class ServiceExtension
	{
		public static void ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
		{
			var connection = configuration.GetConnectionString("RentalConnection");
			services.AddDbContext<RentalContext>(options => options.UseSqlServer(connection));
			services.AddScoped<ICarRepository, CarRepository>();
			services.AddScoped<ICarService, CarService>();
			services.AddScoped<IRentalRepository, RentalRepository>();
			services.AddScoped<IRentalService, RentalService>();
			services.AddScoped<IServiceModelRepository, ServiceModelRepository>();
			services.AddScoped<IServiceModelService, ServiceModelService>();
			services.AddScoped<ICustomerRepository, CustomerRepository>();
			services.AddScoped<ICustomerService, CustomerService>();
		}
	}
}
