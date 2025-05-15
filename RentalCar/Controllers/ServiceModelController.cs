using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentalCar.Application.Features.ServiceModelFeatures.Add;
using RentalCar.Application.Features.ServiceModelFeatures.Get;
using RentalCar.Domain.Dto;
using RentalCar.Domain.Entities;
using RentalCar.Domain.Mapper;

namespace RentalCar.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ServiceModelController(IMediator mediator) : ControllerBase
{
    private readonly ServiceModelMapper _mapper = new();
    private readonly IMediator _mediator = mediator;

    [HttpGet]
    [Route("Get")]
    public async Task<ServiceDto> GetAsync(int id, CancellationToken cancellationToken)
    {
        var service = await _mediator.Send(new GetServiceRequest(id), cancellationToken);
        return _mapper.ServiceModelToServiceDto(service);
    }

    [HttpGet]
    [Route("GetAll")]
    public async Task<List<ServiceDto>> GetAllAsync(CancellationToken cancellationToken)
    {
        var services = await _mediator.Send(new GetAllServiceRequest(), cancellationToken);
        return _mapper.ServiceModelsToServiceDtos(services);
    }

    [HttpPost]
    [Route("Create")]
    public async Task<ServiceDto> CreateAsync(ServiceModel service, CancellationToken cancellationToken)
    {
        var services = await _mediator.Send(new AddServiceRequest(service), cancellationToken);
        return _mapper.ServiceModelToServiceDto(services);
    }

    [HttpDelete]
    [Route("Delete")]
    public async Task<ServiceDto> DeleteAsync(ServiceModel service, CancellationToken cancellationToken)
    {
        var services = await _mediator.Send(new RemoveServiceRequest(service), cancellationToken);
        return _mapper.ServiceModelToServiceDto(services);
    }

    [HttpPut]
    [Route("Update")]
    public async Task<ServiceDto> UpdateAsync(ServiceModel service, CancellationToken cancellationToken)
    {
        var services = await _mediator.Send(new UpdateServiceRequest(service), cancellationToken);
        return _mapper.ServiceModelToServiceDto(services);
    }
}
