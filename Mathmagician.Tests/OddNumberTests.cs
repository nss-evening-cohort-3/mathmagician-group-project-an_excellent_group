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
            OddNumber newodd = new OddNumber();

            List<int> newlist = newodd.CreateOddNumberList(5);

            List<int> testlist = new List<int>() { 1, 3, 5, 7, 9 };

            CollectionAssert.AreEqual(testlist, newlist);
        }


    }
}
