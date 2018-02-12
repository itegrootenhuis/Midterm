using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Views;
using Midterm;

namespace Controllers
{
    public class AppNavigater
    {
        internal static void InitApp()
        {
            ShoppingCart.InitCart();
            WriteToConsole.WriteProducts(HandleJsonData.GetProducts());
            WriteToConsole.GetUserProduct();

            if (WriteToConsole.CheckOutOrNot() == "n")
            {
                Console.Clear();
                InitApp();
            }
            else
            { 
                //TODO: checkout 
            }
        }

        public static void AddProductToCart(int userInput, int qty)
        {
            ProductsList productsList = HandleJsonData.GetProducts();
            List<Product> products = productsList.ProductList;

            ShoppingCartItem cartItem = new ShoppingCartItem(products[userInput - 1], qty);
            ShoppingCart.AddToCart(cartItem);
        }
    }
}
