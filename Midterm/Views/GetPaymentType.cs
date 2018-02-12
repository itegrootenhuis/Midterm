using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public static class GetPaymentType
    {

        public static void GetPaymentView()
        {
            Console.Write("Enter the payment amount: ");
            Amount = double.Parse(Console.ReadLine());

            Console.WriteLine("1- Cash");
            Console.WriteLine("2- Card");
            Console.WriteLine("3- Check");
            Option = Console.ReadLine();
        }

        public static double Amount { get; private set;}
        public static string Option { get; private set; }
    }
}
