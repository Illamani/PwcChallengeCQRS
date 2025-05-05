using Microsoft.AspNetCore.Mvc;
using RentalCar.Application.Service;
using RentalCar.Domain.Dto;
using RentalCar.Domain.Entities;
using RentalCar.Domain.Mapper;

namespace RentalCar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController(ICustomerService _customerService) : ControllerBase
    {
        private readonly CustomerMapper _mapper = new();

        [HttpGet]
        [Route("Get")]
        public async Task<CustomerDto> Get(int id, CancellationToken cancellationToken)
        {
            var customer = await _customerService.Get(id, cancellationToken);
            return _mapper.CustomerToCustomerDto(customer);
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<List<CustomerDto>> GetAll(CancellationToken cancellationToken)
        {
            var customers = await _customerService.GetAll(cancellationToken);
            return _mapper.CustomersToCustomerDtos(customers);
        }

        [HttpPost]
        [Route("Create")]
        public void Create(Customer customer)
        {
            _customerService.Create(customer);
        }

        [HttpPut]
        [Route("Update")]
        public void Update(Customer customer)
        {
            _customerService.Update(customer);
        }

        [HttpDelete]
        [Route("Delete")]
        public void Delete(Customer customer)
        {
            _customerService.Delete(customer);
        }
    }
}
