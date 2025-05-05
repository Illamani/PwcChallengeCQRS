using RentalCar.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentalCar.Domain.Entities
{
	public class Rental : BaseEntity
	{
		public int CustomerId { get; set; }

		[ForeignKey("CustomerId")]
		public Customer	Customer { get; set; }

		public DateTime StartDate { get; set; }

		public DateTime EndDate { get; set; }

		public int CarId { get; set; }

		[ForeignKey("CarId")]
		public Car Car { get; set; }
	}
}
