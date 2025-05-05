using RentalCar.Application.Repository.ModelRepository;
using RentalCar.Application.Service;
using RentalCar.Domain.Entities;

namespace RentalCar.Persistence.Service
{
	public class CarService(ICarRepository carRepository) : ICarService
	{
		public void Create(Car entity) {
			carRepository.Create(entity);
		}

		public void Update(Car entity)
		{
			carRepository.Update(entity);
		}

		public void Delete(Car entity)
		{
			carRepository.Delete(entity);
		}

		public Task<Car> Get(int id, CancellationToken cancellationToken)
		{
			return carRepository.Get(id, cancellationToken);
		}

		public Task<List<Car>> GetAll(CancellationToken cancellationToken)
		{
			return carRepository.GetAll(cancellationToken);
		}
	}
}
