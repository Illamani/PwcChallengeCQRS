using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentalCar.Application.Features.CarFeatures.Add;
using RentalCar.Application.Features.CarFeatures.Get;
using RentalCar.Domain;
using RentalCar.Domain.Dto;
using RentalCar.Domain.Entities;

namespace RentalCar.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CarController(IMediator mediator) : ControllerBase
{
    private readonly CarMapper _mapper = new();
    private readonly IMediator _mediator = mediator;

    [HttpPost]
    [Route("CreateCar")]
    public async Task<CarDto> CreateCarAsync(Car car,CancellationToken cancellationToken)
    {
        var carReturn = await _mediator.Send(new AddCarRequest(car), cancellationToken);
        return _mapper.CarToCarDto(carReturn);
    }

    [HttpGet]
    [Route("GetAllCar")]
    public async Task<List<CarDto>> GetCarsAsync(CancellationToken cancellationToken)
    {
        var cars = await _mediator.Send(new GetAllCarRequest(), cancellationToken);
        return _mapper.CarsToCarsDto(cars);
    }

    [HttpGet]
    [Route("GetCar")]
    public async Task<CarDto> GetCarAsync(int id, CancellationToken cancellationToken)
    {
        var car = await _mediator.Send(new GetCarRequest(id), cancellationToken);
        return _mapper.CarToCarDto(car);
    }

    [HttpDelete]
    [Route("DeleteCar")]
    public async Task<CarDto> DeleteCarAsync(Car car, CancellationToken cancellationToken)
    {
        var carModel = await _mediator.Send(new RemoveCarRequest(car), cancellationToken);
        return _mapper.CarToCarDto(carModel);
    }

    [HttpPut]
    [Route("UpdateCar")]
    public async Task<CarDto> UpdateCarAsync(Car car, CancellationToken cancellationToken)
    {
        var carModel = await _mediator.Send(new UpdateCarRequest(car), cancellationToken);
        return _mapper.CarToCarDto(carModel);
    }
}
