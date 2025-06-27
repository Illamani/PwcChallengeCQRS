using MediatR;
using RentalCar.Application.Abstractions.Repository.ModelRepository;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.CarFeatures.Get
{
	public sealed class GetAllCarHandler(ICarRepository carRepository) : IRequestHandler<GetAllCarRequest, List<Car>>
	{
		private readonly ICarRepository _carRepository = carRepository;

		public Task<List<Car>> Handle(GetAllCarRequest request, CancellationToken cancellationToken)
		{
			return _carRepository.GetAllAsync(cancellationToken);
		}
	}
}
