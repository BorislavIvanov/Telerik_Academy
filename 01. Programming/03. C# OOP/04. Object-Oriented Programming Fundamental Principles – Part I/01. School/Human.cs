using System;

public enum Gender { Male, Female };

class Human
{
    private int age;
    private string name;
    private Gender gender;

    //Property
    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            if (value < 0 || value > 110)
            {
                throw new ArgumentOutOfRangeException("The Age Value is out of range!!!");
            }
            else
            {
                this.age = value;
            }
        }
    }
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
                throw new ArgumentException("Name of The Person must be more than 0 symbols!!!");
            }
            else
            {
                this.name = value;
            }
        }
    }
    public Gender Gender
    {
        get
        {
            return this.gender;
        }
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
    public Human(string name, int age, Gender gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }
}