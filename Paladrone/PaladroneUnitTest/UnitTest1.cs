using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Libraries;

namespace PaladroneUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void isPaladroneEmptyTestMethod1()
        {
            Paladrone paladrone = new Paladrone();
            bool expected = true;
            bool actual = paladrone.isPaladrone();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void isPaladroneRacecarTestMethod1()
        {
            Paladrone paladrone = new Paladrone("racecar");
            bool expected = true;
            bool actual = paladrone.isPaladrone();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void isPaladrone1221TestMethod1()
        {
            Paladrone paladrone = new Paladrone("1221");
            bool expected = true;
            bool actual = paladrone.isPaladrone();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void isPaladroneEvenOddTestMethod1()
        {
            Paladrone paladrone = new Paladrone("never Odd or Even");
            bool expected = true;
            bool actual = paladrone.isPaladrone();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void isPaladroneabcTestMethod1()
        {
            Paladrone paladrone = new Paladrone("abc");
            bool expected = false;
            bool actual = paladrone.isPaladrone();
            Assert.AreEqual(expected, actual);
        }
    }
}
