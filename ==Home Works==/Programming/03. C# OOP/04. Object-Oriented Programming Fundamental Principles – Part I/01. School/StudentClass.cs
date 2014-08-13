using System;
using System.Collections.Generic;
using System.Text;

class StudentClass : ICommentable
{
    private string name;
    private List<string> comment = new List<string>();
    private List<Student> students = new List<Student>();
    private List<Teacher> teachers = new List<Teacher>();

    // Property
    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (value.Length < 1)
            {
                throw new ArgumentOutOfRangeException("Name of the Student Class cant be 0 symbols!!!");
            }
            else
            {
                this.name = value;
            }
        }
    }
    public List<Student> Students
    {
        get { return this.students; }
        set { this.students = value; }
    }
    public List<Teacher> Teachers
    {
        get { return this.teachers; }
        set { this.teachers = value; }
    }
    public List<string> Comment
    {
        get { return this.comment; }
    }

    // Constructor
    public StudentClass(string name, List<Student> students, List<Teacher> teachers)
    {
        this.Name = name;
        this.Students = students;
        this.Teachers = teachers;
    }


    // Interface
    public void AddComment(string text)
    {
        this.comment.Add(text);
    }

    // Method
    public override string ToString()
    {
        StringBuilder print = new StringBuilder();

        print.AppendLine("=== Student Class " + this.Name + " ===");
        print.AppendLine();
        print.AppendLine("     == Students ==");
        print.AppendLine();
        if (this.Students.Count < 0)
        {
            print.AppendLine("This class dont have Students!");
        }
        else
        {
            foreach (Student stud in this.Students)
            {
                print.AppendLine(stud.ToString());
            }
        }
        print.AppendLine();
        print.AppendLine("     == Teachers ==");
        print.AppendLine();
        if (this.Teachers.Count < 0)
        {
            print.AppendLine("This class dont have Teachers!");
        }
        else
        {
            int count = 1;
            foreach (Teacher teach in this.Teachers)
            {
                print.AppendLine(count + ") " + teach.ToString());
                count++;
            }
        }

        return print.ToString();
    }
}