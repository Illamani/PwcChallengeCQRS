using MediatR;
using RentalCar.Application.Abstractions.Repository.ModelRepository;

namespace RentalCar.Application.Features.RentalFeatures.Get;

public sealed class GetRentalByDateHandler(IRentalRepository rentalRepository) : IRequestHandler<GetRentalByDateRequest, bool>
{
	public async Task<bool> Handle(GetRentalByDateRequest request, CancellationToken cancellationToken)
	{
		return await rentalRepository.GetRentalByDateAsync(request.rental, cancellationToken);
	}
}
