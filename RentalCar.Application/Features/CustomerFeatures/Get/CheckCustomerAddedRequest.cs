using MediatR;
using RentalCar.Domain.Dto.Customer;

namespace RentalCar.Application.Features.CustomerFeatures.Get;

public sealed record CheckCustomerAddedRequest(CustomerInput customerInput) : IRequest<bool>;
