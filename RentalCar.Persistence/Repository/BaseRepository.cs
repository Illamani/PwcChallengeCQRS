using Microsoft.EntityFrameworkCore;
using RentalCar.Application.Repository;
using RentalCar.Domain.Common;
using RentalCar.Persistence.Context;

namespace RentalCar.Persistence.Repository
{
	public class BaseRepository<T>(RentalContext context) : IBaseRepository<T> where T : BaseEntity
	{
		public async Task CreateAsync(T entity, CancellationToken cancellationToken)
		{
			await context.AddAsync(entity, cancellationToken);
			await context.SaveChangesAsync(cancellationToken);
		}

		public async Task DeleteAsync(T entity,CancellationToken cancellationToken)
		{
			context.Remove(entity);
			await context.SaveChangesAsync(cancellationToken);
		}

		public async Task UpdateAsync(T entity, CancellationToken cancellationToken)
		{
			context.Update(entity);
			await context.SaveChangesAsync(cancellationToken);
		}

		public Task<List<T>> GetAllAsync(CancellationToken cancellationToken)
		{
			return context.Set<T>().ToListAsync(cancellationToken);
		}

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

		public Task<T> GetAsync(int id, CancellationToken cancellationToken)
		{
			return context.Set<T>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
		}

		public void Update(T entity)
		{
			context.Update(entity);
			context.SaveChanges();
		}
	}
}
