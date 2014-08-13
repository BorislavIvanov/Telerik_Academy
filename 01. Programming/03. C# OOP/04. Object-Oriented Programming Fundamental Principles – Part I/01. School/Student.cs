using System;
using System.Collections.Generic;
using System.Text;

class Student : Human, ICommentable
{
    private int studentNumber;
    private List<string> comment = new List<string>();

    // Property
    public int StudentNumber
    {
        get
        {
            return this.studentNumber;
        }
        set
        {
            if (value < 1)
            {
                throw new ArgumentOutOfRangeException("Student Numberm must be more than 0");
            }
            else
            {
                this.studentNumber = value;
            }
        }
    }
    public List<string> Comment
    {
        get { return this.comment; }
    }

    // Constructor
    public Student(string name, int age, Gender gender, int studentNumber) : base(name, age, gender)
    {
        this.StudentNumber = studentNumber;
    }

    //Interface
    public void AddComment(string text)
    {
        this.comment.Add(text);
    }

    // Method
    public override string ToString()
    {
        StringBuilder print = new StringBuilder();

        print.Append("Name: ");
        print.Append(this.Name);
        print.Append(", ");
        print.Append("Age: ");
        print.Append(this.Age);
        print.Append(", ");
        print.Append("Gender: ");
        print.Append(this.Gender);
        print.Append(", ");
        print.Append("Student Number: ");
        print.Append(this.StudentNumber);
        print.Append(";");

        return print.ToString();
    }
}