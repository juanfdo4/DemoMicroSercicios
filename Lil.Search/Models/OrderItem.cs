using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Lil.Search.Models
{
    public class OrderItem
    {
        [JsonPropertyName("orderid")]
        public string OrderId { get; set; }
        public int Id{ get; set; }
        [JsonPropertyName("productoid")]
        public string ProductoId { get; set; }
        public int Quantity { get; set; }
        [JsonPropertyName("price")]
        public double Price { get; set; }

        [JsonPropertyName("product")]
        public Product Product { get; set; }
    }
}
