using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class PaymentTypeController
    {
        public static string PaymentOption { get; set; }

        public static void GetPayment()
        {
            GetPaymentType.GetPaymentView();
            PaymentType(GetPaymentType.Option); //GetPaymentType.Amount
        }

        public static void PaymentType(string option)
        {
            switch (option)
            {
                case "1":
                    CashPayment.ValidPayment();
                    PaymentOption = "Cash";
                    break;

                case "2":
                    Cardpayment.ValidPayment();
                    PaymentOption = "Card";
                    break;

                case "3":
                    CheckPayment.ValidPayment();
                    PaymentOption = "Check";
                    break;

                default:
                    Console.WriteLine("invalid entry");
                    break;
            }
            //Console.ReadKey();
        }

        // ALL THE CODE LISTED BELOW WILL CHECK IF It IS A REAL LIFE WORKING CREDIT CARD
        // BUT WE DECIDED WE PROBABLY SHOULDNT HAVE YOU ENTERING YOUR REAL CREDIT CARD INFO
        //public static bool IsCardNumberValid(string cardNumber)
        //{
        //    int i, checkSum = 0;

        //    // Compute checksum of every other digit starting from right-most digit
        //    for (i = cardNumber.Length - 1; i >= 0; i -= 2)
        //        checkSum += (cardNumber[i] - '0');

        //    // Now take digits not included in first checksum, multiple by two,
        //    // and compute checksum of resulting digits
        //    for (i = cardNumber.Length - 2; i >= 0; i -= 2)
        //    {
        //        int val = ((cardNumber[i] - '0') * 2);
        //        while (val > 0)
        //        {
        //            checkSum += (val % 10);
        //            val /= 10;
        //        }
        //    }

        //    // Number is valid if sum of both checksums MOD 10 equals 0
        //    return ((checkSum % 10) == 0);
        //}

        //public static string NormalizeCardNumber(string cardNumber)
        //{
        //    if (cardNumber == null)
        //        cardNumber = String.Empty;

        //    StringBuilder sb = new StringBuilder();

        //    foreach (char c in cardNumber)
        //    {
        //        if (Char.IsDigit(c))
        //            sb.Append(c);
        //    }

        //    return sb.ToString();
        //}

    }
}
