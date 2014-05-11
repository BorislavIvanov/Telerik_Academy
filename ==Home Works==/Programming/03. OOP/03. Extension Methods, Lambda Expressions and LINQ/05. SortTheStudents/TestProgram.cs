// 05. Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name
//and last name in descending order. Rewrite the same with LINQ.

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
            new Student("Iliqn", "Krasimirov"),
            new Student("Iliqn", "Aleksandrov"),
            new Student("Kalin", "Stoimenov"),
            new Student("Genadi", "Gavrilov"),
            new Student("Genadi", "Qnchev"),
            new Student("Malinka", "Dimitrova"),
            new Student("Magi", "Aleksieva")
        };

        SortByLambda lambdaSort = new SortByLambda(students);
        SortByLINQ linqSort = new SortByLINQ(students);

        lambdaSort.LambdaSort();
        linqSort.LINQSort();

        Console.WriteLine("Lambda Sorting:");
        Console.WriteLine();
        lambdaSort.PrintSortedStudents();
        Console.WriteLine(new string('-', 5));
        Console.WriteLine("LINQ Sorting:");
        Console.WriteLine();
        linqSort.PrintSortedStudents();

        Console.WriteLine();
    }
}