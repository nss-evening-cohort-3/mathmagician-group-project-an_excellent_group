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
            string requestNumber = "How many should I print?";
            string prompt = "> ";
            string makeIntoAnInt = "";
            int printThisManyNumbers = 0;
            bool isItAnInt = false;
            Console.WriteLine("You have summoned the Mathmagician! You must be in need of numbers.");
            Console.WriteLine("VERY WELL! Input one of my magic words, press the Enter key and watch in awe.");
            Console.WriteLine("The magic words are: integer, fibonacci, prime, even and odd.");
            Console.WriteLine(requestInput);

            string userInput = Console.ReadLine().ToLower();
            if (userInput == "integer")
            {
                Console.WriteLine("AHA! INTEGERS! " + requestNumber);
                makeIntoAnInt = Console.ReadLine();
                isItAnInt = (Int32.TryParse(makeIntoAnInt, out printThisManyNumbers));
                if (isItAnInt)
                {
                    Console.WriteLine("Printing " + printThisManyNumbers + " integers! MAGIC!");
                    Integer integer = new Integer();
                    integer.GenerateIntegers(printThisManyNumbers);
                    Console.WriteLine("Hope you like your integers, friend! Press any key to close. MATHMAGICIAN AWAY!");
                }
                else
                {
                    Console.WriteLine("That's not a number! Goodbye!");
                }
                Console.ReadLine();
            }
            else if (userInput == "fibonacci")
            {
                Console.WriteLine("AHA! THE FIBONACCI SEQUENCE! " + requestNumber);
                makeIntoAnInt = Console.ReadLine();
                isItAnInt = (Int32.TryParse(makeIntoAnInt, out printThisManyNumbers));
                if (isItAnInt)
                {
                    Console.WriteLine("Printing " + printThisManyNumbers + " Fibonaccis! MAGIC!");
                }
                else
                {
                    Console.WriteLine("That's not a number! Goodbye!");
                }
                Console.ReadLine();
            }
            else if (userInput == "prime")
            {
                Console.WriteLine("AHA! PRIME NUMBERS! " + requestNumber);
                makeIntoAnInt = Console.ReadLine();
                isItAnInt = (Int32.TryParse(makeIntoAnInt, out printThisManyNumbers));
                if (isItAnInt)
                {
                    Console.WriteLine("Printing " + printThisManyNumbers + " primes! MAGIC!");
                }
                else
                {
                    Console.WriteLine("That's not a number! Goodbye!");
                }
                Console.ReadLine();
            }
            else if (userInput == "even")
            {
                Console.WriteLine("AHA! EVENS! " + requestNumber);
                makeIntoAnInt = Console.ReadLine();
                isItAnInt = (Int32.TryParse(makeIntoAnInt, out printThisManyNumbers));
                if (isItAnInt)
                {
                    Console.WriteLine("Printing " + printThisManyNumbers + " evens! MAGIC!");
                }
                else
                {
                    Console.WriteLine("That's not a number! Goodbye!");
                }
                Console.ReadLine();
            }
            else if (userInput == "odd")
            {
                Console.WriteLine("AHA! ODDS! " + requestNumber);
                makeIntoAnInt = Console.ReadLine();
                isItAnInt = (Int32.TryParse(makeIntoAnInt, out printThisManyNumbers));
                if (isItAnInt)
                {
                    Console.WriteLine("Printing " + printThisManyNumbers + " odds! MAGIC!");
                }
                else
                {
                    Console.WriteLine("That's not a number! Goodbye!");
                }
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
