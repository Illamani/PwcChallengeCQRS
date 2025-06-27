using MediatR;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.RentalFeatures.Get;

public sealed record GetRentalRequest(int Id) : IRequest<Rental>;
