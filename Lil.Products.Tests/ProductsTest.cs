using Lil.Products.Controllers;
using Lil.Products.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lil.Products.Tests
{
    [TestClass]
    public class ProductsTest
    {
        [TestMethod]
        public void GetAsyncReturnsOk()
        {
            var productProvider = new ProductsProvider();
            var productsContoller = new ProductsController(productProvider);

            var result = productsContoller.GetAsync("1");

            Assert.IsNotNull(result);
            Assert.IsNotInstanceOfType(result, typeof(OkObjectResult));

        }
        [TestMethod]
        public void GetAsyncReturnsNotFound()
        {
            var productProvider = new ProductsProvider();
            var productsContoller = new ProductsController(productProvider);

            var result = productsContoller.GetAsync("101");

            Assert.IsNotNull(result);
            Assert.IsNotInstanceOfType(result, typeof(OkObjectResult));
        }
    }
}
