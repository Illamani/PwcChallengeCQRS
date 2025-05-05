using Riok.Mapperly.Abstractions;
using RentalCar.Domain.Entities;
using RentalCar.Domain.Dto;

namespace RentalCar.Domain.Mapper
{
	[Mapper]
	public partial class CustomerMapper
	{
		public partial Customer CustomerDtoToCustomer(CustomerDto customerDto);

		public partial List<Customer> CustomerDtosToCustomers(List<CustomerDto> customerDtos);

		public partial CustomerDto CustomerToCustomerDto(Customer customer);

		public partial List<CustomerDto> CustomersToCustomerDtos(List<Customer> customers);
	}
}
