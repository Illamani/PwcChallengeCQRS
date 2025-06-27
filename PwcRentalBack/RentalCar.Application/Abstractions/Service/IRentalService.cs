using RentalCar.Domain.Entities;

namespace RentalCar.Application.Abstractions.Service
{
	public interface IRentalService
	{
		Task CreateAsync(Rental rental, CancellationToken cancellationToken);

		Task UpdateAsync(Rental rental, CancellationToken cancellationToken);

		Task DeleteAsync(Rental rental, CancellationToken cancellationToken);

		Task<Rental> Get(int id, CancellationToken cancellationToken);

		Task<List<Rental>> GetAll(CancellationToken cancellationToken);
	}
}
