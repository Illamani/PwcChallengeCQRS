using Microsoft.AspNetCore.Mvc;
using RentalCar.Application.Service;
using RentalCar.Domain.Dto;
using RentalCar.Domain.Entities;
using RentalCar.Domain.Mapper;

namespace RentalCar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceModelController(IServiceModelService serviceModelService) : ControllerBase
    {
        private readonly ServiceModelMapper _mapper = new();

        [HttpGet]
        [Route("Get")]
        public async Task<ServiceDto> Get(int id, CancellationToken cancellationToken)
        {
            var service = await serviceModelService.Get(id, cancellationToken);
            return _mapper.ServiceModelToServiceDto(service);
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<List<ServiceDto>> GetAll(CancellationToken cancellationToken)
        {
            var services = await serviceModelService.GetAll(cancellationToken);
            return _mapper.ServiceModelsToServiceDtos(services);
        }

        [HttpPost]
        [Route("Create")]
        public void Create(ServiceModel service)
        {
            serviceModelService.Create(service);
        }

        [HttpDelete]
        [Route("Delete")]
        public void Delete(ServiceModel service)
        {
            serviceModelService.Delete(service);
        }

        [HttpPut]
        [Route("Update")]
        public void Update(ServiceModel service)
        {
            serviceModelService.Update(service);
        }
    }
}
