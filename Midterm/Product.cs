using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Product
    {
        private string Name { get; set; }
        private string Category { get; set; }
        private string Description { get; set; }
        private string Price { get; set; }

        public Product(string name, string category, string description, string price)
        {
            Name = name;
            Category = category;
            Description = description;
            Price = price;
        }
    }
}
