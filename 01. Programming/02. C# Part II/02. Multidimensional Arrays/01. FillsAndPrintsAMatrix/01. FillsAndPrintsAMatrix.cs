// Write a program that fills and prints a matrix of size (n, n)

using System;

class FillsAndPrintsAMatrix
{
    static void Main()
    {
        Console.Write("Please Type number N (N>0): ");
        int sizeN = int.Parse(Console.ReadLine());
        Console.WriteLine();

        // Case A:
        Console.WriteLine("Case A:\n");
        int[,] arrA = new int[sizeN, sizeN];

        int theNumA = 1;

        for (int col = 0; col < arrA.GetLength(1); col++)
        {
            for (int row = 0; row < arrA.GetLength(0); row++)
            {
                arrA[row, col] = theNumA;
                theNumA++;
            }
        }

        for (int row = 0; row < arrA.GetLength(0); row++)
        {
            for (int col = 0; col < arrA.GetLength(1); col++)
            {
                Console.Write(" {0,2} ", arrA[row, col]);
            }

            Console.WriteLine();
            Console.WriteLine();
        }
        ////

        // Case B:
        Console.WriteLine("Case B:\n");
        int[,] arrB = new int[sizeN, sizeN];

        int theNumB = 1;

        for (int col = 0; col < arrB.GetLength(1); col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < arrB.GetLength(0); row++)
                {
                    arrB[row, col] = theNumB;
                    theNumB++;
                }
            }
            else
            {
                for (int row = arrB.GetLength(0) - 1; row >= 0; row--)
                {
                    arrB[row, col] = theNumB;
                    theNumB++;
                }
            }
        }

        for (int row = 0; row < arrB.GetLength(0); row++)
        {
            for (int col = 0; col < arrB.GetLength(1); col++)
            {
                Console.Write(" {0,2} ", arrB[row, col]);
            }

            Console.WriteLine();
            Console.WriteLine();
        }
        ////

        // Case C:
        Console.WriteLine("Case C:\n");
        int[,] arrC = new int[sizeN, sizeN];

        int theNumC = 1;

        for (int row = sizeN - 1; row >= 0; row--)
        {
            for (int col = 0; col < sizeN - row; col++)
            {
                arrC[row + col, col] = theNumC++;
            }
        }
        for (int col = 1; col < sizeN; col++)
        {
            for (int row = 0; row < sizeN - col; row++)
            {
                arrC[row, col + row] = theNumC++;
            }
        }

        for (int row = 0; row < arrC.GetLength(0); row++)
        {
            for (int col = 0; col < arrC.GetLength(1); col++)
            {
                Console.Write(" {0,2} ", arrC[row, col]);
            }

            Console.WriteLine();
            Console.WriteLine();
        }
        ////

        // Case D:
        Console.WriteLine("Case D:\n");
        int[,] arrD = new int[sizeN, sizeN];

        int theNumD = 1;
        int start = 0;
        int end = sizeN;

        do
        {
            for (int i = start; i < end; i++) // Left Side;
            {
                arrD[i, start] = theNumD;
                theNumD++;
            }
            for (int j = start + 1; j < end; j++) // Bottom Side;
            {
                arrD[end - 1, j] = theNumD;
                theNumD++;
            }
            for (int k = end - 2; k >= start; k--) // Right Side;
            {
                arrD[k, end - 1] = theNumD;
                theNumD++;
            }
            for (int m = end - 2; m > start; m--) // Top Side;
            {
                arrD[start, m] = theNumD;
                theNumD++;
            }

            start++;
            end--;


        } while (end - start > 0);

        for (int row = 0; row < arrD.GetLength(0); row++)
        {
            for (int col = 0; col < arrD.GetLength(1); col++)
            {
                Console.Write(" {0,2} ", arrD[row, col]);
            }

            Console.WriteLine();
            Console.WriteLine();
        }
        ////
        
    }
}

