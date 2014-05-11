using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Threading;

namespace SqrtLogSinusComparison
{
    public class TestPerformance
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Stopwatch timer = new Stopwatch();

            Console.WriteLine("SqrtMethods:");

            timer.Start();
            SqrtMethods.CalculateSqrtDouble(2d, 10000d, 0.002d);
            timer.Stop();
            Console.WriteLine("SqrtDouble - " + timer.Elapsed);
            timer.Reset();

            timer.Start();
            SqrtMethods.CalculateSqrtDecimal(2m, 10000m, 0.002m);
            timer.Stop();
            Console.WriteLine("SqrtDecimal - " + timer.Elapsed);
            timer.Reset();

            timer.Start();
            SqrtMethods.CalculateSqrtFloat(2f, 10000f, 0.002f);
            timer.Stop();
            Console.WriteLine("SqrtFloat - " + timer.Elapsed);
            timer.Reset();

            Console.WriteLine();
            Console.WriteLine("LogMethods:");

            timer.Start();
            LogMethods.CalculateLogDouble(2d, 10000d, 0.002d);
            timer.Stop();
            Console.WriteLine("LogDouble - " + timer.Elapsed);
            timer.Reset();

            timer.Start();
            LogMethods.CalculateLogDecimal(2m, 10000m, 0.002m);
            timer.Stop();
            Console.WriteLine("LogDecimal - " + timer.Elapsed);
            timer.Reset();

            timer.Start();
            LogMethods.CalculateLogFloat(2f, 10000f, 0.002f);
            timer.Stop();
            Console.WriteLine("LogFloat - " + timer.Elapsed);
            timer.Reset();

            Console.WriteLine();
            Console.WriteLine("SinusMethods:");

            timer.Start();
            SinusMethods.CalculateSinDouble(2d, 10000d, 0.002d);
            timer.Stop();
            Console.WriteLine("SinDouble - " + timer.Elapsed);
            timer.Reset();

            timer.Start();
            SinusMethods.CalculateSinDecimal(2m, 10000m, 0.002m);
            timer.Stop();
            Console.WriteLine("SinDecimal - " + timer.Elapsed);
            timer.Reset();

            timer.Start();
            SinusMethods.CalculateSinFloat(2f, 10000f, 0.002f);
            timer.Stop();
            Console.WriteLine("SinFloat - " + timer.Elapsed);
            timer.Reset();
        }
    }
}