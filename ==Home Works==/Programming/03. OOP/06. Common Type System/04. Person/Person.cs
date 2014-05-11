using System;
using System.Text;

class Person
{
    private string name;
    private int? age;

    // Properties
    public string Name
    {
        get { return this.name; }
        set
        {
            if (value.Length == 0)
            {
                throw new ArgumentException("The name cant be 0 symbols!!!");
            }
            else
            {
                this.name = value;
            }
        }
    }
    public int? Age
    {
        get { return this.age; }
        set
        {
            if (value < 1 && value > 110 && value != null)
            {
                throw new ArgumentOutOfRangeException("The Age must be in range 1 - 110 or null!!!");
            }
            else
            {
                this.age = value;
            }
        }
    }

    // Constructor
    public Person(string name)
        : this(name, null)
    {
    }
    public Person(string name, int? age)
    {
        this.Name = name;
        this.Age = age;
    }

    // Method
    public override string ToString()
    {
        StringBuilder print = new StringBuilder();

        print.AppendLine("Name - " + this.Name);
        if (this.Age == null)
        {
            print.AppendLine("Age - Age is not specified!");
        }
        else
        {
            print.AppendLine("Age - " + this.Age);
        }

        return print.ToString();
    }
}