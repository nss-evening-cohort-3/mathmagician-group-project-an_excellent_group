using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Fibonacci
    {
        private List<int> _sequence = new List<int> {1, 1};

        public void GenerateFibonacci(int numOfFibonacci)
        {
            if (numOfFibonacci < 3 )
            {
                for ( int i = 0 ; i < numOfFibonacci; i++ )
                {
                    Console.WriteLine("> " + _sequence[i]);
                }
            }
            else
            {
                Console.WriteLine("> " + _sequence[0]);
                Console.WriteLine("> " + _sequence[1]);
                for ( int i = 2; i < numOfFibonacci ; i++)
                {
                    int newFibonacci = _sequence[i - 2] + _sequence[i - 1];
                    Console.WriteLine("> " + newFibonacci);
                    _sequence.Add(newFibonacci);
                }
            }
            Console.WriteLine("Have I slaked your Fibonacci thirst? The Mathmagician strikes again!");
        }
    }
}