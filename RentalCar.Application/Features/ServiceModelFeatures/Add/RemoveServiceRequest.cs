using MediatR;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.ServiceModelFeatures.Add;

public sealed record RemoveServiceRequest(ServiceModel ServiceModel) : IRequest<ServiceModel>;
