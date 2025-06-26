namespace RentalCar.Domain.Dto.Rental;

public class RentalInput
{
	public int CustomerId { get; set; }

	public int CarId { get; set; }

	public DateTime StartDate { get; set; }

	public DateTime EndDate { get; set; }
}
