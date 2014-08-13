using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Finder
{
    private Student[] students;
    private List<Student> findedStudents = new List<Student>();

    public Student[] Students
    {
        get { return this.students; }
        set { this.students = value; }
    }

    public Finder(Student[] students)
    {
        this.Students = students;
    }

    public void FindTheStudents()
    {
        var finding =
            from student in this.Students
            where student.Age > 17 && student.Age < 25
            orderby student.Age ascending
            select student;

        foreach (Student student in finding)
        {
            findedStudents.Add(student);
        }
    }

    public void PrintFindedStudents()
    {
        foreach (Student student in findedStudents)
        {
            Console.WriteLine("First: {0}, Second: {1}, Age: {2}", student.FirstName, student.SecondName, student.Age);
        }
    }
}