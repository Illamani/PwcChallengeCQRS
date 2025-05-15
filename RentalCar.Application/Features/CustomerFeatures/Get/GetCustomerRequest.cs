using MediatR;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.CustomerFeatures.Get;

public sealed record GetCustomerRequest(int Id) : IRequest<Customer>;
