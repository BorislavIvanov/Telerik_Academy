using System;
using System.Text;
using System.Collections.Generic;

class Discipline : ICommentable
{
    private string name;
    private List<string> comment = new List<string>();
    private int numberOfLectures;
    private int numberOfExercises;

    //Property
    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (value.Length < 0)
            {
                throw new ArgumentOutOfRangeException("The Name Of Discipline must be more than 0 symbols!!!");
            }
            else
            {
                this.name = value;
            }
        }
    }
    public int NumberOfLectures
    {
        get
        {
            return this.numberOfLectures;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Number Of Lectures must be 0 or positive number!!!");
            }
            else
            {
                this.numberOfLectures = value;
            }
        }
    }
    public int NumberOfExercises
    {
        get
        {
            return this.numberOfExercises;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Number Of Exercises must be 0 or positive number!!!");
            }
            else
            {
                this.numberOfExercises = value;
            }
        }
    }
    public List<string> Comment
    {
        get { return this.comment; }
    }

    // Constructor
    public Discipline(string name, int numberOfLectures, int numberOfExercises)
    {
        this.Name = name;
        this.NumberOfLectures = numberOfLectures;
        this.NumberOfExercises = numberOfExercises;
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

        print.Append("Name: " + this.Name);
        print.Append(", ");
        print.Append("Lectures(count): " + this.NumberOfLectures);
        print.Append(", ");
        print.Append("Exercises(count): " + this.NumberOfExercises);
        print.Append(";");

        return print.ToString();
    }
}