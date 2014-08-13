using System;

class InvalidRangeException<T> : ApplicationException
{
    private T min;
    private T max;

    // Property
    public T Min
    {
        get { return this.min; }
        set { this.min = value; }
    }
    public T Max
    {
        get { return this.max; }
        set { this.max = value; }
    }

    // Constructor
    public InvalidRangeException(T min, T max)
    {
        this.Min = min;
        this.Max = max;
    }

    public override string Message
    {
        get
        {
            string result = String.Format("The value is out of range {0} - {1}", Min, Max);
            return result;
        }
    }
}