﻿using System;
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
                    if (printThisManyNumbers < 0)
                    {
                        Console.WriteLine("A negative? Sounds like you owe me some numbers! Pay up! Or, press a key to exit.");
                    }
                    else
                    {
                        Console.WriteLine("Printing " + printThisManyNumbers + " integers! MAGIC!");
                        Integer integer = new Integer();
                        int[] intArray = integer.GenerateIntegers(printThisManyNumbers);
                        for (int i = 0; i < printThisManyNumbers; i++)
                        {
                            Console.WriteLine("> " + intArray[i]); 
                        }
                    }
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
                    if (printThisManyNumbers < 0)
                    {
                        Console.WriteLine("A negative? Sounds like you owe me some numbers! Pay up! Or, press a key to exit.");
                    }
                    else
                    {
                        Console.WriteLine("Printing " + printThisManyNumbers + " Fibonaccis! MAGIC!");
                        Fibonacci fibonacci = new Fibonacci();
                        int[] fibArray = fibonacci.GenerateFibonacci(printThisManyNumbers);
                        for (int i = 0; i < printThisManyNumbers; i++)
                        {
                            Console.WriteLine("> " + fibArray[i]);
                        }
                    }
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
                    if (printThisManyNumbers < 0)
                    {
                        Console.WriteLine("A negative? Sounds like you owe me some numbers! Pay up! Or, press a key to exit.");
                    }
                    else
                    {
                        Console.WriteLine("Printing " + printThisManyNumbers + " primes! MAGIC!");
                        PrimeNumber prime = new PrimeNumber();
                        int[] primeArray = prime.CreatePrimeNumberList(printThisManyNumbers).ToArray();
                        for (int i=0; i < printThisManyNumbers; i++)
                        {
                            Console.WriteLine("> " + primeArray[i]);
                        }
                    }
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
                    if (printThisManyNumbers < 0)
                    {
                        Console.WriteLine("A negative? Sounds like you owe me some numbers! Pay up! Or, press a key to exit.");
                    }
                    else
                    {
                        Console.WriteLine("Printing " + printThisManyNumbers + " evens! MAGIC!");
                        EvenNumber evens = new EvenNumber();
                        int[] evenArray = evens.CreateEvennNumberList(printThisManyNumbers).ToArray();
                        for (int i = 0; i < printThisManyNumbers; i++)
                        {
                            Console.WriteLine("> " + evenArray[i]);
                        }
                        //call number-generating method here. ex: Integers.GenerateIntegers(printThisManyNumbers)
                    }
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
                    if (printThisManyNumbers < 0)
                    {
                        Console.WriteLine("A negative? Sounds like you owe me some numbers! Pay up! Or, press a key to exit.");
                    }
                    else
                    {
                        Console.WriteLine("Printing " + printThisManyNumbers + " odds! MAGIC!");
                        OddNumber odd = new OddNumber();
                        int[] oddArray = odd.CreateOddNumberList(printThisManyNumbers).ToArray();
                        for (int i = 0; i < printThisManyNumbers; i++)
                        {
                            Console.WriteLine("> " + oddArray[i]);
                        }
                    }
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
