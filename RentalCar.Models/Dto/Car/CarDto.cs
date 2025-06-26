using RentalCar.Domain.Common;

namespace RentalCar.Domain.Dto.Car;

public class CarDto : BaseEntityDto
{
	public int ServiceId { get; set; }

	public string Type { get; set; }

	public string Model { get; set; }
}
