using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public static class GetPaymentType
    {
        public static string GetPaymentView()
        {
            Console.Write("Enter the payment amount: ");
            double amount = double.Parse(Console.ReadLine());

            Console.WriteLine("1- Cash");
            Console.WriteLine("2- Card");
            Console.WriteLine("3- Check");
            string option = Console.ReadLine();
            return option;
        }
    }
}
