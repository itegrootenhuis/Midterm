using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Controllers;

namespace Views
{
    public class CashPayment
    {
        public static double CashTendered { get; set; }
        public static double Change { get; set; }

        public static void ValidPayment()
        {
            bool CashParse;
            Console.WriteLine("Enter cash amount to be tendered");

            CashParse = double.TryParse(Console.ReadLine(), out double VCashTendered);
            if (CashParse)
            {
                if (VCashTendered < ShoppingCart.GetTotal())
                {
                    Console.WriteLine("Not enough money for payment");
                    ValidPayment();
                }
                else
                {
                    CashTendered = VCashTendered;
                    Change = CashTendered - ShoppingCart.GetTotal();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input");
                ValidPayment();
            } 
        }
    }
}