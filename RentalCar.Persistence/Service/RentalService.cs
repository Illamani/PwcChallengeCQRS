using RentalCar.Application.Repository.ModelRepository;
using RentalCar.Application.Service;
using RentalCar.Domain.Entities;

namespace RentalCar.Persistence.Service
{
	public class RentalService(IRentalRepository _rentalRepository) : IRentalService
	{
		public void Create(Rental rental)
		{
			_rentalRepository.Create(rental);
		}

		public void Update(Rental rental)
		{
			_rentalRepository.Update(rental);
		}

		public void Delete(Rental rental)
		{
			_rentalRepository.Delete(rental);
		}

		public Task<Rental> Get(int id, CancellationToken cancellationToken)
		{
			return _rentalRepository.GetAsync(id, cancellationToken);
		}

		public Task<List<Rental>> GetAll(CancellationToken cancellationToken)
		{
			return _rentalRepository.GetAllAsync(cancellationToken);
		}
	}
}
