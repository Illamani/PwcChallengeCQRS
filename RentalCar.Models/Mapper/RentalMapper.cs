using RentalCar.Domain.Dto;
using RentalCar.Domain.Entities;
using Riok.Mapperly.Abstractions;
namespace RentalCar.Domain.Mapper
{
	[Mapper]
	public partial class RentalMapper
	{
		public partial Rental RentalDtoToRental(RentalDto rentalDto);

		public partial List<Rental> RentalDtosToRentals(List<RentalDto> rentalDto);

		public partial RentalDto RentalToRentalDto(Rental rental);

		public partial List<RentalDto> RentalsToRentalDtos(List<Rental> rentals);
	}
}
