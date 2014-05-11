// 07. Using delegates write a class Timer that has can execute certain method at each t seconds.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TestTheTimer
{
    static void Main()
    {
        Timer theTimer = new Timer(2000);
        theTimer.CurrentMethod = TestMethod;
        theTimer.Execute();
    }

    static void TestMethod()
    {
        Console.WriteLine("Text for Tests!!!");
    }
}