using MediatR;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.CarFeatures.Add
{
	public sealed record UpdateCarRequest(Car Car) : IRequest<Car>;
}
