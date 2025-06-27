using MediatR;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.RentalFeatures.Get;

public sealed record GetAllRentalRequest : IRequest<List<Rental>>;
