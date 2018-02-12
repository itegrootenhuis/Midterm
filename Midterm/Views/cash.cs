using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Midterm
{
    public class CashPayment : IPayment
    {
        //TODO make change and validate

        double CashTendered { get; set; }

        public bool ValidPayment()
        {
            Console.WriteLine("Enter amount amout to be tendered");
            CashTendered = double.Parse(Console.ReadLine());
            return true;
        }
    }
}