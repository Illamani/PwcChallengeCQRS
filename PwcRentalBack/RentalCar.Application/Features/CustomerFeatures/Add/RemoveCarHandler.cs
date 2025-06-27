using MediatR;
using RentalCar.Application.Abstractions.Repository.ModelRepository;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.CustomerFeatures.Add;

public sealed class RemoveCarHandler(ICustomerRepository customerRepository) : IRequestHandler<RemoveCarRequest, Customer>
{
	private readonly ICustomerRepository _customerRepository = customerRepository;

	public async Task<Customer> Handle(RemoveCarRequest request, CancellationToken cancellationToken)
	{
		await _customerRepository.DeleteAsync(request.Customer, cancellationToken);
		return request.Customer;
	}
}
