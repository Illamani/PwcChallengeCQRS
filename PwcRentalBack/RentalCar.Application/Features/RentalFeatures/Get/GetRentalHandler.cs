using MediatR;
using RentalCar.Application.Abstractions.Repository.ModelRepository;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.RentalFeatures.Get;

public sealed class GetRentalHandler(IRentalRepository rentalRepository) : IRequestHandler<GetRentalRequest, Rental>
{
	private readonly IRentalRepository _rentalRepository = rentalRepository;

	public async Task<Rental> Handle(GetRentalRequest request, CancellationToken cancellationToken)
	{
		return await _rentalRepository.GetAsync(request.Id, cancellationToken);
	}
}
