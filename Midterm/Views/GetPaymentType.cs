using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controllers;

namespace Midterm
{
    public static class GetPaymentType
    {
        public static string Option { get; private set; }
        //public static double Amount { get; private set;}

        public static void GetPaymentView()
        {
            Console.WriteLine("Ammount owed is {0:C}.", ShoppingCart.GetTotal());
            //Amount = double.Parse(Console.ReadLine());

            Console.WriteLine("1- Cash");
            Console.WriteLine("2- Card");
            Console.WriteLine("3- Check");
            Option = Console.ReadLine();
        }
    }
}
