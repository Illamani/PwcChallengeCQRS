using MediatR;
using RentalCar.Application.Abstractions.Repository.ModelRepository;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.RentalFeatures.Add;

public sealed class AddRentalHandler(IRentalRepository rentalRepository) : IRequestHandler<AddRentalRequest, Rental>
{
	private readonly IRentalRepository _rentalRepository = rentalRepository;

	public async Task<Rental> Handle(AddRentalRequest request, CancellationToken cancellationToken)
	{
		await _rentalRepository.CreateAsync(request.Rental, cancellationToken);
		return request.Rental;
	}
}
