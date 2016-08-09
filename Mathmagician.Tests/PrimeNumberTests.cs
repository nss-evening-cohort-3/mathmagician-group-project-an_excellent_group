using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class PrimeNumberTests
    {
        [TestMethod]
        public void MakeSureICanMakePrimeNumber()
        {
            PrimeNumber newprime = new PrimeNumber();

            Assert.IsNotNull(newprime);

        }

        [TestMethod]
        public void CheckifPrime()
        {
            PrimeNumber newprime = new PrimeNumber();

            newprime.CheckIfNumberIsPrime(2);

            Assert.IsTrue(newprime.CheckIfNumberIsPrime(2));
        }

        [TestMethod]
        public void CheckIfReturnListOfPrime()
        {
            PrimeNumber newprime = new PrimeNumber();

            List<int> newlistofprimes = new List<int>() {2, 3, 5, 7, 11 };

            CollectionAssert.AreEqual(newprime.CreatePrimeNumberList(5), newlistofprimes);
      

        }
    }
}
