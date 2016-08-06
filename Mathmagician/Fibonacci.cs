﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Fibonacci
    {
        //contains the first two fibonaccis, ready to go
        public List<int> FirstTwoInSequence = new List<int> {1, 1};

        //list to store 
        public List<int> Fibonaccis = new List<int>();

        //this method takes an int argument.
        //if the number of requested fibonaccis is less than 3,
        //it simply prints off the first or first two numbers in the 'sequence' list.
        //ask for more than 3, and it will add 1 and 1 to the list, 
        //start generatin' fibbos, add the generated numbers to the list, rinse & repeat 
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
                    Console.WriteLine("> " + FirstTwoInSequence[i]);
                    Fibonaccis.Add(FirstTwoInSequence[i]);
                }
            }
            else
            {
                Console.WriteLine("> " + FirstTwoInSequence[0]);
                Console.WriteLine("> " + FirstTwoInSequence[1]);
                Fibonaccis = FirstTwoInSequence;
                for ( int i = 2; i < numOfFibonacci ; i++)
                {
                    int newFibonacci = Fibonaccis[i - 2] + Fibonaccis[i - 1];
                    Console.WriteLine("> " + newFibonacci);
                    Fibonaccis.Add(newFibonacci);
                }
            }
            Console.WriteLine("Have I slaked your Fibonacci thirst? The Mathmagician strikes again!");
        }
    }
}