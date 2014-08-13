//Write a program that prints all the numbers from 1 to N.

using System;

    class From1ToN
    {
        static void Main()
        {
            Console.Title = "From 1 To N";

            Console.Write("Please enter The N (N > 1): ");
            string consoleInput = Console.ReadLine();

            int numberN;

            while (!int.TryParse(consoleInput, out numberN) || (numberN < 1))
            {
                Console.Write("Please enter Valid N number!!!(from 1 to 2,147,483,647): ");
                consoleInput = Console.ReadLine();
            }

            Console.WriteLine(new string ('~',27));
            Console.WriteLine("All Numbers From 1 to {0}:", numberN);

            for (int i = 1; i <= numberN; i++)
            {
                Console.WriteLine("\n{0}", i);
            }
            
        }
    }

