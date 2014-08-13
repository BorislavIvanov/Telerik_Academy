using System;
using System.Collections.Generic;
using System.Text;

class School
{
    private string schoolName;
    private List<StudentClass> classesInTheSchool = new List<StudentClass>();

    // Property
    public string SchoolName
    {
        get { return this.schoolName; }
        set
        {
            if (value.Length < 1)
            {
                throw new ArgumentOutOfRangeException("Name must be more than 0 symbols!!!");
            }
            else
            {
                this.schoolName = value;
            }
        }
    }
    public List<StudentClass> ClassesInTheSchool
    {
        get { return this.classesInTheSchool; }
        set { this.classesInTheSchool = value; }
    }

    // Construct
    public School(string schoolName)
    {
        this.SchoolName = schoolName;
    }

    // Method
    public void AddSchoolClass(StudentClass studentClass)
    {
        classesInTheSchool.Add(studentClass);
    }
    public void RemoveClassByName(StudentClass studentClass)
    {
        classesInTheSchool.Add(studentClass);
    }
    public void RemoveClassByIndex(int index)
    {
        classesInTheSchool.RemoveAt(index);
    }

    public override string ToString()
    {
        StringBuilder print = new StringBuilder();

        print.AppendLine("=== Classes in school " + this.SchoolName + " ===");
        print.AppendLine();
        if (classesInTheSchool.Count < 0)
        {
            throw new ArgumentException("In school " + this.SchoolName + " dont have any classes!");
        }
        else
        {
            int count = 1;
            foreach (StudentClass studClass in classesInTheSchool)
            {
                print.AppendLine(count + ") " + studClass);
                count++;
            }
        }

        return print.ToString();
    }
}