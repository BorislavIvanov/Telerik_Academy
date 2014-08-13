using System;
using System.Text;

public enum Specialty { ArtsOfMarketing, Informatics, Medic, Mathematics, Telecommunications };
public enum Faculty { Telecommunications, Business, Mathematics, Medic };
public enum University { VINS, UNSS, SU, NBU };

class Student : ICloneable, IComparable<Student>
{
    private string firstName;
    private string middleName;
    private string lastName;
    private int ssn;
    private string permanentAddress;
    private int mobilePhone;
    private string eMail;
    private int course;
    private Specialty specialty;
    private University university;
    private Faculty faculty;

    // Properties
    public string FirstName
    {
        get { return this.firstName; }
        set { this.firstName = value; }
    }
    public string MiddleName
    {
        get { return this.middleName; }
        set { this.middleName = value; }
    }
    public string LastName
    {
        get { return this.lastName; }
        set { this.lastName = value; }
    }
    public int SSN
    {
        get { return this.ssn; }
        set { this.ssn = value; }
    }
    public string PermanentAddress
    {
        get { return this.permanentAddress; }
        set { this.permanentAddress = value; }
    }
    public int MobilePhone
    {
        get { return this.mobilePhone; }
        set { this.mobilePhone = value; }
    }
    public string EMail
    {
        get { return this.eMail; }
        set { this.eMail = value; }
    }
    public int Course
    {
        get { return this.course; }
        set { this.course = value; }
    }
    public Specialty Specialty
    {
        get { return this.specialty; }
        set { this.specialty = value; }
    }
    public University University
    {
        get { return this.university; }
        set { this.university = value; }
    }
    public Faculty Faculty
    {
        get { return this.faculty; }
        set { this.faculty = value; }
    }

    // Constructor
    public Student(string firstName, string middleName, string lastName, int ssn,
                        string permanentAddress, int mobilePhone, string eMail, int course,
                            Specialty specialty, University university, Faculty faculty)
    {
        this.FirstName = firstName;
        this.MiddleName = middleName;
        this.LastName = lastName;
        this.SSN = ssn;
        this.PermanentAddress = permanentAddress;
        this.MobilePhone = mobilePhone;
        this.EMail = eMail;
        this.Course = course;
        this.Specialty = specialty;
        this.University = university;
        this.Faculty = faculty;
    }

    // Methods
    public override string ToString()
    {
        StringBuilder print = new StringBuilder();

        print.AppendLine("|Student - " + this.FirstName + " " + this.MiddleName + " " + this.LastName + "|");
        print.AppendLine("SSN: " + this.SSN + ", " + "Permanent Address: " + this.PermanentAddress);
        print.AppendLine("Mobile Phone: " + this.MobilePhone + ", " + "eMail: " + this.EMail);
        print.AppendLine("Course: " + this.Course + ", " + "Specialty: " + this.Specialty);
        print.AppendLine("Faculty: " + this.Faculty + ", " + "University: " + this.University);

        return print.ToString();
    }
    public override bool Equals(object parameter)
    {
        Student student = parameter as Student;

        if (student == null)
        {
            return false;
        }
        if (!Object.Equals(this.FirstName, student.FirstName))
        {
            return false;
        }
        if (!Object.Equals(this.MiddleName, student.MiddleName))
        {
            return false;
        }
        if (!Object.Equals(this.SSN, student.SSN))
        {
            return false;
        }

        return true;
    }
    public static bool operator ==(Student studentOne, Student studentTwo)
    {
        return Student.Equals(studentOne, studentTwo);
    }
    public static bool operator !=(Student studentOne, Student studentTwo)
    {
        return !Student.Equals(studentOne, studentTwo);
    }
    public override int GetHashCode()
    {
        return FirstName.GetHashCode() ^ MiddleName.GetHashCode() ^ LastName.GetHashCode() ^ SSN.GetHashCode();
    }
    public Student Clone()
    {
        Student clone = new Student
        (
        this.FirstName,
        this.MiddleName,
        this.LastName,
        this.SSN,
        this.PermanentAddress,
        this.MobilePhone,
        this.EMail,
        this.Course,
        this.Specialty,
        this.University,
        this.Faculty
        );

        return clone;
    }

    object ICloneable.Clone()
    {
        return this.Clone();
    }

    public int CompareTo(Student student)
    {
        if (this.FirstName != student.FirstName)
        {
            return (this.FirstName.CompareTo(student.FirstName));
        }
        if (this.MiddleName != student.MiddleName)
        {
            return (this.MiddleName.CompareTo(student.MiddleName));
        }
        if (this.LastName != student.LastName)
        {
            return (this.LastName.CompareTo(student.LastName));
        }
        if (this.SSN != student.SSN)
        {
            return(this.SSN - student.SSN);
        }
        return 0;
    }
}