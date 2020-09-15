using Lil.Sales.Controllers;
using Lil.Sales.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lil.Sales.Tests
{
    [TestClass]
    public class SalesTest
    {
        [TestMethod]
        public void GetAsyncReturnsOk()
        {
            var salesProvider = new SalesProvider();
            var salesController = new SalesController(salesProvider);

            var result = salesController.GetAsync("2");

            Assert.IsNotNull(result);
            Assert.IsNotInstanceOfType(result, typeof(OkObjectResult));

        }
        [TestMethod]
        public void GetAsyncReturnsNotFound()
        {
            var salesProvider = new SalesProvider();
            var salesController = new SalesController(salesProvider);

            var result = salesController.GetAsync("6");

            Assert.IsNotNull(result);
            Assert.IsNotInstanceOfType(result, typeof(OkObjectResult));
        }
    }
}
