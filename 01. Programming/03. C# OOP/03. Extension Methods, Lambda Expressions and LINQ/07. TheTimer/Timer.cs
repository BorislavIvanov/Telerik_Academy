using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

class Timer
{
    public delegate void MethodToExecute();

    private int interval;
    private MethodToExecute currentMethod;

    public int Interval
    {
        get { return this.interval; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Invalid Interval of Time!!!");
            }
            else
            {
                this.interval = value;
            }
        }
    }
    public MethodToExecute CurrentMethod
    {
        get { return this.currentMethod; }
        set { this.currentMethod = value; }
    }

    public Timer(int intervalInMiliseconds)
    {
        this.Interval = intervalInMiliseconds;
    }

    public void Execute()
    {
        while (true)
        {
            Thread.Sleep(this.Interval);
            CurrentMethod();
        }
    }
}