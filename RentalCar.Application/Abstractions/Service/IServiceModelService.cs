using RentalCar.Domain.Entities;

namespace RentalCar.Application.Abstractions.Service;

public interface IServiceModelService
{
	Task CreateAsync(ServiceModel service, CancellationToken cancellationToken);

	Task DeleteAsync(ServiceModel service, CancellationToken cancellationToken);

	Task UpdateAsync(ServiceModel service, CancellationToken cancellationToken);

	Task<ServiceModel> Get(int id, CancellationToken cancellationToken);

	Task<List<ServiceModel>> GetAll(CancellationToken cancellationToken);
}
