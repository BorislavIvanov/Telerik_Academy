//* Write a program that reads a positive integer number N (N < 20) from console and outputs in the console
//the numbers 1 ... N numbers arranged as a spiral.

using System;

class Spiral
{
    public static void fun()
    {
        Console.WindowHeight = 57;
        Console.WindowWidth = 150;
    }
    static void Main()
    {
        Spiral.fun();

        Console.Write("Input size of matrix N: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int counter = 1;
        int topPositionX = 0;
        int bottomPositionX = n - 1;
        int topPositionY = 0;
        int bottomPositionY = n - 1;

        Console.WriteLine(new string ('~', 23));

        while (counter <= n * n)
        {
            // go right
            for (int i = topPositionX; i <= bottomPositionX; i++)
            {
                matrix[i, topPositionY] = counter;
                counter++;
            }
            topPositionY++;

            // go down
            for (int i = topPositionY; i <= bottomPositionY; i++)
            {
                matrix[bottomPositionX, i] = counter;
                counter++;
            }
            bottomPositionX--;

            //go left
            for (int i = bottomPositionX; i >= topPositionX; i--)
            {
                matrix[i, bottomPositionY] = counter;
                counter++;
            }
            bottomPositionY--;

            // go up
            for (int i = bottomPositionY; i >= topPositionY; i--)
            {
                matrix[topPositionX, i] = counter;
                counter++;
            }
            topPositionX++;
        }

        // Print the matrix
        for (int row = 0; row < n; row++)
        {
            for (int column = 0; column < n; column++)
            {
                Console.Write("{0,5}", matrix[column, row]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

