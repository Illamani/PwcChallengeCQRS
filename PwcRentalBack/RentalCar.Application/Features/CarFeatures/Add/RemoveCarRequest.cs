using MediatR;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.CarFeatures.Add
{
	public sealed record RemoveCarRequest(Car Car) : IRequest<Car> { }
}
