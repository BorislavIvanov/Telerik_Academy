using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._16.Students
{
    class TestProgram
    {
        private static List<Student> listOfStudents = new List<Student>(){
            new Student("Kiril", "Iliev", "005406", "02/58798", "kiril@gmail.com", 2,           4, 3, 3, 6),
            new Student("Anton", "Belev", "544187", "034/76189", "anton@gmail.com", 3,          6, 3, 2, 5, 4),
            new Student("Stanimir", "Yordanov", "347902", "02/17934", "stanimir@abv.bg", 1,     2, 1, 4, 2),
            new Student("Polq", "Gateva", "017006", "012/71669", "polq@abv.bg", 4,              2, 2, 5, 6, 3, 5),
            new Student("Desislava", "Ivanova", "587962", "02/03487", "desi@gmail.com", 2,      2, 6, 4, 3, 4)
        };

        static void Main(string[] args)
        {
            Task9();
            Task10();
            Task11();
            Task12();
            Task13();
            Task14();
            Task15();
            Task16();
        }

        private static void Task16()
        {
            List<Group> listOfGroups = new List<Group>(){
                new Group(1, "Biology"),
                new Group(2, "Marketing"),
                new Group(3, "IT-Group"),
                new Group(4, "Mathematics")
            };

            var studentsFromMathGroup =
                from student in listOfStudents
                join colegeGroup in listOfGroups on student.GroupNumber equals colegeGroup.GroupNumber
                where colegeGroup.DepartmentName == "Mathematics"
                select student;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Task 16:");
            Console.ResetColor();

            foreach (var student in studentsFromMathGroup)
            {
                Console.WriteLine(student);
            }
        }

        private static void Task15()
        {
            var studentsFrom2006 =
                from student in listOfStudents
                where student.FN.Substring(4, 2) == "06"
                select student;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Task 15:");
            Console.ResetColor();

            foreach (Student student in studentsFrom2006)
            {
                Console.WriteLine(student);
            }
        }

        private static void Task14()
        {
            var selectedStudents = listOfStudents.GetAllStudentsWithExactMarkAndCount(2, 2);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Task 14:");
            Console.ResetColor();

            foreach (Student student in selectedStudents)
            {
                Console.WriteLine(student);
            }
        }

        private static void Task13()
        {
            var studentsWithExcellentMark =
                from student in listOfStudents
                where student.Marks.Contains(6)
                select new { FullName = string.Format("{0} {1}", student.FirstName, student.LastName), 
                                Marks = string.Join(", ", student.Marks) };

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Task 13:");
            Console.ResetColor();
            
            foreach (var student in studentsWithExcellentMark)
            {
                Console.WriteLine("{0}'s marks: {1}", student.FullName, student.Marks);
            }
        }

        private static void Task12()
        {
            var studentsWithPhonesInSofia =
                from student in listOfStudents
                where student.Tel.StartsWith("02/")
                select student;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Task 12:");
            Console.ResetColor();

            foreach (Student student in studentsWithPhonesInSofia)
            {
                Console.WriteLine(student);
            }
        }

        private static void Task11()
        {
            var studentsWithAbvEmail =
                from student in listOfStudents
                where student.Email.EndsWith("@abv.bg")
                select student;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Task 11:");
            Console.ResetColor();

            foreach (Student student in studentsWithAbvEmail)
            {
                Console.WriteLine(student);
            }
        }

        private static void Task10()
        {
            var selectedStudents = listOfStudents.GetAllStudentsFromExactGroup(2);
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Task 10:");
            Console.ResetColor();

            foreach (Student student in selectedStudents)
            {
                Console.WriteLine(student);
            }
        }

        private static void Task9()
        {
            var StudentsFromGroupTwo =
                from student in listOfStudents
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Task 9:");
            Console.ResetColor();

            foreach (Student student in StudentsFromGroupTwo)
            {
                Console.WriteLine(student);
            }
        }
    }
}
