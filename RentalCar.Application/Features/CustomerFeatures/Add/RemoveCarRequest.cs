using MediatR;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.CustomerFeatures.Add;

public sealed record RemoveCarRequest(Customer Customer) : IRequest<Customer>;
