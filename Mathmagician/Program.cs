using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    class Program
    {
        static void Main(string[] args)
        {
            string requestInput = "What would you like me to do?";
            string prompt = "> ";
            Console.WriteLine("You have summoned the Mathmagician! You must be in need of numbers.");
            Console.WriteLine("VERY WELL! Input one of my magic words, press the Enter key and watch in awe.");
            Console.WriteLine("The magic words are: integer, fibonacci, prime, even and odd.");
            Console.WriteLine(requestInput);

            string userInput = Console.ReadLine().ToLower();
            if (userInput == "integer")
            {
                Console.WriteLine("Integer method requested. press any key to close.");
                Console.ReadLine();
            }
            else if (userInput == "fibonacci")
            {
                Console.WriteLine("fibonacci method requested. press any key to close.");
                Console.ReadLine();
            }
            else if (userInput == "prime")
            {
                Console.WriteLine("prime method requested. press any key to close.");
                Console.ReadLine();
            }
            else if (userInput == "even")
            {
                Console.WriteLine("even method requested. press any key to close.");
                Console.ReadLine();
            }
            else if (userInput == "odd")
            {
                Console.WriteLine("odd method requested. press any key to close.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("whoops! incorrect command entered. press any key to close.");
                Console.ReadLine();
            }
        }
    }
}
