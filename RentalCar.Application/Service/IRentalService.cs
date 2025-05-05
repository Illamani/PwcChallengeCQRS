using RentalCar.Domain.Entities;

namespace RentalCar.Application.Service
{
	public interface IRentalService
	{
		void Create(Rental rental);

		void Update(Rental rental);

		void Delete(Rental rental);

		Task<Rental> Get(int id, CancellationToken cancellationToken);

		Task<List<Rental>> GetAll(CancellationToken cancellationToken);
	}
}
