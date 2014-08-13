using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._19.GroupedStudents
{
    class TestProgram
    {
        private static List<Student> listOfStudents = new List<Student>(){
                new Student("Kiril", "Timon"),
                new Student("Gergana", "Pumba"),
                new Student("Stanimir", "TheCats"),
                new Student("Yolina", "Timon"),
                new Student("Iliq", "TheCats"),
            };

        static void Main(string[] args)
        {
            Task18();
            Task19();
        }

        private static void Task19()
        {
            var groupedStudents = listOfStudents.GroupTheStudents();

            foreach (var item in groupedStudents)
            {
                foreach (var student in item.Value)
                {
                    Console.WriteLine("[" + student.GroupName + "] " + student.StudentName);
                }
            }
        }

        private static void Task18()
        {
            var groupedStudents =
                from student in listOfStudents
                group student by student.GroupName into newGroup
                orderby newGroup.Key
                select newGroup;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Task 18:");
            Console.ResetColor();

            foreach (var group in groupedStudents)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(group.Key);
                Console.ResetColor();

                foreach (var student in group)
                {
                    Console.WriteLine(student.StudentName);
                }
                Console.WriteLine();
            }
        }
    }
}