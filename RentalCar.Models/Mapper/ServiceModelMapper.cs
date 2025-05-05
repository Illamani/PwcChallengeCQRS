using Riok.Mapperly.Abstractions;
using RentalCar.Domain.Entities;
using RentalCar.Domain.Dto;

namespace RentalCar.Domain.Mapper
{
	[Mapper]
	public partial class ServiceModelMapper
	{
		public partial ServiceModel ServiceDtoToServiceModel(ServiceDto serviceDto);

		public partial List<ServiceModel> ServiceDtosToServiceModels(List<ServiceDto> serviceDtos);

		public partial ServiceDto ServiceModelToServiceDto(ServiceModel service);

		public partial List<ServiceDto> ServiceModelsToServiceDtos(List<ServiceModel> services);
	}
}
