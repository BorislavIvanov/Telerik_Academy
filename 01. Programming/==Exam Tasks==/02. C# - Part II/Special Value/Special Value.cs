using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int inputLinesCount = int.Parse(Console.ReadLine());

        int[][] field = new int[inputLinesCount][];

        for (int i = 0; i < inputLinesCount; i++)
        {
            string[] inputLine = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            field[i] = new int[inputLine.Length];

            for (int r = 0; r < inputLine.Length; r++)
            {
                field[i][r] = int.Parse(inputLine[r]);
            }
        }

        bool[][] stepsOnField = new bool[inputLinesCount][];

        for (int s = 0; s < inputLinesCount; s++)
        {
            stepsOnField[s] = new bool[field[s].Length];
        }

        BigInteger maxSpecialNumber = default(BigInteger);

        for (int t = 0; t < field[0].Length; t++)
        {
            int jumpCount = 0;

            int currentRow = 0;
            int currentCol = t;

            while (true)
            {
                jumpCount++;

                if (stepsOnField[currentRow][currentCol] == true)
                {
                    break;
                }
                else if (field[currentRow][currentCol] < 0)
                {
                    BigInteger calculation = jumpCount + (field[currentRow][currentCol] * -1); //Slow!!! Maybe ulong is better.

                    if (calculation > maxSpecialNumber)
                    {
                        maxSpecialNumber = calculation;
                    }

                    break;
                }

                stepsOnField[currentRow][currentCol] = true;
                currentCol = field[currentRow][currentCol];
                currentRow++;

                if (currentRow >= inputLinesCount)
                {
                    currentRow = 0;
                }
            }
        }

        Console.WriteLine(maxSpecialNumber);
    }
}