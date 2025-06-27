using MediatR;
using RentalCar.Application.Abstractions.Repository.ModelRepository;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.ServiceModelFeatures.Get;

public sealed class GetAllServiceHandler(IServiceModelRepository serviceModelRepository) : IRequestHandler<GetAllServiceRequest, List<ServiceModel>>
{
	private readonly IServiceModelRepository _serviceModelRepository = serviceModelRepository;

	public async Task<List<ServiceModel>> Handle(GetAllServiceRequest request, CancellationToken cancellationToken)
	{
		return	await _serviceModelRepository.GetAllAsync(cancellationToken);
	}
}
