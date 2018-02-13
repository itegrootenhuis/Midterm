using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Views
{
    public class Cardpayment
    {
        public static int CVV { get; set; }
        public static string CardNum { get; set; }
        public static string ExpDate { get; set; }

        public static void ValidPayment()
        {
            ValidCardNum();
            VerifyCVV();
            VerifyExpDate();
        }

        public static void ValidCardNum()
        {
            bool CardParse;
            Console.Write("Enter the card number (xxxxxxxxxxxxxxxx):");
            string CardInput = Console.ReadLine();
            if (CardInput.Length == 16)
            {
                CardParse = double.TryParse(CardInput, out double VCardNum);

                if (CardParse)
                    CardNum = CardInput;
                else
                {
                    Console.Clear();
                    Console.WriteLine("Your input was invalid");
                    ValidCardNum();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Your input was invalid");
                ValidCardNum();
            }
        }

        public static void VerifyCVV()
        {
            Console.WriteLine("Enter the CVV number (xxx):");
            bool CVVParse;
            string CVVInput = Console.ReadLine();

            if (CVVInput.Length == 3)
            {
                CVVParse = int.TryParse(CVVInput, out int VCVV);

                if (CVVParse)
                {
                    CVV = VCVV;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Your input was invalid");
                    VerifyCVV();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Your input was invalid");
                VerifyCVV();
            }
        }

        public static bool VerifyExpDate()
        {
            Console.WriteLine("Enter expiration date MM/YYYY:");

            string expDate = Console.ReadLine();  

            if (DateTime.TryParse(expDate, out DateTime dt))
                if (dt < DateTime.Now)
                {
                    Console.WriteLine("Card has expired");
                    return VerifyExpDate();
                }
                else
                {
                    ExpDate = expDate;
                    return true;
                }
            else
            {
                Console.WriteLine("Invalid input");
                return VerifyExpDate();
            }
        }
    }
}