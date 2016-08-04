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
    }
}
