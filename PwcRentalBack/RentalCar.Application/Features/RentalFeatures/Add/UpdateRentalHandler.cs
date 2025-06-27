using MediatR;
using RentalCar.Application.Abstractions.Repository.ModelRepository;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.RentalFeatures.Add;

public sealed class UpdateRentalHandler(IRentalRepository rentalRepository) : IRequestHandler<UpdateRentalRequest, Rental>
{
	private readonly IRentalRepository _rentalRepository = rentalRepository;

	public async Task<Rental> Handle(UpdateRentalRequest request, CancellationToken cancellationToken)
	{
		await _rentalRepository.UpdateAsync(request.Rental, cancellationToken);
		return request.Rental;
	}
}
