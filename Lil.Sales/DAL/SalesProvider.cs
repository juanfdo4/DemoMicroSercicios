using Lil.Sales.Models;
using Microsoft.AspNetCore.DataProtection.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lil.Sales.DAL
{
    public class SalesProvider : ISalesProvider
    {
        private List<Order> repo = new List<Order>();
        public SalesProvider()
        {
            repo.Add(new Order()
            {
                id = "0001",
                CustomerId = "1",
                OrderDate = DateTime.Now.AddMonths(-1),
                Total = 100,
                Items = new List<OrderItem>() {
                    new OrderItem (){OrderId="0001", Id=1, Price=50, ProductoId="23"},
                    new OrderItem (){OrderId="0001", Id=2, Price=50, ProductoId="24"}
                }
            });

            repo.Add(new Order()
            {
                id = "0002",
                CustomerId = "2",
                OrderDate = DateTime.Now.AddMonths(-4),
                Total = 100,
                Items = new List<OrderItem>() {
                    new OrderItem (){OrderId="0002", Id=1, Price=50, ProductoId="26"},
                    new OrderItem (){OrderId="0002", Id=2, Price=50, ProductoId="27"}
                }
            });

            repo.Add(new Order()
            {
                id = "0003",
                CustomerId = "2",
                OrderDate = DateTime.Now.AddMonths(-4),
                Total = 100,
                Items = new List<OrderItem>() {
                    new OrderItem (){OrderId="0003", Id=1, Price=50, ProductoId="30"},
                    new OrderItem (){OrderId="0003", Id=2, Price=50, ProductoId="31"}
                }
            });

            repo.Add(new Order()
            {
                id = "0004",
                CustomerId = "3",
                OrderDate = DateTime.Now.AddMonths(-2),
                Total = 100,
                Items = new List<OrderItem>() {
                    new OrderItem (){OrderId="0004", Id=1, Price=50, ProductoId="28"},
                    new OrderItem (){OrderId="0004", Id=2, Price=50, ProductoId="29"}
                }
            });
        }
        public Task<ICollection<Order>> GetAsync(string customerId)
        {
            var orders = repo.Where(c => c.CustomerId == customerId).ToList();
            return Task.FromResult((ICollection<Order>)orders);
        }
    }
}
