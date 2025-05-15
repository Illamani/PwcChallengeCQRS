using MediatR;
using RentalCar.Application.Repository.ModelRepository;
using RentalCar.Domain.Entities;

namespace RentalCar.Application.Features.ServiceModelFeatures.Add;

public sealed class UpdateServiceHandler(IServiceModelRepository serviceModelRepository) : IRequestHandler<UpdateServiceRequest, ServiceModel>
{
	private readonly IServiceModelRepository _serviceModelRepository = serviceModelRepository;

	public async Task<ServiceModel> Handle(UpdateServiceRequest request, CancellationToken cancellationToken)
	{
		await _serviceModelRepository.UpdateAsync(request.ServiceModel, cancellationToken);
		return request.ServiceModel;
	}
}
