using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._16.Students
{
    public static class ExtensionMethods
    {
        public static List<Student> GetAllStudentsFromExactGroup(this List<Student> listOfStudents, int groupNumber)
        {
            var studentsFromGroup =
                from student in listOfStudents
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;

            return studentsFromGroup.ToList();
        }
        public static List<Student> GetAllStudentsWithExactMarkAndCount(this List<Student> listOfStudents, int mark, int count)
        {
            var studentsWithTheMark =
                from student in listOfStudents
                where student.Marks.Count(x => x == mark) == count
                select student;

            return studentsWithTheMark.ToList();
        }
    }
}
