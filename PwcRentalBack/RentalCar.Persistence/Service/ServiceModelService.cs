using RentalCar.Application.Abstractions.Repository.ModelRepository;
using RentalCar.Application.Abstractions.Service;
using RentalCar.Domain.Entities;

namespace RentalCar.Persistence.Service;

public class ServiceModelService(IServiceModelRepository _serviceModelRepository) : IServiceModelService
{
	public async Task CreateAsync(ServiceModel service, CancellationToken cancellationToken)
	{
		await _serviceModelRepository.CreateAsync(service, cancellationToken);
	}

	public async Task UpdateAsync(ServiceModel service, CancellationToken cancellationToken)
	{
		await _serviceModelRepository.UpdateAsync(service, cancellationToken);
	}

	public async Task DeleteAsync(ServiceModel service, CancellationToken cancellationToken)
	{
		await _serviceModelRepository.DeleteAsync(service, cancellationToken);
	}

	public Task<ServiceModel> Get(int id, CancellationToken cancellationToken)
	{
		return _serviceModelRepository.GetAsync(id,cancellationToken);
	}

	public Task<List<ServiceModel>> GetAll(CancellationToken cancellationToken)
	{
		return _serviceModelRepository.GetAllAsync(cancellationToken);
	}
}
