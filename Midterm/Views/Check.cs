using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Midterm

{
    public class CheckPayment : payment
    {
        public bool MakePayment(double amount)
        {
            Console.Write("Enter the check number :");
            string checknum = Console.ReadLine();
            return true;
        }
    }
}
