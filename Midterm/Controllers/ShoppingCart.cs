using Midterm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    class ShoppingCart
    {
        //List containing ordered items
        public static List<ShoppingCartItem> Cart { get; set; }

        public static void InitCart()
        {
            if (Cart == null)
                Cart = new List<ShoppingCartItem>();
        }

        public static double GetSubtotal()
        {
            double total = 0.00;
            foreach (ShoppingCartItem item in Cart)
            {
                total += item.Product.Price * item.Qty;
            }
            return total;
        }

        public static double GetTax()
        {
            double tax = GetSubtotal() * .06;
            return tax;
        }

        public static double GetTotal()
        {
            return GetSubtotal() + GetTax();
        }
        
        //Checks the list "Cart" to see if the new item matches an existing item
        //If it does, the Qty is added
        //If it does not, the item is added to the list
        public static void AddToCart(ShoppingCartItem newItem)
        {
            if (Cart.Count > 0)
            {
                bool contains = false;
                foreach (ShoppingCartItem item in Cart)
                {
                    if (item.Product.Name == newItem.Product.Name)
                    {
                        item.Qty += newItem.Qty;
                        contains = true;
                        break;
                    }
                }
                if (!contains)
                {
                    Cart.Add(newItem);
                }
            }
            else
            {
                Cart.Add(newItem);
            }
        }
    }
}
