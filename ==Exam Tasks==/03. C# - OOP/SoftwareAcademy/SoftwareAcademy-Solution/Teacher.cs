using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademy
{
    public class Teacher : ITeacher
    {
        string name;
        List<ICourse> teacherCources;

        public Teacher(string name)
        {
            this.Name = name;
            teacherCources = new List<ICourse>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The Teacher Name is Invalid!!!");
                }
                else
                {
                    this.name = value;
                }
            }
        }
        public List<ICourse> TeacherCources
        {
            get
            {
                return this.teacherCources;
            }
        }

        public void AddCourse(ICourse course)
        {
            teacherCources.Add(course);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendFormat("Teacher: Name={0}", this.Name);
            
            if (this.TeacherCources.Count > 0)
            {
                output.AppendFormat("; Courses=[{0}]", String.Join(", ", this.TeacherCources.Select(cource => cource.Name)));
            }

            return output.ToString();
        }
    }
}
