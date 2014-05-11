using System;

class Student
{
    private string firstName;
    private string secondName;

    public string FirstName
    {
        get { return this.firstName; }
        set
        {
            if (value.Length < 1)
            {
                throw new ArgumentException("Invalid First Name!!!");
            }
            else
            {
                this.firstName = value;
            }
        }
    }
    public string SecondName
    {
        get { return this.secondName; }
        set
        {
            if (value.Length < 1)
            {
                throw new ArgumentException("Invalid Second Name!!!");
            }
            else
            {
                this.secondName = value;
            }
        }
    }

    public Student(string firstName, string secondName)
    {
        this.FirstName = firstName;
        this.SecondName = secondName;
    }
}
