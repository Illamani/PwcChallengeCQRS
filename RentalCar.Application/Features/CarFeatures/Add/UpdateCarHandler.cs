using MediatR;
using RentalCar.Application.Repository.ModelRepository;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.CarFeatures.Add
{
	public sealed class UpdateCarHandler(ICarRepository CarRepository) : IRequestHandler<UpdateCarRequest, Car>
	{
		private readonly ICarRepository _carRepository = CarRepository;

		public async Task<Car> Handle(UpdateCarRequest request, CancellationToken cancellationToken)
		{
			await _carRepository.UpdateAsync(request.Car, cancellationToken);
			return request.Car;
		}
	}
}
