using Midterm;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controllers;

namespace Views
{
    public static class WriteToConsole
    {
        public static int counter = 0;

        internal static void WriteProducts(ProductsList productsList)
        {
            counter = 0;
            List<Product> products = productsList.ProductList;
            
            foreach (Product prod in products)
            {
                counter++;
                Console.WriteLine("{4, 2} : {0, -32}{1, -10:c}{2, -20}{3, -10}", prod.Name, prod.Price, prod.Category, prod.Description, counter);
            }
            
            if(ShoppingCart.Cart.Count > 0)
            {
                counter++;
                Console.WriteLine("{0, 2} : You have {1} item(s) in your cart, select this option to checkout.", counter, ShoppingCart.Cart.Count);
            }
        }

        internal static void GetUserProduct()
        {
            Console.WriteLine("\nEnter a product number to add it to your cart: ");
            bool bit = int.TryParse(Console.ReadLine(), out int userInput);

            if (bit && ShoppingCart.Cart.Count >= 0 && userInput != counter)
            {
                AppNavigater.AddProductToCart(userInput, GetQuantity());
                Console.Clear();
                AppNavigater.InitApp();
            }
            else if (bit && ShoppingCart.Cart.Count > 0 && userInput == counter)
            {
                AppNavigater.CheckOut(true);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Your input was invalid");
                AppNavigater.InitApp();
            }
        }

        private static int GetQuantity()
        {
            Console.Write("How many do you want?: ");
            bool bit = int.TryParse(Console.ReadLine(), out int qty);

            if (bit)
            {
                return qty;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Your input was invalid");
                return GetQuantity();
            }
        }

        internal static string CheckOutOrNot()
        {
            Console.Write("Would you like to check out? (Y/N): ");
            string continueShopping = Console.ReadLine();
            return continueShopping.ToLower();
        }

        public static void PrintReceipt()
        {
            Console.WriteLine("Receipt:\n====================");
            foreach (ShoppingCartItem prod in ShoppingCart.Cart)
            {
                Console.WriteLine("{0} X {1} | {2, 7:C}", prod.Qty, prod.Product.Name, (prod.Qty * prod.Product.Price));
            }
            Console.WriteLine("\nSubtotal: {0:C}" + ShoppingCart.GetSubtotal());
            Console.WriteLine("Tax: {0:C}", ShoppingCart.GetTax());
            Console.WriteLine("Total: {0:C}", ShoppingCart.GetTotal());
            Console.WriteLine("/nPayment type: {0}", /*PaymentType Global Variable*/);
            if (/*payment type == check*/)
            {
                Console.WriteLine("Charged to check number: {0}", /*CheckNumber Global Variable*/);
            }
            else if (/*payment type == card*/)
            {
                Console.WriteLine("\nCharged to card number: {0}", /*CardNumber Global Variable*/);
                Console.WriteLine("Exp: {0}", /*CardExpDate Global Variable*/);
                Console.WriteLine("CVV: {0}", /*CardCVV Global Variable*/);
            }
            //Cash Payment
            else
            {
                Console.WriteLine("\nCash tendered: {0}", /*CashTendered Global Variable*/);
                Console.WriteLine("Change due: {0}", /*Change Global Variable*/);
            }
            Console.WriteLine("Thank you for shopping at The General Store!");
        }
    }
}
