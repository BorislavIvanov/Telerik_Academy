using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    public abstract class Course
    {
        private string courseName;
        private string teacherName;
        private IList<string> students;

        public Course()
        {
            
        }

        public Course(string courseName)
            : this(courseName, "UnknownTeacherName", null)
        {
            this.Students = new List<string>();
        }

        public Course(string courseName, string teacherName)
            : this(courseName, teacherName, null)
        {
            
        }

        public Course(string courseName, string teacherName, IList<string> students)
        {
            this.CourseName = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        public string CourseName
        {
            get
            {
                return this.courseName;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("CourseName value can't be null, empty or with witespaces");
                }
                else
                {
                    this.courseName = value;
                }
            }
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("TeacherName value can't be null, empty or with witespaces");
                }
                else
                {
                    this.teacherName = value;
                }
            }
        }

        public IList<string> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students = value;
            }
        }

        public void AddStudent(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Student name can't be null, empty or with witespaces");
            }
            else
            {
                this.Students.Add(name);
            }
        }

        private string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Name = ");
            result.Append(this.CourseName);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }
            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
            return result.ToString();
        }
    }
}
