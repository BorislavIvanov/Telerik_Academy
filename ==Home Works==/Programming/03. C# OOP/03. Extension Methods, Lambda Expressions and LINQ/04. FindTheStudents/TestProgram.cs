// 04. Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TestProgram
{
    static void Main()
    {
        Student[] students =
        {
            new Student("Georgi", "Kacarski", 20),
            new Student("Anatoli", "Arnuldov", 35),
            new Student("Kaloqn", "Vergilov", 24),
            new Student("Kalinka", "Dimitrova", 17),
            new Student("Aneliq", "Toteva", 21)
        };

        Finder findedStudents = new Finder(students);
        findedStudents.FindTheStudents();

        Console.WriteLine("Print the result: ");
        findedStudents.PrintFindedStudents();
        Console.WriteLine();
    }
}