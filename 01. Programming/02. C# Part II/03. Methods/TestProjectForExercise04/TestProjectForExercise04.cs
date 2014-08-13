//04.Write a test program to check if the method is working correctly.
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _04.CountOfNumberInArray;

namespace TestProjectForExercise04
{
    [TestClass]
    public class TestProjectForExercise04
    {
        [TestMethod]
        public void TestOne()
        {
            int[] testArray1 = { 1, 2, 1, 4, 1 };
            int testNumber1 = 1;
            int testResult1 = CountOfNumberInArray.Counting(testNumber1, testArray1);
            Assert.AreEqual(3, testResult1);
        }

        [TestMethod]
        public void TestTwo()
        {
            int[] testArray1 = { 3, 2, 7, 4, 9, 5 };
            int testNumber1 = 6;
            int testResult1 = CountOfNumberInArray.Counting(testNumber1, testArray1);
            Assert.AreEqual(0, testResult1);
        }

        [TestMethod]
        public void TestThree()
        {
            int[] testArray1 = { 1, 1, 1, 1, 1 };
            int testNumber1 = 1;
            int testResult1 = CountOfNumberInArray.Counting(testNumber1, testArray1);
            Assert.AreEqual(5, testResult1);
        }
    }
}
