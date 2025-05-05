using Microsoft.EntityFrameworkCore;
using RentalCar.Application.Repository;
using RentalCar.Domain.Common;
using RentalCar.Persistence.Context;

namespace RentalCar.Persistence.Repository
{
	public class BaseRepository<T>(RentalContext context) : IBaseRepository<T> where T : BaseEntity
	{
		public void Create(T entity)
		{
			context.Add(entity);
			context.SaveChanges();
		}

		public void Delete(T entity)
		{
			context.Remove(entity);
			context.SaveChanges();
		}

		public Task<T> Get(int id, CancellationToken cancellationToken)
		{
			return context.Set<T>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
		}

		public Task<List<T>> GetAll(CancellationToken cancellationToken)
		{
			return context.Set<T>().ToListAsync(cancellationToken);
		}

		public void Update(T entity)
		{
			context.Update(entity);
			context.SaveChanges();
		}
	}
}
