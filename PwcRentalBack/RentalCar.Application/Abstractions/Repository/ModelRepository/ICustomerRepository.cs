using RentalCar.Domain.Entities;

namespace RentalCar.Application.Abstractions.Repository.ModelRepository;

public interface ICustomerRepository : IBaseRepository<Customer>
{
	public Task<bool> CheckCustomerAdded(string FullName, string Address);
}
