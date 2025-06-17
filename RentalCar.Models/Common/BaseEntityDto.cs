namespace RentalCar.Domain.Common;

public abstract class BaseEntityDto
{
	public int Id { get; set; }
	public bool IsDeleted { get; set; }
}
