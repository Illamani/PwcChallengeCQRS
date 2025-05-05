namespace RentalCar.Domain.Common
{
	public class BaseEntity
		//Esta clase esta dedicada para ser de BASE para las demas clases
		//Por el momento no la uso, pero capaz despues encuentre una propiedades en comun para todas
	{
		public int Id { get; set; }
		public bool IsDeleted { get; set; }
	}
}
