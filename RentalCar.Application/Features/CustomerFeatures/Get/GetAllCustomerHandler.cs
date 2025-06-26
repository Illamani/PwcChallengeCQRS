using MediatR;
using RentalCar.Application.Abstractions.Repository.ModelRepository;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.CustomerFeatures.Get
{
	public sealed class GetAllCustomerHandler(ICustomerRepository customerRepository) : IRequestHandler<GetAllCustomerRequest, List<Customer>>
	{
		private readonly ICustomerRepository _customerRepository = customerRepository;

		public Task<List<Customer>> Handle(GetAllCustomerRequest request, CancellationToken cancellationToken)
		{
			return _customerRepository.GetAllAsync(cancellationToken);
		}
	}
}
