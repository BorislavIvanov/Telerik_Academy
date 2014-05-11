// 03. Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
//Use LINQ query operators.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class TestProgram
{
    static void Main()
    {
        Student[] groupOfStudents =
        {
            new Student("Georgi", "Alexiev"),
            new Student("Georgi", "Iliev"),
            new Student("Alexander", "Iliev"),
            new Student("Borimir", "Stoilov"),
            new Student("Katq", "Aleksieva")
        };

        Filter filtrateGroup = new Filter(groupOfStudents);
        filtrateGroup.FilterTheGroup();

        Console.WriteLine("Print Filtered Group: ");
        filtrateGroup.PrintTheGroup();
        Console.WriteLine();
    }
}

