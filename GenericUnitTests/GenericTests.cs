using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GenericUnitTests
{
    [TestClass]
    public class GenericTests
    {
        [TestMethod]
        public void PassCase()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void PassCaseTwo()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void FailCase()
        {
            Assert.IsTrue(false);
        }
    }
}
