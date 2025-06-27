using Microsoft.EntityFrameworkCore;
using RentalCar.Application.Abstractions.Repository.ModelRepository;
using RentalCar.Domain.Entities;
using RentalCar.Persistence.Context;

namespace RentalCar.Persistence.Repository.ModelRepository;

public class CustomerRepository(RentalContext context) : BaseRepository<Customer>(context), ICustomerRepository
{
	public async Task<bool> CheckCustomerAdded(string FullName, string Address)
	{
		return await context.Customers.AnyAsync(x => x.FullName.ToLower().Trim() == FullName && x.Address.ToLower().Trim() == Address);
	}
}
