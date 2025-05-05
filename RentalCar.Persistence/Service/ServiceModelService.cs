using RentalCar.Application.Repository.ModelRepository;
using RentalCar.Application.Service;
using RentalCar.Domain.Entities;

namespace RentalCar.Persistence.Service
{
	public class ServiceModelService(IServiceModelRepository _serviceModelRepository) : IServiceModelService
	{
		public void Create(ServiceModel service)
		{
			_serviceModelRepository.Create(service);
		}

		public void Update(ServiceModel service)
		{
			_serviceModelRepository.Update(service);
		}

		public void Delete(ServiceModel service)
		{
			_serviceModelRepository.Delete(service);
		}

		public Task<ServiceModel> Get(int id, CancellationToken cancellationToken)
		{
			return _serviceModelRepository.Get(id,cancellationToken);
		}

		public Task<List<ServiceModel>> GetAll(CancellationToken cancellationToken)
		{
			return _serviceModelRepository.GetAll(cancellationToken);
		}
	}
}
