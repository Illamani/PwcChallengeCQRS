using RentalCar.Domain.Entities;

namespace RentalCar.Application.Service
{
	public interface ICarService
	{
		void Create(Car entity);
		void Delete(Car entity);
		Task<Car> Get(int id, CancellationToken cancellationToken);
		Task<List<Car>> GetAll(CancellationToken cancellationToken);
		void Update(Car entity);
	}
}
