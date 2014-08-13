using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._19.GroupedStudents
{
    class Student
    {
        public string StudentName { get; set; }
        public string GroupName { get; set; }

        public Student(string studentName, string groupName)
        {
            this.StudentName = studentName;
            this.GroupName = groupName;
        }
    }
}
