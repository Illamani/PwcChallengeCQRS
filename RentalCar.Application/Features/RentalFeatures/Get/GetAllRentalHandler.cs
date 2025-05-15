using MediatR;
using RentalCar.Application.Repository.ModelRepository;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.RentalFeatures.Get
{
	public sealed class GetAllRentalHandler(IRentalRepository rentalRepository) : IRequestHandler<GetAllRentalRequest, List<Rental>>
	{
		private readonly IRentalRepository _rentalRepository = rentalRepository;

		public async Task<List<Rental>> Handle(GetAllRentalRequest request, CancellationToken cancellationToken)
		{
			return await _rentalRepository.GetAllAsync(cancellationToken);
		}
	}
}
