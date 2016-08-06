using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class IntegerTests
    {
        [TestMethod]
        public void EnsureICanCreateAnInstance()
        {
            //arrange

            //act
            Integer my_int = new Integer();
            //assert
            Assert.IsNotNull(my_int);
        }
        [TestMethod]
        public void GenerateAnIntTypeVariable()
        {
            Integer new_int = new Integer();
            new_int.GenerateIntegers(1);
            int intToTest = new_int.newInteger;
            Assert.IsNotNull(intToTest);
        }
        [TestMethod]
        public void IsTheNextNumberADifferentInteger()
        {
            Integer int_sequence = new Integer();
            int_sequence.GenerateIntegers(5);
            CollectionAssert.AllItemsAreUnique(int_sequence.integers);
        }
        [TestMethod]
        public void WhatHappensIfYouInputZero()
        {
            Integer int_with_zero = new Integer();
            int_with_zero.GenerateIntegers(0);
            Assert.IsTrue(int_with_zero.integers.Count == 0);
        }
        [TestMethod]
        public void ListOfIntegers()
        {
            Integer hasList = new Integer();
            Assert.IsNotNull(hasList.integers);

        }
        [TestMethod]
        public void NumbersInSequence()
        {
            Integer hereAreSomeIntegers = new Integer();
            hereAreSomeIntegers.GenerateIntegers(8);
            int should_be_seven = hereAreSomeIntegers.integers[7];
            Assert.IsTrue(should_be_seven == 7);
        }
        [TestMethod]
        public void WhatAboutALargeNumber()
        {
            Integer biggun = new Integer();
            biggun.GenerateIntegers(123451);
            int InputNumberMinusOne = biggun.integers[123450];
            Assert.IsTrue(InputNumberMinusOne == 123450);
        }
        [TestMethod]
        public void CheckForExactSequence()
        {
            Integer exact_sequence = new Integer();
            exact_sequence.GenerateIntegers(10);
            List<int> zero_through_nine = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            CollectionAssert.AreEqual(exact_sequence.integers, zero_through_nine);

        }
    }
}
