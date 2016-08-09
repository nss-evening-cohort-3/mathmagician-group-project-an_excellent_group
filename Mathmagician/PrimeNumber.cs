using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class PrimeNumber
    {
        //Created boolean method to test if number being passed in is a prime number
        public bool CheckIfNumberIsPrime(int number)
        {

            //2 is a prime number
            if (number == 2)
                return true;

            //1 is not a prime number
            if (number == 1)
                return false;

            //0 is not a prime number
            if (number == 0)
                return false;
           
            //Create a forloop that takes the number being passed in and gets all the prime numbers between it and 2.
            for (var i = 2; i<number; i++)
            {
                //if the number being passed in leaves NO remainder, then it is NOT prime.
                if ( number % i == 0)
                {
                    return false;
                }

               
            }
            //Otherwise, the method returns true.
            return true; 
            
        }

        //Create a list of prime numbers based on the number of primes the user requests.
        public List<int> CreatePrimeNumberList(int usernumberofprimes)
        {
            //Create a List that will contain prime numbers.
            List<int> primenumbers = new List<int>();

            
            //Create a loop that starts at the number 2 for primes and compares that to the number of times the user requests for prime numbers so they coorespond. "i" increases each time to the next number in line (2, 3, 4, 5, 6, etc.) and checks if the number is prime.
            for (var i = 2; primenumbers.Count != usernumberofprimes; i++)
            {
                //here is where "i" is placed in a boolean variable to check if it is prime.
                bool isPrime = CheckIfNumberIsPrime(i);
                if (isPrime)
                    {
                   //if "i" is prime, then add it to the list. Otherwise, it will move on to the next number. 
                   primenumbers.Add(i);
                    }            
            }
            //return the list to be used in the Program.cs
            return primenumbers;

        }



        
    }
}
