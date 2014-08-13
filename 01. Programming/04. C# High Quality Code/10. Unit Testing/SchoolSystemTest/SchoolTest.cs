using System;
using SchoolSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SchoolSystemTest
{
    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        public void SchoolConstructorNameTest()
        {
            string name = "C# School";
            School cSharpSchool = new School(name);
            Assert.AreEqual(name, cSharpSchool.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SchoolWhiteSpacesNameTest()
        {
            string name = "         ";
            School cSharpSchool = new School(name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SchoolEmptyNameTest()
        {
            string name = string.Empty;
            School cSharpSchool = new School(name);
        }

        [TestMethod]
        public void SchoolAddStudentInCourseTest()
        {
            School cSharpSchool = new School("C# School");
            Course cSharpCourse = new Course("C# Course");

            cSharpSchool.AddCourse(cSharpCourse);

            Assert.AreEqual(1, cSharpSchool.CountOfCourses());
        }

        [TestMethod]
        public void SchoolRemoveStudentFromCourseTest()
        {
            School cSharpSchool = new School("C# School");
            Course cSharpCourse = new Course("C# Course");

            cSharpSchool.AddCourse(cSharpCourse);
            cSharpSchool.RemoveCourse(cSharpCourse);

            Assert.AreEqual(0, cSharpSchool.CountOfCourses());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SchoolRemoveNotExistingStudentFromCourseTest()
        {
            School cSharpSchool = new School("C# School");
            Course cSharpCourse = new Course("C# Course");

            cSharpSchool.RemoveCourse(cSharpCourse);

            Assert.AreEqual(0, cSharpSchool.CountOfCourses());
        }
    }
}
