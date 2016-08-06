using System;
using System.Collections.Generic;
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
            int fibToCheck = new_fib.Fibonaccis[0];
            Assert.IsNotNull(fibToCheck);
        }
        [TestMethod]
        public void WhatHappensIfYouEnterZero()
        {
            Fibonacci fibWithZero = new Fibonacci();
            fibWithZero.GenerateFibonacci(0);
            //the array already contains the first two numbers, 1 1
            //this assert makes sure no new numbers were added.
            Assert.IsTrue(fibWithZero.Fibonaccis.Count == 0);
        }
        [TestMethod]
        public void AreTheyFibonacciNumbers()
        {
            Fibonacci fibSequence = new Fibonacci();
            fibSequence.GenerateFibonacci(18);
            int last_fib = fibSequence.Fibonaccis[17];
            int next_last_fib = fibSequence.Fibonaccis[16];
            int third_last_fib = fibSequence.Fibonaccis[15];
            Assert.IsTrue(last_fib == (next_last_fib + third_last_fib));
        }
        [TestMethod]
        public void CheckIfTheListWorks()
        {
            Fibonacci checkForList = new Fibonacci();
            Assert.IsNotNull(checkForList.Fibonaccis);
        }
        [TestMethod]
        public void CheckForExpectedNumber()
        {
            Fibonacci checkNumberOrder = new Fibonacci();
            checkNumberOrder.GenerateFibonacci(3);
            int third_fibonacci = checkNumberOrder.Fibonaccis[2];
            Assert.IsTrue(third_fibonacci == 2);
        }
        [TestMethod]
        public void TheFirstTwoNumbersShouldBeOneOne()
        {
            Fibonacci firstTwoNumbers = new Fibonacci();
            firstTwoNumbers.GenerateFibonacci(2);
            int first_fibonacci = firstTwoNumbers.Fibonaccis[0];
            int second_fibonacci = firstTwoNumbers.Fibonaccis[1];
            Assert.IsTrue(first_fibonacci == 1);
            Assert.IsTrue(second_fibonacci == 1);
        }
        [TestMethod]
        public void WhatAboutALargeNumber()
        {
            Fibonacci bigNumber = new Fibonacci();
            bigNumber.GenerateFibonacci(123451);
            int third_last_fibonacci = bigNumber.Fibonaccis[123448];
            int second_last_fibonacci = bigNumber.Fibonaccis[123449];
            int last_fibonacci = bigNumber.Fibonaccis[123450];
            Assert.IsTrue(last_fibonacci == (third_last_fibonacci + second_last_fibonacci));
        }
        [TestMethod]
        public void WhatHappensIfYouEnterOne()
        {
            Fibonacci fib_one = new Fibonacci();
            fib_one.GenerateFibonacci(1);
            List<int> ListContainingOne = new List<int> { 1 };
            CollectionAssert.AreEqual(fib_one.Fibonaccis, ListContainingOne);
        }
        [TestMethod]
        public void CheckForExactSequene()
        {
            Fibonacci five_fibonaccis = new Fibonacci();
            five_fibonaccis.GenerateFibonacci(5);
            List<int> first_five_fibs = new List<int> { 1, 1, 2, 3, 5 };
            CollectionAssert.AreEqual(five_fibonaccis.Fibonaccis, first_five_fibs);

        }
    }
}
