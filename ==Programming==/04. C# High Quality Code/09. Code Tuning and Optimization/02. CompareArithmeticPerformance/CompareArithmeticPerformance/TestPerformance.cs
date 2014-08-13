using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ComparePerfArithmeticPrimitiveValues
{
    class TestPerformance
    {
        static void Main()
        {
            Stopwatch stopwatch = new Stopwatch();

            // AddMethods

            Console.WriteLine("AddMethods:");
            stopwatch.Start();
            AddMethods.AddDecimal(8m, 50000m);
            stopwatch.Stop();
            Console.WriteLine("Decimal - " + stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            AddMethods.AddDouble(8d, 50000d);
            stopwatch.Stop();
            Console.WriteLine("Double - " + stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            AddMethods.AddFloat(8f, 50000f);
            stopwatch.Stop();
            Console.WriteLine("Float - " + stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            AddMethods.AddInt(8, 50000);
            stopwatch.Stop();
            Console.WriteLine("Int - " + stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            AddMethods.AddLong(8L, 50000L);
            stopwatch.Stop();
            Console.WriteLine("Long - " + stopwatch.Elapsed);
            stopwatch.Reset();

            // SubstractMethods
            Console.WriteLine();
            Console.WriteLine("SubstractMethods:");

            stopwatch.Start();
            SubstractMethods.SubstractDecimal(500000m, 8m);
            stopwatch.Stop();
            Console.WriteLine("Decimal - " + stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            SubstractMethods.SubstractDouble(500000d, 8d);
            stopwatch.Stop();
            Console.WriteLine("Double - " + stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            SubstractMethods.SubstractFloat(500000f, 8f);
            stopwatch.Stop();
            Console.WriteLine("Float - " + stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            SubstractMethods.SubstractInt(500000, 8);
            stopwatch.Stop();
            Console.WriteLine("Int - " + stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            SubstractMethods.SubstractLong(500000L, 8L);
            stopwatch.Stop();
            Console.WriteLine("Long - " + stopwatch.Elapsed);
            stopwatch.Reset();

            // MultiplyMethods
            Console.WriteLine();
            Console.WriteLine("MultiplyMethods:");

            stopwatch.Start();
            MultiplyMethods.MultiplyDecimal(3m, 50000m, 8m);
            stopwatch.Stop();
            Console.WriteLine("Decimal - " + stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            MultiplyMethods.MultiplyDouble(3d, 50000d, 8d);
            stopwatch.Stop();
            Console.WriteLine("Double - " + stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            MultiplyMethods.MultiplyFloat(3f, 50000f, 8f);
            stopwatch.Stop();
            Console.WriteLine("Float - " + stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            MultiplyMethods.MultiplyInt(3, 50000, 8);
            stopwatch.Stop();
            Console.WriteLine("Int - " + stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            MultiplyMethods.MultiplyLong(3L, 50000L, 8L);
            stopwatch.Stop();
            Console.WriteLine("Long - " + stopwatch.Elapsed);
            stopwatch.Reset();

            // DivideMethods
            Console.WriteLine();
            Console.WriteLine("DivideMethods:");

            stopwatch.Start();
            DivideMethods.DivideDecimal(50000m, 50m, 2m);
            stopwatch.Stop();
            Console.WriteLine("Decimal - " + stopwatch.Elapsed);
            stopwatch.Reset();
            
            stopwatch.Start();
            DivideMethods.DivideDouble(50000d, 50d, 2d);
            stopwatch.Stop();
            Console.WriteLine("Double - " + stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            DivideMethods.DivideFloat(50000f, 50f, 2f);
            stopwatch.Stop();
            Console.WriteLine("Float - " + stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            DivideMethods.DivideInt(50000, 50, 2);
            stopwatch.Stop();
            Console.WriteLine("Int - " + stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            DivideMethods.DivideLong(50000L, 50L, 2L);
            stopwatch.Stop();
            Console.WriteLine("Long - " + stopwatch.Elapsed);
            stopwatch.Reset();
        }
    }
}