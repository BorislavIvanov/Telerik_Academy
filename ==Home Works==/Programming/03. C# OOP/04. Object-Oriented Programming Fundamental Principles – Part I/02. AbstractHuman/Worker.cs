using System;
using System.Text;

class Worker : Human
{
    private decimal weekSalary;
    private int workHoursPerDay;
    
    // Property
    public decimal WeekSalary
    {
        get { return this.weekSalary; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Salary must be positive number!!!");
            }
            else
            {
                this.weekSalary = value;
            }
        }
    }
    public int WorkHoursPerDay
    {
        get { return this.workHoursPerDay; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Work Hours must be positive number!!!");
            }
            else
            {
                this.workHoursPerDay = value;
            }
        }
    }

    // Constructor
    public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    // Methods
    public decimal MoneyPerHour()
    {
        decimal calculation = (this.WeekSalary / 5) / this.WorkHoursPerDay;
        return calculation;
    }
    public override string ToString()
    {
        StringBuilder print = new StringBuilder();

        print.Append("FirstName: ");
        print.Append(this.FirstName);
        print.Append(", ");
        print.Append("LastName: ");
        print.Append(this.LastName);
        print.Append(", ");
        print.Append("Week Salary: ");
        print.Append(this.WeekSalary);
        print.Append(", ");
        print.Append("Work Hours Per Day: ");
        print.Append(this.WorkHoursPerDay);
        print.Append(";");

        return print.ToString();
    }
}