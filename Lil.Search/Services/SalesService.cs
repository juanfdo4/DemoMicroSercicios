using Lil.Search.Interfaces;
using Lil.Search.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lil.Search.Services
{
    public class SalesService : ISalesService
    {
        private readonly IHttpClientFactory httpClientFactory;
        public SalesService(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;

        }
        public async Task<ICollection<Order>> GetAsync(string id)
        {
            var client = httpClientFactory.CreateClient("salesService");

            var response = await client.GetAsync($"api/sales/{id}");

            if (response.IsSuccessStatusCode)
            {
                var conten = await response.Content.ReadAsStringAsync();
                var order = JsonSerializer.Deserialize<ICollection<Order>>(conten);
                return order;
            }
            return null;
        }
    }


}
