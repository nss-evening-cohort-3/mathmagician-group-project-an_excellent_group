using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class OddNumberTests
    {
        [TestMethod]
        public void MakeSureYouCanMakeOddNumber()
        {
            //Arrange

            //Act
            OddNumber userodd = new OddNumber();

            //Assert
            Assert.IsNotNull(userodd);
        }

        [TestMethod]
        public void TestCreateOddListWorks()
        {
            //Create a new odd number class
            OddNumber newodd = new OddNumber();

            //Create a list of odd numbers
            List<int> newlist = newodd.CreateOddNumberList(5);

            //Create a new list of odd numbers to compare
            List<int> testlist = new List<int>() { 1, 3, 5, 7, 9 };

            //Make sure the two lists are eqal
            CollectionAssert.AreEqual(testlist, newlist);
        }


    }
}
