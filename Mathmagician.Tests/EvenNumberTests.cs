using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class EvenNumberTests
    {
        [TestMethod]
        public void MakeSureYouCanMakeEvenNumber()
        {
            //Arrange

            //Act
            EvenNumber usereven = new EvenNumber();

            //Assert
            Assert.IsNotNull(usereven);
        }

        [TestMethod]
        public void TestCreateEvenListWorks()
        {
            EvenNumber neweven = new EvenNumber();

            List<int> newlist = neweven.CreateEvennNumberList(5);

            List<int> testlist = new List<int>() { 0, 2, 4, 6, 8 };

            CollectionAssert.AreEqual(testlist, newlist);
        }
    }
}
