// 02. Define abstract class Human with first name and last name. Define new class Student which is derived from Human 
//and has new field – grade. Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay 
//and method MoneyPerHour() that returns money earned by hour by the worker. Define the proper constructors and properties for this hierarchy. 
//Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method). 
//Initialize a list of 10 workers and sort them by money per hour in descending order. Merge the lists and sort them by first name and last name.

using System;
using System.Collections.Generic;
using System.Linq;

class AppTest
{
    static void Main()
    {
        // Students
        List<Student> listOfStudents = new List<Student>();
        listOfStudents.Add(new Student("AWD", "SAE", 5));
        listOfStudents.Add(new Student("WDK", "UTR", 8));
        listOfStudents.Add(new Student("AFG", "BDB", 12));
        listOfStudents.Add(new Student("TSE", "TER", 3));
        listOfStudents.Add(new Student("YEW", "SCF", 4));
        listOfStudents.Add(new Student("XER", "RHG", 6));
        listOfStudents.Add(new Student("UWE", "JHT", 4));
        listOfStudents.Add(new Student("HRE", "FRY", 2));
        listOfStudents.Add(new Student("ICO", "UYR", 10));
        listOfStudents.Add(new Student("RRR", "TEE", 11));

        // Students - Sorting By Grade
        List<Student> orderedStudentsByGrade =
            (from student in listOfStudents
             orderby student.Grade ascending
             select student).ToList();

        // Students - Printing - Sorted By Grade
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Printing Students in order by Grade(ascending)...");
        Console.ResetColor();
        foreach (Student stud in orderedStudentsByGrade)
        {
            Console.WriteLine(stud);
        }
        Console.WriteLine();

        // Workers
        List<Worker> listOfWorkers = new List<Worker>();
        listOfWorkers.Add(new Worker("TWA", "YEA", 200m, 8));
        listOfWorkers.Add(new Worker("TEW", "GSD", 236.68m, 8));
        listOfWorkers.Add(new Worker("WET", "YRE", 203.40m, 9));
        listOfWorkers.Add(new Worker("HRR", "QCS", 100.20m, 7));
        listOfWorkers.Add(new Worker("WRE", "UTR", 300.90m, 10));
        listOfWorkers.Add(new Worker("TZA", "QAD", 256.16m, 8));
        listOfWorkers.Add(new Worker("KYT", "BFD", 179.40m, 9));
        listOfWorkers.Add(new Worker("YDF", "UER", 50.45m, 3));
        listOfWorkers.Add(new Worker("TUF", "ZSF", 248.14m, 8));
        listOfWorkers.Add(new Worker("GRT", "ERY", 199.90m, 9));

        // Workers - Sorting By MoneyPerHour
        List<Worker> orderedWorkersByMoneyPerHour =
            (from worker in listOfWorkers
             orderby worker.MoneyPerHour() descending
             select worker).ToList();

        // Workers - Printing - Sorted By MoneyPerHour
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Printing Workers in order by MoneyPerHour(descending)...");
        Console.ResetColor();
        foreach (Worker work in orderedWorkersByMoneyPerHour)
        {
            Console.WriteLine(work);
        }
        Console.WriteLine();

        // People
        List<Human> listOfPeople = new List<Human>();
        foreach (Student stud in listOfStudents)
        {
            listOfPeople.Add(stud);
        }
        foreach (Worker work in listOfWorkers)
        {
            listOfPeople.Add(work);
        }

        // People - Sorting By Name
        List<Human> orderedPeopleByName =
            (from person in listOfPeople
             orderby person.FirstName ascending, person.LastName ascending
             select person).ToList();

        // People - Printing - Sorted By Name
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Printing People in order by Name(ascending)...");
        Console.ResetColor();
        foreach (Human person in orderedPeopleByName)
        {
            Console.WriteLine(person);
        }
        Console.WriteLine();

        Console.ReadLine();
    }
}