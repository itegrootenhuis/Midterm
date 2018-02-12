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
        }

        public static void CheckOut(bool IsCheckout)
        {
            if (IsCheckout)
            {
                PaymentTypeController.GetPayment();
                WriteToConsole.PrintReceipt();

                if (WriteToConsole.ShopAgain() == "y")
                {
                    ShoppingCart.Cart.Clear();
                    Console.Clear();
                    InitApp();
                }
                else
                {
                    WriteToConsole.GoodBye();
                }
            }
            else
            {
                Console.Clear();
                InitApp();
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
