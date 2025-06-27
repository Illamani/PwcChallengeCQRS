using RentalCar.Domain.Entities;

namespace RentalCar.Application.Abstractions.Service;

public interface ICustomerService
{
	Task CreateAsync(Customer customer, CancellationToken cancellationToken);
	Task DeleteAsync(Customer customer, CancellationToken cancellationToken);
	Task<Customer> Get(int id, CancellationToken cancellationToken);
	Task<List<Customer>> GetAll(CancellationToken cancellationToken);
	Task UpdateAsync(Customer customer, CancellationToken cancellationToken);
}
