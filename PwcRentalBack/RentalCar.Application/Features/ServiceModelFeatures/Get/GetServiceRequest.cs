using MediatR;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.ServiceModelFeatures.Get;

public sealed record GetServiceRequest(int Id) : IRequest<ServiceModel>;
