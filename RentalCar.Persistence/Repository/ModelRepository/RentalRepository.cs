using RentalCar.Application.Repository.ModelRepository;
using RentalCar.Domain.Entities;
using RentalCar.Persistence.Context;

namespace RentalCar.Persistence.Repository.ModelRepository
{
	public class RentalRepository(RentalContext context) : BaseRepository<Rental>(context), IRentalRepository
	{
	}
}
