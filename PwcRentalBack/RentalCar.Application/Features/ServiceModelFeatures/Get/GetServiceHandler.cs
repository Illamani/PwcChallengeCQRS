using MediatR;
using RentalCar.Application.Abstractions.Repository.ModelRepository;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.ServiceModelFeatures.Get;

public sealed class GetServiceHandler(IServiceModelRepository serviceModelRepository) : IRequestHandler<GetServiceRequest, ServiceModel>
{
	private readonly IServiceModelRepository _serviceModelRepository = serviceModelRepository;

	public async Task<ServiceModel> Handle(GetServiceRequest request, CancellationToken cancellationToken)
	{
		return await _serviceModelRepository.GetAsync(request.Id, cancellationToken);
	}
}
