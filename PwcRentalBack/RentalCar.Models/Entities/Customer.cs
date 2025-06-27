using RentalCar.Domain.Common;

namespace RentalCar.Domain.Entities
{
	public class Customer : BaseEntity
	{
		public string FullName { get; set; }

		public string Address { get; set; }
	}
}
