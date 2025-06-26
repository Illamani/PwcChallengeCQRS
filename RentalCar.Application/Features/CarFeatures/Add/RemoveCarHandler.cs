using MediatR;
using RentalCar.Application.Abstractions.Repository.ModelRepository;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.CarFeatures.Add
{
	public sealed class RemoveCarHandler(ICarRepository carRepository) : IRequestHandler<RemoveCarRequest, Car>
	{
		private readonly ICarRepository _carRepository = carRepository;

		public async Task<Car> Handle(RemoveCarRequest request, CancellationToken cancellationToken)
		{
			await _carRepository.DeleteAsync(request.Car, cancellationToken);
			return request.Car;
		}
	}
}
