using RentalCar.Application.Repository.ModelRepository;
using RentalCar.Domain.Entities;
using RentalCar.Persistence.Context;

namespace RentalCar.Persistence.Repository.ModelRepository
{
	public class ServiceModelRepository(RentalContext context) : BaseRepository<ServiceModel>(context), IServiceModelRepository
	{
	}
}
