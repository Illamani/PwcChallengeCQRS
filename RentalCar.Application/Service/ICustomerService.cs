using RentalCar.Application.Repository;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Service
{
	public interface ICustomerService
	{
		void Create(Customer customer);
		void Delete(Customer customer);
		Task<Customer> Get(int id, CancellationToken cancellationToken);
		Task<List<Customer>> GetAll(CancellationToken cancellationToken);
		void Update(Customer customer);
	}
}
