using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Product(string name, string category, string description, double price)
        {
            this.Name = name;
            this.Category = category;
            this.Description = description;
            this.Price = price;
        }
    }
}
