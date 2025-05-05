using RentalCar.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentalCar.Domain.Entities
{
	public class Car : BaseEntity
	{
		public int ServiceId { get; set; }

		[ForeignKey("ServiceId")]
		public ICollection<ServiceModel> Services { get; set; }

		public string Type { get; set; }

		public string Model { get; set; }
	}
}
