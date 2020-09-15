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
    public class ProductsService : IProductsService
    {
        private readonly IHttpClientFactory httpClientFactory;
        public ProductsService(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }
        public async Task<Product> GetAsync(string id)
        {
            var client = httpClientFactory.CreateClient("productService");

            var response = await client.GetAsync($"api/products/{id}");

            if (response.IsSuccessStatusCode) {
                var conten = await response.Content.ReadAsStringAsync();
                var product = JsonSerializer.Deserialize<Product>(conten);
                return product;
            }
            return null;
        }

    }
}
