using System;
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
        public void CheckIfUserNumberIsEven()
        {
            EvenNumber neweven = new EvenNumber();

            neweven.usereven = 7;

            Assert.IsFalse(neweven.usereven % 2 == 0);

        }

        [TestMethod]
        public void CheckIfAdding2Works()
        {
            EvenNumber neweven = new EvenNumber();

            neweven.usereven = 4;

            Assert.AreEqual(6, neweven.usereven + neweven.counter);
        }
    }
}
