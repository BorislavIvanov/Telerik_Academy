using System;
using System.Collections.Generic;
using System.Text;

class Teacher : Human, ICommentable
{
    private List<string> comment = new List<string>();
    private List<Discipline> disciplines = new List<Discipline>();

    //Property
    public List<Discipline> Disciplines
    {
        get { return this.disciplines; }
    }
    public List<string> Comment
    {
        get { return this.comment; }
    }

    // Constructor
    public Teacher(string name, int age, Gender gender) : base(name, age, gender)
    {
    }

    // Interface
    public void AddComment(string text)
    {
        this.comment.Add(text);
    }

    // Methods
    public void AddDiscipline(Discipline discipline)
    {
        disciplines.Add(discipline);
    }
    public void RemoveDisciplineByName(Discipline discipline)
    {
        disciplines.Remove(discipline);
    }
    public void RemoveDisciplineByIndex(int index)
    {
        disciplines.RemoveAt(index);
    }
    public override string ToString()
    {
        StringBuilder print = new StringBuilder();

        print.AppendLine("===Teacher - " + this.Name + "===");
        print.Append("Age: " + this.Age);
        print.Append(", ");
        print.Append("Gender: " + this.Gender);
        print.AppendLine(";");
        print.AppendLine("Disciplines: ");

        if (this.Disciplines.Count < 1)
        {
            print.Append("This teacher dont have disciplines!!!");
        }
        else
        {
            foreach (Discipline disc in this.Disciplines)
            {
                print.AppendLine(disc.ToString());
            }
        }

        return print.ToString();
    }
}