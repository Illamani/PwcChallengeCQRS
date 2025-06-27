using MediatR;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.CustomerFeatures.Get;

public sealed record GetAllCustomerRequest : IRequest<List<Customer>>;
