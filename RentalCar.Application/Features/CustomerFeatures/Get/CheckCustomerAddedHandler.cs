using MediatR;
using RentalCar.Application.Abstractions.Repository.ModelRepository;

namespace RentalCar.Application.Features.CustomerFeatures.Get;

public sealed class CheckCustomerAddedHandler(ICustomerRepository customerRepository) : IRequestHandler<CheckCustomerAddedRequest, bool>
{
	private readonly ICustomerRepository _customerRepository = customerRepository;

	public async Task<bool> Handle(CheckCustomerAddedRequest request, CancellationToken cancellationToken)
	{
		var name = request.customerInput.Name.ToLower().Trim() + " " + request.customerInput.LastName.ToLower().Trim();
		var address = request.customerInput.Address.ToLower().Trim();
		return await _customerRepository.CheckCustomerAdded(name, address);
	}
}
