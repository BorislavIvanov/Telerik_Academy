using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._19.GroupedStudents
{
    public static class ExtensionMethods
    {
        public static Dictionary<string, List<Student>> GroupTheStudents(this List<Student> listOfStudents)
        {
            var groupedStudents =
                                 from student in listOfStudents
                                 group student by student.GroupName
                                 into newGroup orderby newGroup.Key
                                               select newGroup;

            return groupedStudents.ToDictionary(g => g.Key, g => g.ToList());
        }
    }
}
