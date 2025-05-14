using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentalCar.Application.Features.CarFeatures.Get;
using RentalCar.Application.Service;
using RentalCar.Domain;
using RentalCar.Domain.Dto;
using RentalCar.Domain.Entities;

namespace RentalCar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController(ICarService carService, IMediator mediator) : ControllerBase
    {
        private readonly CarMapper _mapper = new();
        private readonly IMediator _mediator = mediator;

        [HttpPost]
        [Route("CreateCar")]
        public void CreateCar(Car car)
        {
            carService.Create(car);
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
        public void DeleteCar(Car car)
        {
            carService.Delete(car);
        }

        [HttpPut]
        [Route("UpdateCar")]
        public void UpdateCar(Car car)
        {
            carService.Update(car);
        }
    }
}
