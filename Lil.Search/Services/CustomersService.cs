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
    public class CustomersService : ICustomersService
    {
        private readonly IHttpClientFactory httpClientFactory;
        public CustomersService(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }
        public async Task<Customer> GetAsync(string id)
        {

            try
            {
                var client = httpClientFactory.CreateClient("customerService");

                var response = await client.GetAsync($"api/customers/{id}");

                if (response.IsSuccessStatusCode)
                {
                    var conten = await response.Content.ReadAsStringAsync();
                    var customer = JsonSerializer.Deserialize<Customer>(conten);
                    return customer;
                }
                return null;
            }
            catch (Exception ex)
            {

                throw;
            }
               
        }


    }
}
