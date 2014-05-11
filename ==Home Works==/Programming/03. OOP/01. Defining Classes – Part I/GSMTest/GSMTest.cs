using System;
using System.Collections.Generic;

namespace GSMProgram
{
    class GSMTest// Task 7
    {
        static void Main()
        {
            List<GSM> mobilePhones = new List<GSM>();

            Battery batOne = new Battery(BatteryType.LiIon, "HTC BAT", 200, 24);

            mobilePhones.Add(new GSM("HTC Space", "HTC", 1099.90m, "Tomsan", batOne, new Display(5.8m, 369750)));
            mobilePhones.Add(new GSM("Samsung Diamond", "Samsung", null, null, new Battery(BatteryType.NiMH, null, 420, null),
                                new Display(4.2m)));

            foreach (GSM device in mobilePhones)
            {
                Console.WriteLine(device.ToString());
            }

            Console.WriteLine(GSM.IPhone4S.ToString());
        }
    }
}
