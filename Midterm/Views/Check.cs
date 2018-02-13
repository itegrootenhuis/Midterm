using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Views
{
    public class CheckPayment
    {
        public static int CheckNum { get; set; }

        public static void ValidPayment()
        {
            bool CheckParse;
            Console.Write("Enter the check number (xxxx):");
            string CheckInput = Console.ReadLine();

            if (CheckInput.Length == 4)
            {
                CheckParse = int.TryParse(CheckInput, out int VCheckNum);

                if (CheckParse)
                    CheckNum = VCheckNum;
                else
                {
                    Console.Clear();
                    Console.WriteLine("Your input was invalid");
                    ValidPayment();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Your input was invalid");
                ValidPayment();
            }
        }
    }
}
