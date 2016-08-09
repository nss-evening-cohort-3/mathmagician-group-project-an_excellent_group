using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class PrimeNumberTests
    {
        [TestMethod]
        //This will test to make sure I can make a prime number
        public void MakeSureICanMakePrimeNumber()
        {
            PrimeNumber newprime = new PrimeNumber();

            Assert.IsNotNull(newprime);

        }

        [TestMethod]
        public void CheckifPrime()
        {
            
            PrimeNumber newprime = new PrimeNumber();

            //This will test to see if "2" is a prime number.
            newprime.CheckIfNumberIsPrime(2);

            Assert.IsTrue(newprime.CheckIfNumberIsPrime(2));
        }

        [TestMethod]
        public void CheckIfReturnListOfPrime()
        {
            PrimeNumber newprime = new PrimeNumber();

            //I created a list of the first 5 prime numbers
            List<int> newlistofprimes = new List<int>() {2, 3, 5, 7, 11 };

            //I then compared the list of prime numbers to a new list that I did using the method in the respective cs file.
            CollectionAssert.AreEqual(newprime.CreatePrimeNumberList(5), newlistofprimes);
      

        }
    }
}
