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
    }
}
