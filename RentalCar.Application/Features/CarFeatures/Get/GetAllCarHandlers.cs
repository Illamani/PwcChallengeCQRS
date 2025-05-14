using MediatR;
using RentalCar.Application.Repository.ModelRepository;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.CarFeatures.Get
{
	public sealed class GetAllCarHandlers(ICarRepository carRepository) : IRequestHandler<GetAllCarRequest, List<Car>>
	{
		private readonly ICarRepository _carRepository = carRepository;

		public Task<List<Car>> Handle(GetAllCarRequest request, CancellationToken cancellationToken)
		{
			return _carRepository.GetAll(cancellationToken);
		}
	}
}
