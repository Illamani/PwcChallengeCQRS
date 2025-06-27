using MediatR;
using RentalCar.Application.Abstractions.Repository.ModelRepository;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.CustomerFeatures.Get;

public sealed class GetCustomerHandler(ICustomerRepository customerRepository) : IRequestHandler<GetCustomerRequest, Customer?>
{
	private readonly ICustomerRepository _customerRepository = customerRepository;

	public async Task<Customer?> Handle(GetCustomerRequest request, CancellationToken cancellationToken)
	{
		return await _customerRepository.GetAsync(request.Id, cancellationToken);
	}
}
