using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Lil.Search.Models
{
    public class Order
    {
        [JsonPropertyName("id")]
        public string id { get; set; }
        [JsonPropertyName("orderdate")]
        public DateTime OrderDate { get; set; }
        [JsonPropertyName("customerid")]
        public string CustomerId { get; set; }
        [JsonPropertyName("total")]
        public double Total { get; set; }
        [JsonPropertyName("items")]
        public List<OrderItem> Items { get; set; }
    }
}
