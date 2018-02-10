using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public class Cardpayment : payment
    {
        public bool MakePayment(double amount)
        {
            Console.Write("Enter the card Number :");
            string cardNum = Console.ReadLine();
            Console.Write("Security code: ");
            string security = Console.ReadLine();
            Console.WriteLine("CVV #");
            string cvv = Console.ReadLine();
            Console.WriteLine("card number :  valid");
            Console.WriteLine("account credited");

            return true;
        }
    }
}