using RentalCar.Domain.Dto.Car;
using RentalCar.Domain.Entities;
using Riok.Mapperly.Abstractions;

namespace RentalCar.Domain
{
	[Mapper]
	public partial class CarMapper
	{
		public partial CarDto CarToCarDto(Car car);

		public partial List<CarDto> CarsToCarsDto (List<Car> cars);

		public partial Car CarDtoToCar (CarDto car);

		public partial List<Car> CarsDtoToCars (List<CarDto> carsDto);

		public partial CarInput CarToCarInput(Car car);

		public partial List<CarInput> CarsToCarInputs(List<Car> car);

		public partial Car CarInputToCar(CarInput carInput);

		public partial List<Car> CarInputsToCars(List<CarInput> carInputs);
	}
}
