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
            Assert.IsTrue(fibWithZero.sequence.Count == 0);
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
    }
}
