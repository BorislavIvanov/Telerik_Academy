using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public class Course
    {
        private byte NUMBER_OF_STUDENTS_IN_COURCE = 29;
        private string name;
        private List<Student> studentsInCource;

        public Course(string name)
        {
            this.Name = name;
            this.studentsInCource = new List<Student>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Name can't be missing!");
                }
            }
        }

        public void AddStudent(Student student)
        {
            bool isTheStudentIsInThisCource = CheckIfStudentIsFound(student);

            if (this.studentsInCource.Count == NUMBER_OF_STUDENTS_IN_COURCE)
            {
                throw new ArgumentException("This course is full!");
            }

            if (!isTheStudentIsInThisCource)
            {
                this.studentsInCource.Add(student);
            }
            else
            {
                throw new ArgumentException("This student already exist in the course!");
            }
        }

        public void RemoveStudent(Student student)
        {
            bool isTheStudentIsInThisCource = CheckIfStudentIsFound(student);

            if (isTheStudentIsInThisCource)
            {
                this.studentsInCource.Remove(student);
            }
            else
            {
                throw new ArgumentException("The student does not exist in this course!");
            }
        }

        public int CountOfStudents()
        {
            int countOfStudents = this.studentsInCource.Count;
            
            return countOfStudents;
        }

        private bool CheckIfStudentIsFound(Student student)
        {
            bool studentFound = false;

            for (int i = 0; i < this.studentsInCource.Count; i++)
            {
                if (this.studentsInCource[i].UniqueNumber == student.UniqueNumber)
                {
                    studentFound = true;
                }
            }

            return studentFound;
        }
    }
}
