using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public class School
    {
        private string name;

        public School(string name)
        {
            this.Name = name;
            this.Courses = new List<Course>();
        }

        public List<Course> Courses { get; set; }

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

        public void AddCourse(Course course)
        {
            this.Courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            bool courseFound = false;
            for (int i = 0; i < this.Courses.Count; i++)
            {
                if (this.Courses[i].Name == course.Name)
                {
                    courseFound = true;
                    this.Courses.Remove(course);
                }
            }

            if (!courseFound)
            {
                throw new ArgumentException("The course does not exist in this course!");
            }
        }

        public int CountOfCourses()
        {
            int countOfCourses = this.Courses.Count;

            return countOfCourses;
        }
    }
}
