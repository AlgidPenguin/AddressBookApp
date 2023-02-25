using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

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
        public void PassCaseThree()
        {
            Debug.WriteLine("Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void FailCase()
        {
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void FailCaseTwo()
        {
            Assert.IsTrue(false);
        }
    }
}
