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
            Palindrome palindrome = new Palindrome();
            bool expected = true;
            bool actual = palindrome.isPalindrome();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void isPaladroneRacecarTestMethod1()
        {
            Palindrome paladrone = new Palindrome("racecar");
            bool expected = true;
            bool actual = paladrone.isPalindrome();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void isPaladrone1221TestMethod1()
        {
            Palindrome paladrone = new Palindrome("1221");
            bool expected = true;
            bool actual = paladrone.isPalindrome();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void isPaladroneEvenOddTestMethod1()
        {
            Palindrome paladrone = new Palindrome("never Odd, or Even.");
            bool expected = true;
            bool actual = paladrone.isPalindrome();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void isPaladroneabcTestMethod1()
        {
            Palindrome paladrone = new Palindrome("abc");
            bool expected = false;
            bool actual = paladrone.isPalindrome();
            Assert.AreEqual(expected, actual);
        }
    }
}
