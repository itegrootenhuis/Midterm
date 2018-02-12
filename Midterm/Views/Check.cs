using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;


namespace Midterm

{
    public class CheckPayment : IPayment
    {
        public string CheckNum { get; set; }
        public bool ValidPayment()
        {
            Console.Write("Enter the check number :");
            CheckNum = Console.ReadLine();
            return true;
        }
    }
}
