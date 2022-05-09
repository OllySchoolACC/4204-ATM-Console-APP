using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4204_ATM_Console_APP
{
    internal class Program
    {
        //public static string Pin; // dont make this a global variable


        // Global Variables

        // Our allowed user input options
        public static string[] MenuOptions = { "1", "2", "3", "4" };
        // User balance of funds
        public static decimal Bal;
        // Private Pin
        private static string pin = "";

        static void CheckPin() // Private not public
        {
            pin = "";
            Console.WriteLine("\n\t****** Welcome to the ATM Program ******\n\n\tPlease enter your pin number\n");

            // User input
            pin = Console.ReadLine();

            // Use while looop to check pin
            while(pin != "123456")
            {
                if(pin == "123456")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\tPin number incorrect, enter again.");
                    pin = Console.ReadLine();
                }
            }
            Console.WriteLine("\t\nPin is correct, Access Granted.\n");

            MainMenu();
        }

        static void MainMenu()
        {
            Console.WriteLine("\n***************************************\n");
            Console.WriteLine("\tSelect an option:\n");
            Console.WriteLine("\t [1] View Balance");
            Console.WriteLine("\t [2] Withdraw Funds");
            Console.WriteLine("\t [3] Deposit Funds");
            Console.WriteLine("\t [4] Exit Application");
            Console.WriteLine("\n***************************************\n");
        }








        static void Main(string[] args)
        {
            CheckPin();
        }
    }
}
