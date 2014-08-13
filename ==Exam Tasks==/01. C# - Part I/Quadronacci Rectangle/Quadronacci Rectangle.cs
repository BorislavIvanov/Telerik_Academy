using System;
using System.Collections.Generic;

class QuadronacciRectangle
{
    static void Main()
    {
        List<long> quadronachiNumbers = new List<long>();
        for (int i = 0; i < 4; i++)
        {
            quadronachiNumbers.Add(long.Parse(Console.ReadLine()));
        }
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());

        // Test
        //List<int> quadronachiNumbers = new List<int>(new int[] { 5, -5, 1, 2 });
        //int row = 3;
        //int col = 4;

        int quadronachiCount = row * col;

        for (int i = 4; i < quadronachiCount; i++)
        {
            quadronachiNumbers.Add(quadronachiNumbers[i - 1] 
                                    + quadronachiNumbers[i - 2] 
                                        + quadronachiNumbers[i - 3] 
                                            + quadronachiNumbers[i - 4]);
        }

        int position = 1;
        int line = 1;

        for (int i = 0; i < quadronachiNumbers.Count; i++)
        {
            if (position < col)
            {
                Console.Write(quadronachiNumbers[i] + " ");
                position++;
            }
            else if (position == col && line == row)
            {
                Console.Write(quadronachiNumbers[i]);
            }
            else
            {
                Console.WriteLine(quadronachiNumbers[i]);
                position = 1;
                line++;
            }
        }
    }
}