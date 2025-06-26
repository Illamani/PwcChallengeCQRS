using RentalCar.Domain.Common;

namespace RentalCar.Domain.Entities
{
	public class Rental : BaseEntity
	{
		public int CustomerId { get; set; }
		public Customer	Customer { get; set; }

		public DateTime StartDate { get; set; }

		public DateTime EndDate { get; set; }

		public int CarId { get; set; }
		public Car Car { get; set; }
	}
}
