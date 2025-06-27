using MediatR;
using RentalCar.Application.Abstractions.Repository.ModelRepository;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.RentalFeatures.Get;

public sealed class GetAllWithRelationHandler(IRentalRepository rentalRepository) : IRequestHandler<GetAllWithRelationsRequest, List<Rental>>
{
	private readonly IRentalRepository _rentalRepository = rentalRepository;

	public async Task<List<Rental>> Handle(GetAllWithRelationsRequest request, CancellationToken cancellationToken)
	{
		return await _rentalRepository.GetAllWithRelationAsync(cancellationToken);
	}
}
