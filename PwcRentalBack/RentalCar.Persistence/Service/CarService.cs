using RentalCar.Application.Abstractions.Repository.ModelRepository;
using RentalCar.Application.Abstractions.Service;
using RentalCar.Domain.Entities;

namespace RentalCar.Persistence.Service;

public class CarService(ICarRepository carRepository) : ICarService
{
	public async Task CreateAsync(Car entity, CancellationToken cancellationToken)
	{
		await carRepository.CreateAsync(entity, cancellationToken);
	}

	public async Task UpdateAsync(Car entity, CancellationToken cancellationToken)
	{
		await carRepository.CreateAsync(entity, cancellationToken);
	}

	public async Task DeleteAsync(Car entity, CancellationToken cancellationToken)
	{
		await carRepository.DeleteAsync(entity, cancellationToken);
	}

	public Task<Car> Get(int id, CancellationToken cancellationToken)
	{
		return carRepository.GetAsync(id, cancellationToken);
	}

	public Task<List<Car>> GetAll(CancellationToken cancellationToken)
	{
		return carRepository.GetAllAsync(cancellationToken);
	}
}
