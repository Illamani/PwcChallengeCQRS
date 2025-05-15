using MediatR;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.RentalFeatures.Add
{
	public sealed record AddRentalRequest(Rental Rental) : IRequest<Rental>;
}
