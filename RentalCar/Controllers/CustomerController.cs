using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentalCar.Application.Features.CustomerFeatures.Add;
using RentalCar.Application.Features.CustomerFeatures.Get;
using RentalCar.Domain.Dto;
using RentalCar.Domain.Entities;
using RentalCar.Domain.Mapper;

namespace RentalCar.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerController(IMediator mediator) : ControllerBase
{
    private readonly CustomerMapper _mapper = new();
    private readonly IMediator _mediator = mediator;

    [HttpGet]
    [Route("Get")]
    public async Task<CustomerDto> GetAsync(int id, CancellationToken cancellationToken)
    {
        var customer = await _mediator.Send(new GetCustomerRequest(id), cancellationToken);
        return _mapper.CustomerToCustomerDto(customer);
    }

    [HttpGet]
    [Route("GetAll")]
    public async Task<List<CustomerDto>> GetAllAsync(CancellationToken cancellationToken)
    {
        var customers = await _mediator.Send(new GetAllCustomerRequest(), cancellationToken);
        return _mapper.CustomersToCustomerDtos(customers);
    }

    [HttpPost]
    [Route("Create")]
    public async Task<CustomerDto> CreateAsync(Customer customer, CancellationToken cancellationToken)
    {
        var customers = await _mediator.Send(new AddCustomerRequest(customer),cancellationToken);
        return _mapper.CustomerToCustomerDto(customers);
    }

    [HttpPut]
    [Route("Update")]
    public async Task<CustomerDto> UpdateAsync(Customer customer, CancellationToken cancellationToken)
    {
        var customers = await _mediator.Send(new UpdateCustomerRequest(customer), cancellationToken);
        return _mapper.CustomerToCustomerDto(customers);
    }

    [HttpDelete]
    [Route("Delete")]
    public async Task<CustomerDto> DeleteAsync(Customer customer, CancellationToken cancellationToken)
    {
        var customers = await _mediator.Send(new RemoveCarRequest(customer), cancellationToken);
        return _mapper.CustomerToCustomerDto(customers);
    }
}
