using System;

public class Student
{
    private string firstName;
    private string secondName;
    private int age;

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
    public int Age
    {
        get { return this.age; }
        set
        {
            if (value < 0 || value > 110)
            {
                throw new ArgumentOutOfRangeException("Age value is Out of range!!!");
            }
            else
            {
                this.age = value;
            }
        }
    }

    public Student(string firstName, string secondName, int age)
    {
        this.FirstName = firstName;
        this.SecondName = secondName;
        this.Age = age;
    }
}
