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
        internal static void WriteProducts(ProductsList productsList)
        {
            List<Product> products = productsList.ProductList;
            int counter = 0;

            foreach (Product prod in products)
            {
                counter++;
                Console.WriteLine("{4} : {0}\t{1}\t{2}\t{3}", prod.Name, prod.Category, prod.Description, prod.Price, counter);
            }
        }

        internal static string CheckOutOrNot()
        {
            Console.Write("Would you like to check out? (Y/N): ");
            string continueShopping = Console.ReadLine();
            return continueShopping.ToLower();
        }

        internal static void GetUserProduct()
        {
            int userInput;

            Console.Write("Choose a product by the number: ");
            bool bit = int.TryParse(Console.ReadLine(), out userInput);

            if (bit)
                AppNavigater.AddProductToCart(userInput);
            else
            {
                Console.Clear();
                Console.WriteLine("Your input was invalid");
                GetUserProduct();
            }
        }
    }
}
