using RentalCar.Application.Abstractions.Repository.ModelRepository;
using RentalCar.Application.Abstractions.Service;
using RentalCar.Domain.Entities;

namespace RentalCar.Persistence.Service;

public class CustomerService(ICustomerRepository _customerRepository) : ICustomerService
{
	public async Task CreateAsync(Customer customer, CancellationToken cancellationToken)
	{
		await _customerRepository.CreateAsync(customer, cancellationToken);
	}

	public async Task UpdateAsync(Customer customer, CancellationToken cancellationToken)
	{
		await _customerRepository.CreateAsync(customer, cancellationToken);
	}

	public async Task DeleteAsync(Customer customer, CancellationToken cancellationToken)
	{
		await _customerRepository.CreateAsync(customer, cancellationToken);
	}

	public Task<Customer> Get(int id, CancellationToken cancellationToken)
	{
		return _customerRepository.GetAsync(id, cancellationToken);
	}

	public Task<List<Customer>> GetAll(CancellationToken cancellationToken)
	{
		return _customerRepository.GetAllAsync(cancellationToken);
	}
}
