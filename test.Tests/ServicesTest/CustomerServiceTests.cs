using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.Services;
namespace test.Tests.ServicesTest
{
    public class CustomerServiceTests
    {
        [Fact]
        public void CustomerService_GetCustomer_ReturnUsersList() {
            //Arrange -varibles, clases, mocks
            var customerService = new CustomerService();
            var expectedResult = new List<string> { "Jhoa" };

            //Act
            var customers = customerService.GetCustomers("Jhoan");

            //Assert
            customers.Should().Equal(expectedResult);
        }
    }
}
