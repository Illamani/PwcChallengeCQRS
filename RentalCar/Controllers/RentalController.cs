using Microsoft.AspNetCore.Mvc;
using RentalCar.Application.Service;
using RentalCar.Domain.Dto;
using RentalCar.Domain.Entities;
using RentalCar.Domain.Mapper;

namespace RentalCar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalController(IRentalService rentalService) : ControllerBase
    {
        private readonly RentalMapper _mapper = new();

        [HttpGet]
        [Route("Get")]
        public async Task<RentalDto> Get(int id, CancellationToken cancellationToken)
        {
            var rental = await rentalService.Get(id, cancellationToken);
            return _mapper.RentalToRentalDto(rental);
        }

        [HttpGet("GetAll")]
        public async Task<List<RentalDto>> GetAll(CancellationToken cancellationToken)
        {
            var rentals = await rentalService.GetAll(cancellationToken);
            return _mapper.RentalsToRentalDtos(rentals);
        }

        [HttpDelete("Delete")]
        public void Delete(Rental rental)
        {
            rentalService.Delete(rental);
        }

        [HttpPut("Update")]
        public void Update(Rental rental)
        {
            rentalService.Update(rental);
        }

        [HttpPost("Create")]
        public void Create(Rental rental)
        {
            rentalService.Create(rental);
        }
    }
}
