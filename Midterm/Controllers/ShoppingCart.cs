using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class ShoppingCart
    {
        //List containing ordered items
        public static List<ShoppingCartItem> Cart { get; set; }

        //Call to get total due before tax
        public static double GetTotal()
        {
            double total = 0.00;
            foreach (ShoppingCartItem x in Cart)
            {
                total += x.Product.Price * x.Qty;
            }
            return total;
        }
        
        //Checks the list "Cart" to see if the new item matches an existing item
        //If it does, the Qty is added
        //If it does not, the item is added to the list
        public static void AddToCart(ShoppingCartItem newItem)
        {
            if (Cart.Count > 0)
            {
                bool contains = false;
                foreach (ShoppingCartItem s in Cart)
                {
                    if (s.Product.Name==newItem.Product.Name)
                    {
                        s.Qty += newItem.Qty;
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
