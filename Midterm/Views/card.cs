using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Midterm

 
{
    
    //TODO Validate card information entered

    public class Cardpayment
    {
        public static int CVV { get; set; }
        public static int CardNum { get; set; }
        public static string ExpDate { get; set; }

        public static void ValidPayment()
        {
         ValidCardNum();
         VerifyCVV();
         VerifyExpDate();
        }
        private static void ValidCardNum()
        {
            int VCardNum;
            bool CardParse;
            Console.Write("Enter the card Number (xxxxxxxxxxxxxxxx):");
            string CardInput = Console.ReadLine();
            if (CardInput.Length == 16)
            {
                CardParse = int.TryParse(CardInput, out VCardNum);

                if (CardParse)
                    CardNum = VCardNum;

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

            Console.WriteLine("CVV # (xxx)");
            //VCVV stands for 
            int VCVV;
            bool CVVParse;
            string CVVInput = Console.ReadLine();

            if (CVVInput.Length == 3)
            {
                CVVParse = int.TryParse(CVVInput, out VCVV);

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
            Console.WriteLine("Please enter expiration date mm/yyyy");

            string expDate = Console.ReadLine();  
            DateTime dt = Convert.ToDateTime(expDate);


            if (DateTime.TryParse(expDate, out dt))
                if (dt < DateTime.Now)
                {
                    Console.WriteLine("card has expired");

                    return VerifyExpDate();
                }
                else
                {
                    ExpDate = expDate;
                    return true;
                }
            else
            {
                Console.WriteLine("invalid input");
                return VerifyExpDate();
            }
        }


       
    }

        
}