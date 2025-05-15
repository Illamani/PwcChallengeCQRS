using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentalCar.Application.Features.RentalFeatures.Add;
using RentalCar.Application.Features.RentalFeatures.Get;
using RentalCar.Domain.Dto;
using RentalCar.Domain.Entities;
using RentalCar.Domain.Mapper;

namespace RentalCar.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RentalController(IMediator mediator) : ControllerBase
{
    private readonly RentalMapper _mapper = new();
    private readonly IMediator _mediator = mediator;

    [HttpGet]
    [Route("Get")]
    public async Task<RentalDto> GetAsync(int id, CancellationToken cancellationToken)
    {
        var rental = await _mediator.Send(new GetRentalRequest(id), cancellationToken);
        return _mapper.RentalToRentalDto(rental);
    }

    [HttpGet("GetAll")]
    public async Task<List<RentalDto>> GetAll(CancellationToken cancellationToken)
    {
        var rentals = await _mediator.Send(new GetAllRentalRequest(), cancellationToken);
        return _mapper.RentalsToRentalDtos(rentals);
    }

    [HttpDelete("Delete")]
    public async Task<RentalDto> DeleteAsync(Rental rental, CancellationToken cancellationToken)
    {
        var rentals = await _mediator.Send(new RemoveRentalRequest(rental), cancellationToken);
        return _mapper.RentalToRentalDto(rentals);
    }

    [HttpPut("Update")]
    public async Task<RentalDto> UpdateAsync(Rental rental, CancellationToken cancellationToken)
    {
        var rentals = await _mediator.Send(new UpdateRentalRequest(rental), cancellationToken);
        return _mapper.RentalToRentalDto(rentals);
    }

    [HttpPost("Create")]
    public async Task<RentalDto> CreateAsync(Rental rental, CancellationToken cancellationToken)
    {
        var rentals = await _mediator.Send(new AddRentalRequest(rental), cancellationToken);
        return _mapper.RentalToRentalDto(rentals);
    }
}
