using System;
using System.Text;

class Student : Human
{
    private byte grade;

    // Property
    public byte Grade
    {
        get { return this.grade; }
        set
        {
            if (value < 1)
            {
                throw new ArgumentOutOfRangeException("The grade must be positive number and more than 0");
            }
            else if (value > 12)
            {
                throw new ArgumentOutOfRangeException("The grade must be in range from 1 to 12");
            }
            else
            {
                this.grade = value;
            }
        }
    }

    // Constructor
    public Student(string firstName, string lastName, byte grade)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Grade = grade;
    }

    // Method
    public override string ToString()
    {
        StringBuilder print = new StringBuilder();

        print.Append("FirstName: ");
        print.Append(this.FirstName);
        print.Append(", ");
        print.Append("LastName: ");
        print.Append(this.LastName);
        print.Append(", ");
        print.Append("Grade: ");
        print.Append(this.Grade);
        print.Append(";");

        return print.ToString();
    }
}