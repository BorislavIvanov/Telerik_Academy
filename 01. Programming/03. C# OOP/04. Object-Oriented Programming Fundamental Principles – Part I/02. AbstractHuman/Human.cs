using System;

abstract class Human
{
    private string firstName;
    private string lastName;

    // Property
    public string FirstName
    {
        get { return this.firstName; }
        set
        {
            if (value.Length < 1)
            {
                throw new ArgumentOutOfRangeException("First Name cant be 0 symbols!!!");
            }
            else
            {
                this.firstName = value;
            }
        }
    }
    public string LastName
    {
        get { return this.lastName; }
        set
        {
            if (value.Length < 1)
            {
                throw new ArgumentOutOfRangeException("Last Name cant be 0 symbols!!!");
            }
            else
            {
                this.lastName = value;
            }
        }
    }
}