using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Views;

namespace Controllers
{
    public class AppNavigater
    {
        internal static void InitApp()
        {
            WriteToConsole.WriteProducts(HandleJsonData.GetProducts());
            WriteToConsole.GetUserProduct();

            if (WriteToConsole.CheckOutOrNot() == "y")
            {
                Console.Clear();
                InitApp();
            }
            else
            { 
                //TODO: checkout 
            }
        }

        public static void AddProductToCart(int userInput)
        {
            //TODO
        }

    }
}
