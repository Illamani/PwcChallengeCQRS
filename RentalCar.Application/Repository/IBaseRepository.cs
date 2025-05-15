using RentalCar.Domain.Common;

namespace RentalCar.Application.Repository
{
	public interface IBaseRepository<T> where T : BaseEntity
	{
		void Create(T entity);

		void Update(T entity);

		void Delete(T entity);

		Task<T> GetAsync(int id, CancellationToken cancellationToken);

		Task<List<T>> GetAllAsync(CancellationToken cancellationToken);
		Task CreateAsync(T entity, CancellationToken cancellationToken);
		Task DeleteAsync(T entity, CancellationToken cancellationToken);
		Task UpdateAsync(T entity, CancellationToken cancellationToken);
	}
}
