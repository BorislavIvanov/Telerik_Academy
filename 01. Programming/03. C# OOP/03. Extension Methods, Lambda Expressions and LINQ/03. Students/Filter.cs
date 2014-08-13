using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Filter
{
    private Student[] preFilteredGroup;
    private List<Student> filteredGroup = new List<Student>();

    public Student[] PreFilteredGroup
    {
        get
        {
            return preFilteredGroup;
        }
        set
        {
            this.preFilteredGroup = value;
        }
    }

    public Filter(Student[] inputGroup)
    {
        this.PreFilteredGroup = inputGroup;
    }

    public void FilterTheGroup()
    {
        var filtration =
            from student in this.PreFilteredGroup
            where student.FirstName.CompareTo(student.SecondName) == -1
            select student;

        foreach (Student student in filtration)
        {
            this.filteredGroup.Add((Student)student);
        }
    }

    public void PrintTheGroup()
    {
        foreach (Student student in this.filteredGroup)
        {
            Console.WriteLine("FirstName: {0}, SecondName: {1}", student.FirstName, student.SecondName);
        }
    }
}