using MediatR;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.CustomerFeatures.Add;

public sealed record AddCustomerRequest(Customer Customer) : IRequest<Customer>;