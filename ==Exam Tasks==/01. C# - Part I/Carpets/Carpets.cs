using System;

class Carpets
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        Console.Write(new string('.', (size / 2) - 1));
        Console.Write("/");
        Console.Write("\\");
        Console.WriteLine(new string('.', (size / 2) - 1));

        int sideDots = (size / 2 - 2);
        string lastSymbol = null;
        for (int i = 2; i <= (size / 2); i++)
        {
            Console.Write(new string('.', sideDots));

            for (int f = 0; f < (size / 2) - sideDots; f++)
            {
                if (f % 2 == 0)
                {
                    Console.Write("/");
                    lastSymbol = "/";
                }
                else
                {
                    Console.Write(" ");
                    lastSymbol = " ";
                }
            }

            for (int s = 0; s < (size / 2) - sideDots; s++)
            {
                if (lastSymbol == "/")
                {
                    if (s % 2 == 0)
                    {
                        Console.Write("\\");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                else
                {
                    if (s % 2 == 0)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("\\");
                    }
                }
            }

            Console.WriteLine(new string('.', sideDots));

            sideDots--;
        }

        sideDots++;

        for (int i = 2; i <= (size / 2); i++)
        {
            Console.Write(new string('.', sideDots));

            for (int f = 0; f < (size / 2) - sideDots; f++)
            {
                if (f % 2 == 0)
                {
                    Console.Write("\\");
                    lastSymbol = "\\";
                }
                else
                {
                    Console.Write(" ");
                    lastSymbol = " ";
                }
            }

            for (int s = 0; s < (size / 2) - sideDots; s++)
            {
                if (lastSymbol == "\\")
                {
                    if (s % 2 == 0)
                    {
                        Console.Write("/");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                else
                {
                    if (s % 2 == 0)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("/");
                    }
                }
            }

            Console.WriteLine(new string('.', sideDots));

            sideDots++;
        }

        Console.Write(new string('.', (size / 2) - 1));
        Console.Write("\\");
        Console.Write("/");
        Console.Write(new string('.', (size / 2) - 1));
    }
}