using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void GenerateInstanceOfFibonacci()
        {
            Fibonacci fibonacci = new Fibonacci();
            Assert.IsNotNull(fibonacci);
        }
        [TestMethod]
        public void GenerateANumber()
        {
            Fibonacci new_fib = new Fibonacci();
            new_fib.GenerateFibonacci(1);
            int fibToCheck = new_fib.sequence[0];
            Assert.IsNotNull(fibToCheck);
        }
        [TestMethod]
        public void WhatHappensIfYouEnterZero()
        {
            Fibonacci fibWithZero = new Fibonacci();
            fibWithZero.GenerateFibonacci(0);
            //the array already contains the first two numbers, 1 1
            //this assert makes sure no new numbers were added.
            Assert.IsTrue(fibWithZero.sequence.Count == 2);
        }
        [TestMethod]
        public void AreTheyFibonacciNumbers()
        {
            Fibonacci fibSequence = new Fibonacci();
            fibSequence.GenerateFibonacci(18);
            int last_fib = fibSequence.sequence[17];
            int next_last_fib = fibSequence.sequence[16];
            int third_last_fib = fibSequence.sequence[15];
            Assert.IsTrue(last_fib == (next_last_fib + third_last_fib));
        }
        [TestMethod]
        public void CheckIfTheListWorks()
        {
            Fibonacci checkForList = new Fibonacci();
            Assert.IsNotNull(checkForList.sequence);
        }
        [TestMethod]
        public void CheckForExpectedNumber()
        {
            Fibonacci checkNumberOrder = new Fibonacci();
            checkNumberOrder.GenerateFibonacci(3);
            int third_fibonacci = checkNumberOrder.sequence[2];
            Assert.IsTrue(third_fibonacci == 2);
        }
        [TestMethod]
        public void TheFirstTwoNumbersShouldBeOneOne()
        {
            Fibonacci firstTwoNumbers = new Fibonacci();
            firstTwoNumbers.GenerateFibonacci(2);
            int first_fibonacci = firstTwoNumbers.sequence[0];
            int second_fibonacci = firstTwoNumbers.sequence[1];
            Assert.IsTrue(first_fibonacci == 1);
            Assert.IsTrue(second_fibonacci == 1);
        }
        [TestMethod]
        public void WhatAboutALargeNumber()
        {
            Fibonacci bigNumber = new Fibonacci();
            bigNumber.GenerateFibonacci(123451);
            int third_last_fibonacci = bigNumber.sequence[123448];
            int second_last_fibonacci = bigNumber.sequence[123449];
            int last_fibonacci = bigNumber.sequence[123450];
            Assert.IsTrue(last_fibonacci == (third_last_fibonacci + second_last_fibonacci));
        }
    }
}
