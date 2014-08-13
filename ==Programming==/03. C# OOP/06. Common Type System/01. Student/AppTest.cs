// 01. Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, 
//mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties. 
//Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
//
// 02. Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object 
//of type Student.
//
// 03. Implement the  IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and 
//by social security number (as second criteria, in increasing order).

using System;

class AppTest
{
    static void Main()
    {
        Student studOne = new Student("Nikolai", "Iliev", "Kirilov", 8741, "Sofiq", 0884125741, "Kirilov@gmail.com", 3, 
                                        Specialty.Telecommunications, University.SU, Faculty.Telecommunications);
        Student studTwo = new Student("Stanislav", "Krasimirov", "Ivanov", 2478, "Varna", 0894715687, "Ivanov@gmail.com", 1,
                                        Specialty.Mathematics, University.VINS, Faculty.Mathematics);
        Student studThree = new Student("Nikolai", "Iliev", "Kirilov", 8741, "Sofiq", 0884125741, "Kirilov@gmail.com", 3,
                                        Specialty.ArtsOfMarketing, University.VINS, Faculty.Business);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("StudOne equal StudTwo: {0}" , studOne.Equals(studTwo));
        Console.WriteLine("StudOne equal StudThree: {0}", studOne.Equals(studThree));
        Console.WriteLine();
        Console.WriteLine("StudOne == StudTwo: {0}", studOne == studTwo);
        Console.WriteLine("StudOne == StudThree: {0}", studOne == studThree);
        Console.WriteLine();
        Console.WriteLine("StudOne HashCode: {0}", studOne.GetHashCode());
        Console.WriteLine("StudTwo HashCode: {0}", studTwo.GetHashCode());
        Console.WriteLine();
        Console.WriteLine("StudOne Deep Clone in StudFour...");
        Student studFour = studOne.Clone();
        Console.WriteLine();
        Console.WriteLine("Print StudFour: ");
        Console.ResetColor();
        Console.WriteLine(studFour);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("StudOne compare to StudTwo: {0}", studOne.CompareTo(studTwo));
    }
}