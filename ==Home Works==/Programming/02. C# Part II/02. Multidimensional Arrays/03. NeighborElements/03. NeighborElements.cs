// We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements
// located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix.

using System;

class NeighborElements
{
    static void Main()
    {
        Console.Write("Please Enter Number N: ");
        int numberN = int.Parse(Console.ReadLine());
        Console.Write("Please Enter Number M: ");
        int numberM = int.Parse(Console.ReadLine());
        Console.WriteLine();

        string[,] arr = new string[numberN, numberM];

        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                Console.Write(@"Enter ""String"" in cell [{0}, {1}]: ", row, col);
                arr[row, col] = Console.ReadLine();
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
        Console.WriteLine();

        //// Test1:
        //string[,] arr =
        //{
        //    {"ha", "fifi", "ho", "hi"},
        //    {"fo", "ha", "hi", "ho"},
        //    {"xxx", "xx", "ha", "hi"}
        //};

        int series = 1;
        int maxSeries = 1;
        string word = "";
        string maxWord = "";

        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                // Same column;
                for (int i = row + 1; i < arr.GetLength(0); i++)
                {
                    if (word.Length == 0)
                    {
                        word += arr[row, col];
                    }

                    if (arr[row, col] == arr[i, col])
                    {
                        series++;
                        word += ", " + arr[i, col];

                        if (series > maxSeries)
                        {
                            maxSeries = series;
                            maxWord = word;
                        }
                    }
                    else
                    {
                        word = "";
                        series = 1;
                        break;
                    }
                }
                // Same column - End //

                // Same line;
                for (int i = col + 1; i < arr.GetLength(1); i++)
                {
                    if (word.Length == 0)
                    {
                        word += arr[row, col];
                    }

                    if (arr[row, col] == arr[row, i])
                    {
                        series++;
                        word += ", " + arr[row, i];

                        if (series > maxSeries)
                        {
                            maxSeries = series;
                            maxWord = word;
                        }
                    }
                    else
                    {
                        word = "";
                        series = 1;
                        break;
                    }
                }
                // Same line - End //

                // Same diagonal;
                for (int r = row + 1, c = col + 1; r < arr.GetLength(0) && c < arr.GetLength(1) ; r++, c++)
                {

                    if (word.Length == 0)
                    {
                        word += arr[row, col];
                    }

                    if (arr[row, col] == arr[r, c])
                    {
                        series++;
                        word += ", " + arr[r, c];

                        if (series > maxSeries)
                        {
                            maxSeries = series;
                            maxWord = word;
                        }
                    }
                    else
                    {
                        word = "";
                        series = 1;
                        break;
                    }

                }
                // Same diagonal - End//

                word = "";
                series = 1;
            }
        }

        Console.WriteLine("Result: ");
        Console.WriteLine("Max Series: {0}", maxSeries);
        Console.WriteLine("Max Word: {0}", maxWord);
        Console.WriteLine();
    }
}

