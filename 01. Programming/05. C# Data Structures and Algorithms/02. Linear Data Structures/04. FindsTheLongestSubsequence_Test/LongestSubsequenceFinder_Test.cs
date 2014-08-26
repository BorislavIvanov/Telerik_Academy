using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FindsTheLongestSubsequenceOfEqualNumbers;

namespace UnitTestProject1
{
    [TestClass]
    public class LongestSubsequenceFinder_Test
    {
        [TestMethod]
        public void LongestSubsequenceFinder_Test1_MustReturn3()
        {
            List<int> inputNumbers = new List<int>() { 2, 3, 4, 5, 5, 5, 6 };

            List<int> biggestSequence = LongestSubsequenceFinder.FindLongestSubsequence(inputNumbers);

            Assert.AreEqual(3, biggestSequence.Count);
        }

        [TestMethod]
        public void LongestSubsequenceFinder_Test2_MustReturn0()
        {
            List<int> inputNumbers = new List<int>() { };

            List<int> biggestSequence = LongestSubsequenceFinder.FindLongestSubsequence(inputNumbers);

            Assert.AreEqual(0, biggestSequence.Count);
        }

        [TestMethod]
        public void LongestSubsequenceFinder_Test3_MustReturn3()
        {
            List<int> inputNumbers = new List<int>() { 1, 1, 1, 2, 2, 2 };

            List<int> biggestSequence = LongestSubsequenceFinder.FindLongestSubsequence(inputNumbers);

            Assert.AreEqual(3, biggestSequence.Count);
        }

        [TestMethod]
        public void LongestSubsequenceFinder_Test4_TheTwoArraysMystBeEqual()
        {
            List<int> inputNumbers = new List<int>() { 1, 1, 1, 5, 5, 5, 5, 5, 2, 2, 2 };

            List<int> biggestSequence = LongestSubsequenceFinder.FindLongestSubsequence(inputNumbers);

            List<int> expectedResult = new List<int>() { 5, 5, 5, 5, 5 };

            CollectionAssert.AreEqual(expectedResult, biggestSequence);
        }
    }
}
