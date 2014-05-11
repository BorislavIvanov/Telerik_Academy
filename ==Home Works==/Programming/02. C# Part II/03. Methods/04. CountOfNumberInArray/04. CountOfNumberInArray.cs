//04.Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is working correctly.

using System;

namespace _04.CountOfNumberInArray
{
    public class CountOfNumberInArray
    {
        public static int Counting(int number, params int[] array)
        {
            int theCount = 0;
            foreach (int numberOfArray in array)
            {
                if (numberOfArray == number)
                {
                    theCount++;
                }
            }
            return theCount;
        }
        static void Main()
        {
            Console.Write("Enter Length of the array: ");
            int arrLength = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int[] array = new int[arrLength];

            for (int i = 0; i < arrLength - 1; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            Console.Write("Enter The Number: ");
            int theNumber = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Number {0} appear {1} time/s", theNumber, Counting(theNumber, array));

            Console.WriteLine();

        }
    }
}
