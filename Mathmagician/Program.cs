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

            //input one of the stated keywords to invoke that class
            Console.WriteLine("You have summoned the Mathmagician! You must be in need of numbers.");
            Console.WriteLine("VERY WELL! Input one of my magic words, press the Enter key and watch in awe.");
            Console.WriteLine("The magic words are: integer, fibonacci, prime, even and odd.");
            Console.WriteLine(requestInput);

            //whatever word the user types is converted to lowercase.
            //if the input does not match any of the keywords, the program says "whoops" and closes.
            string userInput = Console.ReadLine().ToLower();
           
            if (userInput == "integer")
            {
                //asks the user how many numbers they want
                Console.WriteLine("AHA! INTEGERS! " + requestNumber);
                makeIntoAnInt = Console.ReadLine();

                //check if the user input a number. If the user input cannot be converted to an int,
                //the program stops.
                isItAnInt = (Int32.TryParse(makeIntoAnInt, out printThisManyNumbers));
                if (isItAnInt)
                {
                    Console.WriteLine("Printing " + printThisManyNumbers + " integers! MAGIC!");
                    //call number-generating method here. ex: Integers.GenerateIntegers(printThisManyNumbers)
                }
                else
                {
                    Console.WriteLine("That's not a number! Goodbye!");
                }
                //waits for user input to close
                Console.ReadLine();
            }
            else if (userInput == "fibonacci")
            {
                //asks the user how many numbers they want
                Console.WriteLine("AHA! THE FIBONACCI SEQUENCE! " + requestNumber);
                makeIntoAnInt = Console.ReadLine();

                //check if the user input a number. If the user input cannot be converted to an int,
                //the program stops.
                isItAnInt = (Int32.TryParse(makeIntoAnInt, out printThisManyNumbers));
                if (isItAnInt)
                {
                    Console.WriteLine("Printing " + printThisManyNumbers + " Fibonaccis! MAGIC!");
                    //call number-generating method here. ex: Integers.GenerateIntegers(printThisManyNumbers)
                }
                else
                {
                    Console.WriteLine("That's not a number! Goodbye!");
                }
                Console.ReadLine();
            }
            else if (userInput == "prime")
            {
                //asks the user how many numbers they want
                Console.WriteLine("AHA! PRIME NUMBERS! " + requestNumber);
                makeIntoAnInt = Console.ReadLine();

                //check if the user input a number. If the user input cannot be converted to an int,
                //the program stops.
                isItAnInt = (Int32.TryParse(makeIntoAnInt, out printThisManyNumbers));
                if (isItAnInt)
                {
                    Console.WriteLine("Printing " + printThisManyNumbers + " primes! MAGIC!");
                    //call number-generating method here. ex: Integers.GenerateIntegers(printThisManyNumbers)
                }
                else
                {
                    Console.WriteLine("That's not a number! Goodbye!");
                }
                Console.ReadLine();
            }
            else if (userInput == "even")
            {
                //asks the user how many numbers they want
                Console.WriteLine("AHA! EVENS! " + requestNumber);
                makeIntoAnInt = Console.ReadLine();

                //check if the user input a number. If the user input cannot be converted to an int,
                //the program stops.
                isItAnInt = (Int32.TryParse(makeIntoAnInt, out printThisManyNumbers));
                if (isItAnInt)
                {
                    Console.WriteLine("Printing " + printThisManyNumbers + " evens! MAGIC!");
                    //call number-generating method here. ex: Integers.GenerateIntegers(printThisManyNumbers)
                }
                else
                {
                    Console.WriteLine("That's not a number! Goodbye!");
                }
                Console.ReadLine();
            }
            else if (userInput == "odd")
            {
                //asks the user how many numbers they want
                Console.WriteLine("AHA! ODDS! " + requestNumber);
                makeIntoAnInt = Console.ReadLine();

                //check if the user input a number. If the user input cannot be converted to an int,
                //the program stops.
                isItAnInt = (Int32.TryParse(makeIntoAnInt, out printThisManyNumbers));
                if (isItAnInt)
                {
                    Console.WriteLine("Printing " + printThisManyNumbers + " odds! MAGIC!");
                    //call number-generating method here. ex: Integers.GenerateIntegers(printThisManyNumbers)
                }
                else
                {
                    Console.WriteLine("That's not a number! Goodbye!");
                }
                Console.ReadLine();
            }
            //if user input is not recognized
            else
            {
                Console.WriteLine("whoops! incorrect command entered. press any key to close.");
                Console.ReadLine();
            }
        }
    }
}
