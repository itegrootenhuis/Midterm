using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Midterm
{
    //TODO Validate card information entered

    public class Cardpayment : IPayment
    {
        string CVV { get; set; }
        string CardNum { get; set; }
        string Security {get; set;}


        public bool ValidPayment()
        {
            Console.Write("Enter the card Number :");
            CardNum = Console.ReadLine();


            Console.Write("Security code: ");
            Security = Console.ReadLine();

            Console.WriteLine("CVV #");
            CVV = Console.ReadLine();

            Console.WriteLine("card number :  valid");
            Console.WriteLine("account credited");

            return true;
        }
    }
}