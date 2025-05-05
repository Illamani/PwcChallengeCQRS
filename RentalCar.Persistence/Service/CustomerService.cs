using RentalCar.Application.Repository.ModelRepository;
using RentalCar.Application.Service;
using RentalCar.Domain.Entities;

namespace RentalCar.Persistence.Service
{
	public class CustomerService(ICustomerRepository _customerRepository) : ICustomerService
	{
		public void Create(Customer customer)
		{
			_customerRepository.Create(customer);
		}

		public void Update(Customer customer)
		{
			_customerRepository.Update(customer);
		}

		public void Delete(Customer customer)
		{
			_customerRepository.Delete(customer);
		}

		public Task<Customer> Get(int id, CancellationToken cancellationToken)
		{
			return _customerRepository.Get(id, cancellationToken);
		}

		public Task<List<Customer>> GetAll(CancellationToken cancellationToken)
		{
			return _customerRepository.GetAll(cancellationToken);
		}
	}
}
