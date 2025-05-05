using RentalCar.Domain.Entities;

namespace RentalCar.Application.Service
{
	public interface IServiceModelService
	{
		void Create(ServiceModel service);
		void Delete(ServiceModel service);
		Task<ServiceModel> Get(int id, CancellationToken cancellationToken);
		Task<List<ServiceModel>> GetAll(CancellationToken cancellationToken);
		void Update(ServiceModel service);
	}
}
