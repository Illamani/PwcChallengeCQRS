using MediatR;
using RentalCar.Application.Repository.ModelRepository;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.RentalFeatures.Add;

public sealed class RemoveRentalHandler(IRentalRepository rentalRepository) : IRequestHandler<RemoveRentalRequest, Rental>
{
	private readonly IRentalRepository _rentalRepository = rentalRepository;

	public async Task<Rental> Handle(RemoveRentalRequest request, CancellationToken cancellationToken)
	{
		await _rentalRepository.DeleteAsync(request.Rental, cancellationToken);
		return request.Rental;
	}
}
