using System;
using System.Text;

public enum Gender { Male, Female }

class Animal
{
    private string name;
    private byte age;
    private Gender gender;

    // Property
    public string Name
    {
        get { return this.name; }
        set
        {
            if (value.Length < 1)
            {
                throw new ArgumentOutOfRangeException("The Animal name cant be 0 symbols!!!");
            }
            else
            {
                this.name = value;
            }
        }
    }
    public byte Age
    {
        get { return this.age; }
        set
        {
            if (value > 100)
            {
                throw new ArgumentOutOfRangeException("The Animal Age cant with value 100!!!");
            }
            else
            {
                this.age = value;
            }
        }
    }
    public Gender Gender
    {
        get { return this.gender; }
        set
        {
            if (Enum.IsDefined(typeof(Gender), value))
            {
                this.gender = value;
            }
            else
            {
                throw new ArgumentException("The Gender must be Male or Female!!!");
            }
        }
    }

    // Constructor
    public Animal(string name, byte age, Gender gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
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
        print.Append(";");

        return print.ToString();
    }
}