using NUnit.Framework;
using WebRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;

namespace WebRequest.Tests
{
    [TestFixture]
    public class CustomerServiceTests
    {
        [Test()]
        public void Will_Return_Customer_FullName()
        {
            ICustomerRepository customerRepository = Substitute.For<ICustomerRepository>();
            customerRepository.GetCustomerById(1).Returns(new Customer() { FirstName = "John", LastName = "Smith" });

            CustomerService customerService = new CustomerService(customerRepository);

            string fullName = customerService.GetFullName(1);

            Assert.AreEqual("John Smith", fullName);
        }
    }
}