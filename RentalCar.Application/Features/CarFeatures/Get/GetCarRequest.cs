using MediatR;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.CarFeatures.Get
{
	public sealed record GetCarRequest : IRequest<Car>
	{
		public int Id { get; }

		public GetCarRequest(int id) {
			Id = id;
		}
	}
}
