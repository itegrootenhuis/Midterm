﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Midterm

{
    class PaymentTypeController
    {
        
        public static void init()
        {
            GetPaymentType.GetPaymentView();
            PaymentType(GetPaymentType.Option, GetPaymentType.Amount);
        }



        public static void PaymentType(string option, double amount)
        {
        

            switch (option)
            {
                case "1":

                    CashPayment cash = new CashPayment();
                        
                      cash.ValidPayment();
                    break;

                case "2":
                   Cardpayment card = new Cardpayment();
                   
                    card.ValidPayment();
                    break;

                case "3":
                     CheckPayment check = new CheckPayment();
                    check.ValidPayment();
                    break;

                default:
                    Console.WriteLine("invalid entry");
                    break;
            }

            Console.ReadKey();

        }
    }
}
