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
        public static bool cartHasProducts = false;

        internal static void WriteProducts(ProductsList productsList)
        {
            counter = 0;
            List<Product> products = productsList.ProductList;
            
            foreach (Product prod in products)
            {
                counter++;
                Console.WriteLine("{4, 2} : {0, -32}{1, -10:c}{2, -20}{3, -10}", prod.Name, prod.Price, prod.Category, prod.Description, counter);
            }
            
            if(cartHasProducts)
            {
                counter++;
                int cartQty = 0;

                foreach (ShoppingCartItem item in ShoppingCart.Cart)
                {
                    cartQty += item.Qty;
                }
                Console.WriteLine("\n{0, 2} : You have {1} item(s) in your cart, select this option to checkout.", counter, cartQty);
            }
        }

        internal static void GetUserProduct()
        {
            Console.WriteLine("\nEnter a product number to add it to your cart: ");
            bool bit = int.TryParse(Console.ReadLine(), out int userInput);

            if(bit && cartHasProducts && userInput == counter)
            {
                AppNavigater.CheckOut(true);
            }
            else if (bit && userInput <= counter)
            {
                cartHasProducts = true;
                AppNavigater.AddProductToCart(userInput, GetQuantity());
                Console.Clear();
                AppNavigater.InitApp();
            }
            else
            {
                InvalidInput();
            }
        }

        private static void InvalidInput()
        {
            Console.Clear();
            Console.WriteLine("Your input was invalid\n\n");
            AppNavigater.InitApp();
        }

        private static int GetQuantity()
        {
            Console.Write("How many would you like: ");
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
            Console.Write("\nWould you like to check out? (Y/N): ");
            string continueShopping = Console.ReadLine();
            return continueShopping.ToLower();
        }

        public static void PrintReceipt()
        {
            ItemSummary();
            PaymentSummary();
            Console.WriteLine("\nThank you for shopping at The General Store!");
            cartHasProducts = false;
        }

        public static void ItemSummary()
        {
            Console.WriteLine("\nItem Summary:\n====================");
            foreach (ShoppingCartItem prod in ShoppingCart.Cart)
            {
                Console.WriteLine("{0} X {1} | {2, 7:C}", prod.Qty, prod.Product.Name, (prod.Qty * prod.Product.Price));
            }

            Console.WriteLine("\nSubtotal: {0:C}", ShoppingCart.GetSubtotal());
            Console.WriteLine("Tax: {0:C}", ShoppingCart.GetTax());
            Console.WriteLine("Total: {0:C}", ShoppingCart.GetTotal());
        }

        public static void PaymentSummary()
        {
            Console.WriteLine("\nPayment type: {0}", PaymentTypeController.PaymentOption);
            if (PaymentTypeController.PaymentOption.ToLower() == "check")
            {
                Console.WriteLine("Charged to check number: {0}", CheckPayment.CheckNum);
            }
            else if (PaymentTypeController.PaymentOption.ToLower() == "card")
            {
                Console.WriteLine("Charged to card number: XXXX-XXXX-XXXX-{0}", Cardpayment.CardNum.Substring(12,4));
                Console.WriteLine("Exp: {0}", Cardpayment.ExpDate);
                Console.WriteLine("CVV: {0}", Cardpayment.CVV);
            }
            //Cash Payment
            else
            {
                Console.WriteLine("Cash tendered: {0:C}", CashPayment.CashTendered);
                Console.WriteLine("Change due: {0:C}", CashPayment.Change);
            }
        }

        internal static void GoodBye()
        {
            Console.WriteLine("\nThank you for shopping at the General Store, press any key to exit.");
            Console.ReadKey();
        }

        internal static string ShopAgain()
        {
            Console.WriteLine("\nPress Y to shop again or press any other key to exit the app: ");
            string shopAgain = Console.ReadLine();

            return shopAgain.ToLower();
        }
    }
}
