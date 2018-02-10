using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public class CashPayment : payment
    {
        public bool MakePayment(double amount)
        {
            Console.WriteLine("Succes, account credited");
            return true;
        }
    }
}