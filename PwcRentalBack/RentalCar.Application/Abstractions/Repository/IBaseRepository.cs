﻿using RentalCar.Domain.Common;

namespace RentalCar.Application.Abstractions.Repository;

public interface IBaseRepository<T> where T : BaseEntity
{
	Task<T?> GetAsync(int id, CancellationToken cancellationToken);

	Task<List<T>> GetAllAsync(CancellationToken cancellationToken);

	Task CreateAsync(T entity, CancellationToken cancellationToken);

	Task DeleteAsync(T entity, CancellationToken cancellationToken);

	Task UpdateAsync(T entity, CancellationToken cancellationToken);
}
