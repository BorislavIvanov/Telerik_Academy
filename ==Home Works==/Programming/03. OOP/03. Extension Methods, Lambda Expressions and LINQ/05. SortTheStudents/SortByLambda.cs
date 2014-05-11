using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortByLambda
{
    private Student[] students;
    private List<Student> orderedStudents = new List<Student>();

    public Student[] Students
    {
        get{ return this.students; }
        set { this.students = value; }
    }

    public SortByLambda(Student[] students)
    {
        this.Students = students;
    }

    public void LambdaSort()
    {
        var sorting =
            this.Students.OrderByDescending(x => x.FirstName).ThenByDescending(y => y.SecondName);

        foreach (Student student in sorting)
        {
            this.orderedStudents.Add(student);
        }
    }

    public void PrintSortedStudents()
    {
        foreach (Student students in orderedStudents)
        {
            Console.WriteLine("First: {0}, Last: {1};", students.FirstName, students.SecondName);
        }
    }
}