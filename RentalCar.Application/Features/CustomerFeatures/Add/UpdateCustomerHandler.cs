using MediatR;
using RentalCar.Application.Repository.ModelRepository;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.CustomerFeatures.Add;

public sealed class UpdateCustomerHandler(ICustomerRepository customerRepository) : IRequestHandler<UpdateCustomerRequest, Customer>
{
	private readonly ICustomerRepository _customerRepository = customerRepository;

	public async Task<Customer> Handle(UpdateCustomerRequest request, CancellationToken cancellationToken)
	{
		await _customerRepository.UpdateAsync(request.Customer, cancellationToken);
		return request.Customer;
	}
}
