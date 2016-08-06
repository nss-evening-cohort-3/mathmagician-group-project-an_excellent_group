using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class IntegerTests
    {
        [TestMethod]
        public void IntegerEnsureICanCreateAnInstance()
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
            int last_int = int_sequence.integers[4];
            int next_last_int = int_sequence.integers[3];
            Assert.IsTrue(last_int != next_last_int);
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
    }
}
