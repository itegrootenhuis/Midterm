using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Midterm

{
    class PaymentTypeController
    {
        
        public static void CashChange(double CashTendered, double amountPaid)
        {
            double change = CashTendered - amountPaid;
            //50 - 12.50 => 37.50
            //20
            //10
            //5
            //2x 1s


            while (CashTendered > 0)
            {
                if (CashTendered >= 50)
                {
                    Console.Write("50 ");
                    CashTendered -= 50;
                }
                else
                {
                    if (CashTendered >= 20)
                    {
                        Console.Write("20 ");
                        CashTendered -= 20;
                    }
                    else
                    {
                        if (CashTendered >= 10)
                        {
                            Console.Write("10 ");
                            CashTendered -= 10;
                        }
                        else
                        {
                            if (CashTendered >= 5)
                            {
                                Console.Write("5 ");
                                CashTendered -= 5;
                            }
                            else
                            {
                                if (CashTendered >= 2)
                                {
                                    Console.Write("2 ");
                                    CashTendered -= 2;
                                }
                                else
                                {
                                    Console.Write("1 ");
                                    CashTendered -= 1;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }



    


        public static void init()
        {
            GetPaymentType.GetPaymentView();
            PaymentType(GetPaymentType.Option, GetPaymentType.Amount);
        }

        public static bool IsCardNumberValid(string cardNumber)
        {
            int i, checkSum = 0;

            // Compute checksum of every other digit starting from right-most digit
            for (i = cardNumber.Length - 1; i >= 0; i -= 2)
                checkSum += (cardNumber[i] - '0');

            // Now take digits not included in first checksum, multiple by two,
            // and compute checksum of resulting digits
            for (i = cardNumber.Length - 2; i >= 0; i -= 2)
            {
                int val = ((cardNumber[i] - '0') * 2);
                while (val > 0)
                {
                    checkSum += (val % 10);
                    val /= 10;
                }
            }

            // Number is valid if sum of both checksums MOD 10 equals 0
            return ((checkSum % 10) == 0);
        }

        public static string NormalizeCardNumber(string cardNumber)
        {
            if (cardNumber == null)
                cardNumber = String.Empty;

            StringBuilder sb = new StringBuilder();

            foreach (char c in cardNumber)
            {
                if (Char.IsDigit(c))
                    sb.Append(c);
            }

            return sb.ToString();
        }


        public static void PaymentType(string option, double amount)
        {
        

            switch (option)
            {
                case "1":

                    CashPayment cash = new CashPayment();
            MakeChange(cash.CashTendered, amount);
                      cash.ValidPayment();
            //cash.MakeChange(amount);
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
