using MediatR;
using RentalCar.Domain.Dto;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.CarFeatures.Get
{
	public sealed record GetAllCarRequest : IRequest<List<Car>>
	{
	}
}
