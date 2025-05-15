using MediatR;
using RentalCar.Application.Repository.ModelRepository;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.CarFeatures.Get
{
	public sealed class GetCarHandlers(ICarRepository carRepository) : IRequestHandler<GetCarRequest, Car>
	{
		private readonly ICarRepository _carRepository = carRepository;
		public Task<Car> Handle(GetCarRequest request, CancellationToken cancellationToken)
		{
			return _carRepository.GetAsync(request.Id, cancellationToken);
		}
	}
}
