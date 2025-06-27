using RentalCar.Domain.Entities;

namespace RentalCar.Application.Abstractions.Repository.ModelRepository;

public interface IRentalRepository : IBaseRepository<Rental>
{
	public Task RegisterRentalAsync(Rental rental, CancellationToken cancellationToken);

	public Task<bool> GetRentalByDateAsync(Rental rental, CancellationToken cancellationToken);

	public Task<List<Rental>> GetAllWithRelationAsync(CancellationToken cancellationToken);
}
