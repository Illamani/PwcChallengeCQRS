using MediatR;
using RentalCar.Application.Abstractions.Repository.ModelRepository;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.CustomerFeatures.Add;

public sealed class AddCustomerHandler(ICustomerRepository customerRepository) : IRequestHandler<AddCustomerRequest, Customer>
{
	private readonly ICustomerRepository _customerRepository = customerRepository;

	public async Task<Customer> Handle(AddCustomerRequest request, CancellationToken cancellationToken)
	{

		await _customerRepository.CreateAsync(request.Customer, cancellationToken);
		return request.Customer;
	}
}
