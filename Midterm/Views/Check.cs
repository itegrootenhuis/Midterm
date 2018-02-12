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
        public static int VCheckNum;
        public static bool CheckParse;

        public static bool ValidPayment()
        {
            Console.Write("Enter the check number (xxxx):");
            string CheckInput = Console.ReadLine();

            if (CheckInput.Length == 3)
            {
                CheckParse = int.TryParse(CheckInput, out VCheckNum);

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

        
            return true;
        }
    }
}
