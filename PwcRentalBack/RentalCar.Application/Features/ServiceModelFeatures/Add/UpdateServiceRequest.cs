using MediatR;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.ServiceModelFeatures.Add;

public sealed record UpdateServiceRequest(ServiceModel ServiceModel) : IRequest<ServiceModel>;