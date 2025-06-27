using RentalCar.Domain.Entities;

namespace RentalCar.Application.Abstractions.Service;

public interface ICarService
{
	Task CreateAsync(Car entity, CancellationToken cancellationToken);
	Task DeleteAsync(Car entity, CancellationToken cancellationToken);
	Task<Car> Get(int id, CancellationToken cancellationToken);
	Task<List<Car>> GetAll(CancellationToken cancellationToken);
	Task UpdateAsync(Car entity, CancellationToken cancellationToken);
}
