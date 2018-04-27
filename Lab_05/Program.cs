using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05
{
    class Program
    {
        static void Main(string[] args)
        {
            GetWelcome();

            bool again = true;
            while (again)
            {

                GetInput();

                again = GetContinue();
            }

            GetGoodbye();
            Console.ReadLine();

        }

        static void GetInput() // method to get valid input from user
        {
            while (true)
            {
                Console.Write("\nPlease enter an integer greater than zero and less than ten: ");
                string response = Console.ReadLine();
                bool success = int.TryParse(response, out int digit);
                if (!success)
                {
                    Console.WriteLine("\nThat was not an integer");
                }
                else if (digit <= 0 || digit >= 10)
                {
                    Console.WriteLine("\nThat was not in the bounds.");
                }
                else
                {
                    Console.WriteLine($"\nThe factorial of {digit} is {GetFactCalc(digit)}."); // passes valid int to factorial method and returns value
                    return;
                }
            }
        }

        static int GetFactCalc(int carl) // method to calculate factorial

        {
            int input = carl;
            int fact = 1;
            for (int i = 1; i <= input; i++)
            {
                fact = fact * i;
            }
            return fact;
        }

        static void GetWelcome()
        {
            Console.WriteLine("Welcome to the factorial calculator.");
        }

        static bool GetContinue()
        {
            while (true)
            {
                //ask user if they want to continue
                Console.Write("\nDo you want to enter another number (y/n)? ");
                //get string input
                string input = Console.ReadLine();

                //if it's yes, return true
                if (input == "y" || input == "Y")
                {
                    return true;
                }
                //if it's no, return false
                else if (input == "n" || input == "N")
                {
                    return false;
                }
                //anything else, ask again
                Console.WriteLine("\nNot a valid entry");
            }

        }
        static void GetGoodbye()

        {
            Console.WriteLine("\nGoodbye!");
        }

    }
}
