using MediatR;
using RentalCar.Application.Abstractions.Repository.ModelRepository;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.CarFeatures.Add
{
	public sealed class AddCarHandler(ICarRepository carRepository) : IRequestHandler<AddCarRequest, Car>
	{
		private readonly ICarRepository _carRepository = carRepository;
		public async Task<Car> Handle(AddCarRequest request, CancellationToken cancellationToken)
		{
			await _carRepository.CreateAsync(request.Car, cancellationToken);
			return request.Car;
		}
	}
}
