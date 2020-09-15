using Lil.Customers.Controllers;
using Lil.Customers.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lil.Customers.Tests
{
    [TestClass]
    public class CustomersTest
    {
        [TestMethod]
        public void GetAsyncReturnsOk()
        {
            var customerProvider = new CustomersProvider();
            var customerController = new CustomersController(customerProvider);

            var result = customerController.GetAsync("1");

            Assert.IsNotNull(result);

        }
        [TestMethod]
        public void GetAsyncReturnsNotFound()
        {
            var customerProvider = new CustomersProvider();
            var customerController = new CustomersController(customerProvider);

            var result = customerController.GetAsync("9");

            Assert.IsNotNull(result);
        }
    }
}
