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
        //TODO make change and validate

        public static double CashTendered { get; set; }
        public static double Change { get; set; }



        public static void ValidPayment()
        {
            double VCashTendered;
            bool CashParse;
            Console.WriteLine("Enter amount to be tendered");
            string CashInput = Console.ReadLine();

            CashParse = double.TryParse(CashInput, out VCashTendered);
            if (CashParse)
                
            {

                if (CashTendered < ShoppingCart.GetTotal())
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