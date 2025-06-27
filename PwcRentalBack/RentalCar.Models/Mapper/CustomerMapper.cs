using Riok.Mapperly.Abstractions;
using RentalCar.Domain.Entities;
using RentalCar.Domain.Dto.Customer;

namespace RentalCar.Domain.Mapper
{
	[Mapper]
	public partial class CustomerMapper
	{
		public partial Customer CustomerDtoToCustomer(CustomerDto customerDto);

		public partial List<Customer> CustomerDtosToCustomers(List<CustomerDto> customerDtos);

		public partial CustomerDto CustomerToCustomerDto(Customer customer);

		public partial List<CustomerDto> CustomersToCustomerDtos(List<Customer> customers);

		public partial Customer CustomerInputToCustomer(CustomerInput customerInput);

		public partial List<Customer> CustomerInputsToCustomers(List<CustomerInput> customerInput);

		public partial CustomerInput CustomerToCustomerInput(Customer customer);

		public partial List<CustomerInput> CustomersToCustomerInputs(Customer customer);
	}
}
