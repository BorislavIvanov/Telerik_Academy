using System;
using SchoolSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SchoolSystemTest
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void StudentConstructorNameTest()
        {
            string name = "Kalin Iliev";
            int uniqueNumber = 11223;
            Student student = new Student(name, uniqueNumber);
            Assert.AreEqual(name, student.Name);
        }

        [TestMethod]
        public void StudentConstructorNumberTest()
        {
            string name = "Kalin Iliev";
            int uniqueNumber = 11223;
            Student student = new Student(name, uniqueNumber);
            Assert.AreEqual(uniqueNumber, student.UniqueNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StudentWhiteSpacesNameTest()
        {
            string name = "    ";
            int uniqueNumber = 11223;
            Student student = new Student(name, uniqueNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StudentEmptyNameTest()
        {
            string name = string.Empty;
            int uniqueNumber = 11223;
            Student student = new Student(name, uniqueNumber);
        }

        [TestMethod]
        public void StudentSmallerNumberTest()
        {
            string name = "Kalin Iliev";
            int uniqueNumber = 10000;
            Student student = new Student(name, uniqueNumber);
        }

        [TestMethod]
        public void StudentBiggerNumberTest()
        {
            string name = "Kalin Iliev";
            int uniqueNumber = 99999;
            Student student = new Student(name, uniqueNumber);
        }

        [TestMethod]
        public void StudentRandomNumberInTheRangeTest()
        {
            string name = "Kalin Iliev";
            int uniqueNumber = 12456;
            Student student = new Student(name, uniqueNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentRandomNumberOutOfTheRangeTest()
        {
            string name = "Kalin Iliev";
            int uniqueNumber = 1245666;
            Student student = new Student(name, uniqueNumber);
        }

        [TestMethod]
        public void StudentToStringTest()
        {
            string name = "Kalin Iliev";
            int uniqueNumber = 12456;
            Student student = new Student(name, uniqueNumber);
            Assert.AreEqual("Student Kalin Iliev - Unique Number: 12456", student.ToString());
        }
    }
}
