// 01. We are given a school. In the school there are classes of students. Each class has a set of teachers. 
//Each teacher teaches a set of disciplines. Students have name and unique class number. Classes have unique text identifier. 
//Teachers have name. Disciplines have name, number of lectures and number of exercises. Both teachers and students are people. 
//Students, classes, teachers and disciplines could have optional comments (free text block).
//Your task is to identify the classes (in terms of  OOP) and their attributes and operations, encapsulate their fields, 
//define the class hierarchy and create a class diagram with Visual Studio.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AppTest
{
    static void Main()
    {
        // == Disciplines ==
        Discipline math = new Discipline("Math", 23, 23);
        Discipline bio = new Discipline("Bio", 23, 34);
        Discipline geo = new Discipline("Geo", 27, 44);

        // == Teachers ==
        Teacher Dimitar = new Teacher("Dimitar Lilov", 34, Gender.Male);
        Dimitar.AddDiscipline(math);
        Dimitar.AddDiscipline(bio);

        Teacher Kiril = new Teacher("Kiril Nikolov", 29, Gender.Male);
        Kiril.AddDiscipline(geo);

        // == Students ==
        Student Aneliq = new Student("Aneliq Iordanova", 17, Gender.Female, 000354);
        Student Yoana = new Student("Yoana Ivanova", 18, Gender.Female, 000359);
        Yoana.AddComment("EGN - 2342623623");

        // == List Of Teachers ==
        List<Teacher> teachers = new List<Teacher>();
        teachers.Add(Dimitar);
        teachers.Add(Kiril);

        // == List Of Students ==
        List<Student> students = new List<Student>();
        students.Add(Aneliq);
        students.Add(Yoana);

        // == StudentClass ==
        StudentClass firstClass = new StudentClass("10B", students, teachers);

        // == School ==
        School washington = new School("Washington");
        washington.AddSchoolClass(firstClass);

        // == Printing ==
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Printing School ...");
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine(washington);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Printing Class ...");
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine(firstClass);

        Console.ReadLine();
    }
}