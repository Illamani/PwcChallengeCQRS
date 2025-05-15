using MediatR;
using RentalCar.Application.Repository.ModelRepository;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.ServiceModelFeatures.Add;

public sealed class AddServiceHandler(IServiceModelRepository serviceModelRepository) : IRequestHandler<AddServiceRequest, ServiceModel>
{
	private readonly IServiceModelRepository _serviceModelRepository = serviceModelRepository;

	public async Task<ServiceModel> Handle(AddServiceRequest request, CancellationToken cancellationToken)
	{
		await _serviceModelRepository.CreateAsync(request.ServiceModel, cancellationToken);
		return request.ServiceModel;
	}
}
