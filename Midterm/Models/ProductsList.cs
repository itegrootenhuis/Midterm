using Midterm;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ProductsList
    {
        [JsonProperty("products")]
        public List<Product> ProductList { get; set; }
    }
}
