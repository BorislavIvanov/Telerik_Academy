// Write a program that reads a rectangular matrix of size N x M
//and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

class MaximalSumOfElements3x3
{
    static void Main()
    {
        Console.Write("Please Enter Number N (N>=3): ");
        int numberN = int.Parse(Console.ReadLine());
        Console.Write("Please Enter Number M (M>=3): ");
        int numberM = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int[,] arr = new int[numberN, numberM];

        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                Console.Write("Enter Num in cell [{0}, {1}]: ", row, col);
                arr[row, col] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine();

        Console.WriteLine("The Matrix:");

        // Matrix Print
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            Console.WriteLine();
            Console.WriteLine();

            for (int col = 0; col < arr.GetLength(1); col++)
            {
                Console.Write(" " + arr[row, col] + " ");
            }
        }

        Console.WriteLine();

        //int[,] arr =
        //{
        //    {3, 4, 7, 9},
        //    {5, 9, 8, 9},
        //    {3, 8, 9, 8},
        //    {5, 9, 8, 9}
        //};

        int higherSum = int.MinValue;
        int theRow = 0;
        int theCol = 0;

        for (int row = 0; row < arr.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < arr.GetLength(1) - 2; col++)
            {
                int sum = arr[row, col] + arr[row, col + 1] + arr[row, col + 2]
                        + arr[row + 1, col] + arr[row + 1, col + 1] + arr[row + 1, col + 2]
                        + arr[row + 2, col] + arr[row + 2, col + 1] + arr[row + 2, col + 2];

                if (sum > higherSum)
                {
                    higherSum = sum;
                    theRow = row;
                    theCol = col;
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("Result: ");
        Console.WriteLine("The HigherSum is {0}", higherSum);
        Console.WriteLine();
        Console.WriteLine(" " + arr[theRow, theCol] + "  " + arr[theRow, theCol + 1] + "  " + arr[theRow, theCol + 2]);
        Console.WriteLine();
        Console.WriteLine(" " + arr[theRow + 1, theCol] + "  " + arr[theRow + 1, theCol + 1] + "  " + arr[theRow + 1, theCol + 2]);
        Console.WriteLine();
        Console.WriteLine(" " + arr[theRow + 2, theCol] + "  " + arr[theRow + 2, theCol + 1] + "  " + arr[theRow + 2, theCol + 2]);
        Console.WriteLine();
    }
}

