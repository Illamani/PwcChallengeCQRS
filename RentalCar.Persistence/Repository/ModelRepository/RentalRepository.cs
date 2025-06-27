using Microsoft.EntityFrameworkCore;
using RentalCar.Application.Abstractions.Repository.ModelRepository;
using RentalCar.Domain.Entities;
using RentalCar.Persistence.Context;

namespace RentalCar.Persistence.Repository.ModelRepository;

public class RentalRepository(RentalContext _context) : BaseRepository<Rental>(_context), IRentalRepository
{
	public async Task<List<Rental>> GetAllWithRelationAsync(CancellationToken cancellationToken)
	{
		return await _context.Rentals.Include(x => x.Customer).Include(x => x.Car).ToListAsync(cancellationToken);
	}

	public async Task<bool> GetRentalByDateAsync(Rental rental, CancellationToken cancellationToken)
	{
		return await _context.Rentals.CountAsync(x =>
		((rental.StartDate >= x.StartDate && rental.StartDate <= x.EndDate) ||
		(rental.EndDate >= x.StartDate && rental.EndDate <= x.EndDate) ||
		(rental.StartDate <= x.StartDate && rental.EndDate >= x.EndDate)) &&
		x.Car.Id == rental.CarId, cancellationToken) == 0;
	}

	public async Task RegisterRentalAsync(Rental rental, CancellationToken cancellationToken)
	{
		_context.Add<Rental>(rental);
		await _context.SaveChangesAsync(cancellationToken);
	}
}
