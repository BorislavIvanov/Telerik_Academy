using System;
using GSMProgram;
using System.Collections.Generic;

namespace GSMCallHistoryTest
{
    class GSMCallHistoryTest// Task 12
    {
        static void Main()
        {
            decimal pricePerMinute = 0.37m;

            GSM myGSM = new GSM("LG Titan", "LG", 899m);
            
            myGSM.AddCall(new Call(DateTime.Parse("05.09.2013 15:45"), "0886471982", 400));
            myGSM.AddCall(new Call(DateTime.Parse("01.09.2013 09:03"), "0873497201", 200));
            myGSM.AddCall(new Call(DateTime.Parse("09.09.2013 16:16"), "0985412769", 626));

            Console.WriteLine("Call History: ");
            myGSM.CallHistoryPrint();
            Console.WriteLine("Total Calls Coast: {0:C}", myGSM.TotalCallPrice(pricePerMinute));
            Console.WriteLine();

            myGSM.DeleteCall(2);

            Console.WriteLine("Call History after the removed call:");
            myGSM.CallHistoryPrint();
            Console.WriteLine("Total Calls Coast: {0:C}", myGSM.TotalCallPrice(pricePerMinute));
            Console.WriteLine();

            myGSM.DeleteAllHistory();

            Console.WriteLine("Cleared CallHistory:");
            myGSM.CallHistoryPrint();
            Console.WriteLine("Total Calls Coast: {0:C}", myGSM.TotalCallPrice(pricePerMinute));
            Console.WriteLine();
        }
    }
}
