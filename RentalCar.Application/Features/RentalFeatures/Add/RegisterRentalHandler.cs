using MediatR;
using RentalCar.Application.Abstractions.Repository.ModelRepository;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.RentalFeatures.Add;

public sealed class RegisterRentalHandler(IRentalRepository rentalRepository) : IRequestHandler<RegisterRentalRequest, Rental>
{
	private readonly IRentalRepository _rentalRepository = rentalRepository;
	public async Task<Rental> Handle(RegisterRentalRequest request, CancellationToken cancellationToken)
	{
		await _rentalRepository.CreateAsync(request.Rental, cancellationToken);
		return request.Rental;
	}
}
