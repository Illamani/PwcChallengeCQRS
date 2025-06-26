using RentalCar.Application.Abstractions.Repository.ModelRepository;
using RentalCar.Application.Abstractions.Service;
using RentalCar.Domain.Entities;

namespace RentalCar.Persistence.Service
{
	public class RentalService(IRentalRepository _rentalRepository) : IRentalService
	{
		public async Task CreateAsync(Rental rental, CancellationToken cancellationToken)
		{
			await _rentalRepository.CreateAsync(rental, cancellationToken);
		}

		public async Task UpdateAsync(Rental rental, CancellationToken cancellationToken)
		{
			await _rentalRepository.CreateAsync(rental, cancellationToken);
		}

		public async Task DeleteAsync(Rental rental, CancellationToken cancellationToken)
		{
			await _rentalRepository.DeleteAsync(rental, cancellationToken);
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
