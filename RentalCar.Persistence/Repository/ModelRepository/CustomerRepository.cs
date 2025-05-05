using RentalCar.Application.Repository.ModelRepository;
using RentalCar.Domain.Entities;
using RentalCar.Persistence.Context;

namespace RentalCar.Persistence.Repository.ModelRepository
{
	public class CustomerRepository(RentalContext context) : BaseRepository<Customer>(context), ICustomerRepository
	{
	}
}
