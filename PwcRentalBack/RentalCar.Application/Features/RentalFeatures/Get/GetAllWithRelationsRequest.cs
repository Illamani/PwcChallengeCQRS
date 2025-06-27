using MediatR;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.RentalFeatures.Get;

public sealed record GetAllWithRelationsRequest : IRequest<List<Rental>>;