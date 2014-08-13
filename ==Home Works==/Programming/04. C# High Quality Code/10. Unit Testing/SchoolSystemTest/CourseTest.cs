using System;
using SchoolSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SchoolSystemTest
{
    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void CourseConstructorNameTest()
        {
            string name = "C# Course";
            Course cSharpCourse = new Course(name);
            Assert.AreEqual(name, cSharpCourse.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CourseWhiteSpacesNameTest()
        {
            string name = "         ";
            Course cSharpCourse = new Course(name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CourseEmptyNameTest()
        {
            string name = string.Empty;
            Course cSharpCourse = new Course(name);
        }

        [TestMethod]
        public void CourseAddStudentInCourseTest()
        {
            string name = "C# Course";
            Student iliqn = new Student("Iliqn Dimitrov", 21475);
            Course cSharpCourse = new Course(name);
            cSharpCourse.AddStudent(iliqn);

            Assert.AreEqual(1, cSharpCourse.CountOfStudents());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CourseAddStudentWhenCourseIsFullTest()
        {
            string courseName = "C# Course";
            Course cSharpCourse = new Course(courseName);

            string studentName = "Iliqn Dimitrov";
            int studentNumber = 21475;

            for (int i = 0; i < 30; i++)
            {
                studentName += 'Z';
                studentNumber += 1;
                cSharpCourse.AddStudent(new Student(studentName, studentNumber));
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CourseAddAlreadyExistStudentInCourseTest()
        {
            string name = "C# Course";
            Student iliqn = new Student("Iliqn Dimitrov", 21475);
            Student dimitrov = new Student("Iliqn Dimitrov", 21475);
            Course cSharpCourse = new Course(name);
            cSharpCourse.AddStudent(iliqn);
            cSharpCourse.AddStudent(dimitrov);
        }

        [TestMethod]
        public void CourseRemoveStudentFromCourseTest()
        {
            string name = "C# Course";
            Student iliqn = new Student("Iliqn Dimitrov", 21475);
            Course cSharpCourse = new Course(name);
            cSharpCourse.AddStudent(iliqn);
            cSharpCourse.RemoveStudent(iliqn);

            Assert.AreEqual(0, cSharpCourse.CountOfStudents());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CourseRemoveNotExistingStudentFromCourseTest()
        {
            string name = "C# Course";
            Student iliqn = new Student("Iliqn Dimitrov", 21475);
            Course cSharpCourse = new Course(name);
            cSharpCourse.RemoveStudent(iliqn);
        }
    }
}
