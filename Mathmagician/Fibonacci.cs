using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Fibonacci
    {
        //list to store generated fibonaccis for testing.
        //contains the first two fibonaccis, ready to go
        public List<int> sequence = new List<int> {1, 1};

        //this method takes an int argument.
        // if the number of requested fibonaccis is less than 3,
        //it simply prints off the first or first two numbers in the 'sequence' list.
        //ask for more than 3, and it will add the last two numbers in the list,
        //add the generated number to the list, rinse & repeat 
        public void GenerateFibonacci(int numOfFibonacci)
        {
            if (numOfFibonacci == 0 )
            {
                Console.WriteLine("Don't want any Fibonacci numbers, eh? More for me, the MATHMAGICIAN!!");
            }
            else if ( numOfFibonacci < 3 )
            {
                for ( int i = 0 ; i < numOfFibonacci; i++ )
                {
                    Console.WriteLine("> " + sequence[i]);
                }
            }
            else
            {
                Console.WriteLine("> " + sequence[0]);
                Console.WriteLine("> " + sequence[1]);
                for ( int i = 2; i < numOfFibonacci ; i++)
                {
                    int newFibonacci = sequence[i - 2] + sequence[i - 1];
                    Console.WriteLine("> " + newFibonacci);
                    sequence.Add(newFibonacci);
                }
            }
            Console.WriteLine("Have I slaked your Fibonacci thirst? The Mathmagician strikes again!");
        }
    }
}