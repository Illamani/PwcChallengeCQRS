using MediatR;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.RentalFeatures.Add;

public sealed record UpdateRentalRequest(Rental Rental) : IRequest<Rental>;
