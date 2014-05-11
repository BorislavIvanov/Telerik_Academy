using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Console.Write(new string ('.', n + 1));
        Console.Write(new string ('*', n - 1));
        Console.WriteLine(new string ('.', n + 1));

        int outSideDots = n - 1;
        int inSideDots = n + 1;

        int oneDotLinesCount = 0;

        for (int i = 2; i <= n; i++)
        {
            if (i == n)
            {
                Console.Write(".");
                Console.Write("*");

                for (int j = 1; j <= ((3 * n) + 1) - 4; j++)
                {
                    if (j % 2 != 0)
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }

                Console.Write("*");
                Console.WriteLine(".");
            }
            else if (outSideDots != 1)
            {
                Console.Write(new string('.', outSideDots));
                Console.Write("*");
                Console.Write(new string('.', inSideDots));
                Console.Write("*");
                Console.WriteLine(new string('.', outSideDots));

                outSideDots -= 2;
                inSideDots += 4;
            }
            else if (outSideDots == 1)
            {
                Console.Write(new string('.', outSideDots));
                Console.Write("*");
                Console.Write(new string('.', inSideDots));
                Console.Write("*");
                Console.WriteLine(new string('.', outSideDots));

                oneDotLinesCount++;
            }
        }

        for (int i = 1; i <= n - 1; i++)
        {
            if (i == 1)
            {
                Console.Write(".");
                Console.Write("*");

                for (int j = 1; j <= ((3 * n) + 1) - 4; j++)
                {
                    if (j % 2 != 0)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }

                Console.Write("*");
                Console.WriteLine(".");
            }
            else if (oneDotLinesCount > 0)
            {
                Console.Write(new string('.', outSideDots));
                Console.Write("*");
                Console.Write(new string('.', inSideDots));
                Console.Write("*");
                Console.WriteLine(new string('.', outSideDots));

                oneDotLinesCount--;

                if (oneDotLinesCount == 0)
                {
                    outSideDots += 2;
                    inSideDots -= 4;
                }
            }
            else if (oneDotLinesCount == 0)
            {
                Console.Write(new string('.', outSideDots));
                Console.Write("*");
                Console.Write(new string('.', inSideDots));
                Console.Write("*");
                Console.WriteLine(new string('.', outSideDots));

                outSideDots += 2;
                inSideDots -= 4;
            }
        }

        Console.Write(new string('.', n + 1));
        Console.Write(new string('*', n - 1));
        Console.Write(new string('.', n + 1));

        Console.ReadLine();
    }
}