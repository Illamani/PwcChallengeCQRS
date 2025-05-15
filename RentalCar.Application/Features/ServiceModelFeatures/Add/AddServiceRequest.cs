using MediatR;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.ServiceModelFeatures.Add;

public sealed record AddServiceRequest(ServiceModel ServiceModel) : IRequest<ServiceModel>;
