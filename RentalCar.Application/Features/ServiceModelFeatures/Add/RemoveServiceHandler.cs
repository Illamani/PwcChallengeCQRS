using MediatR;
using RentalCar.Application.Repository.ModelRepository;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.ServiceModelFeatures.Add;

public sealed class RemoveServiceHandler(IServiceModelRepository serviceModelRepository) : IRequestHandler<RemoveServiceRequest, ServiceModel>
{
	private readonly IServiceModelRepository _serviceModelRepository = serviceModelRepository;

	public async Task<ServiceModel> Handle(RemoveServiceRequest request, CancellationToken cancellationToken)
	{
		await _serviceModelRepository.DeleteAsync(request.ServiceModel, cancellationToken);
		return request.ServiceModel;
	}
}
