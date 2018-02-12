using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class ShoppingCartItem
    {
        public Product Product { get; set; }
        public int Qty { get; set; }

        public ShoppingCartItem(Product product, int qty)
        {
            this.Product = product;
            this.Qty = qty;
        }
    }
}