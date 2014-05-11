using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[,] field = new string[8, 8];

        for (int row = 0; row < 8; row++)
        {
            int line = int.Parse(Console.ReadLine());
            string bitValue = Convert.ToString(line, 2);

            if (bitValue.Length < 8)
            {
                List<char> moreBits = new List<char>(bitValue);

                for (int k = 0; k < 8 - bitValue.Length; k++)
                {
                    moreBits.Insert(0, '0');
                }

                bitValue = string.Join("", moreBits.ToArray());
            }

            for (int col = 0; col < 8; col++)
            {
                field[row, col] = bitValue[col].ToString();
            }
        }

        // Output ONE!!!
        int startKnightCount = 0;

        for (int r = 0 r < 8; r++)
        {
            for (int c = 0; c < 8; c++)
            {
                if (field[r, c] == "1")
                {
                    startKnightCount++;
                }
            }
        }
        // End Output ONE!!!

        int rescuedKnightsKount = 0;
        while (true)
        {
            string command = Console.ReadLine();
            

            if (command == "select")
            {
                int row = int.Parse(Console.ReadLine());
                int col = int.Parse(Console.ReadLine());

                field[row, col] = field[row, col].Replace('1', '0');
            }
            else if (command == "kill")
            {
                int row = int.Parse(Console.ReadLine());
                int col = int.Parse(Console.ReadLine());

                if (col > 7 || col < 0)
                {
                    if (row == 0 || row == 1)
                    {
                        rescuedKnightsKount++;
                    }
                }
                else
                {
                    if (field[row, col] == "0")
                    {
                        field[row, col] = field[row, col].Replace('0', '1');
                    }

                    if (col < 7)
                    {
                        if (field[row, col + 1] == "1")
                        {
                            field[row, col] = field[row, col].Replace('1', '0');
                            field[row, col + 1] = field[row, col + 1].Replace('1', '0');
                        }
                    }

                    if (col > 0)
                    {
                        if (field[row, col - 1] == "1")
                        {
                            field[row, col] = field[row, col].Replace('1', '0');
                            field[row, col - 1] = field[row, col - 1].Replace('1', '0');
                        }
                    }

                    if (col < 7 && col > 0)
                    {
                        if (field[row, col + 1] == "1" && field[row, col - 1] == "1")
                        {
                            field[row, col] = field[row, col].Replace('1', '0');
                        }
                    }

                }
            }
            else if (command == "move")
            {
                int row = int.Parse(Console.ReadLine());
                int col = int.Parse(Console.ReadLine());

                if (col > 7 || col < 0)
                {
                    if (row == 0 || row == 1)
                    {
                        rescuedKnightsKount++;
                    }
                }
                else
                {
                    if (field[row, col] == "0")
                    {
                        field[row, col] = field[row, col].Replace('0', '1');
                    }

                    if (col < 7)
                    {
                        if (field[row, col + 1] == "1")
                        {
                            field[row, col] = field[row, col].Replace('1', '0');
                        }
                    }

                    if (col > 0)
                    {
                        if (field[row, col - 1] == "1")
                        {
                            field[row, col] = field[row, col].Replace('1', '0');
                        }
                    }

                    if (col < 7 && col > 0)
                    {
                        if (field[row, col + 1] == "1" && field[row, col - 1] == "1")
                        {
                            field[row, col] = field[row, col].Replace('1', '0');
                        }
                    }
                }
            }
            else if (command == "end")
            {
                break;
            }
        }

        // Output TWO!!!
        int endKnightsKount = 0;

        for (int r = 0; r < 8; r++)
        {
            for (int c = 0; c < 8; c++)
            {
                if (field[r, c] == "1")
                {
                    endKnightsKount++;
                }
            }
        }

        endKnightsKount += rescuedKnightsKount;
        // End Output TWO!!!

        Console.WriteLine(startKnightCount);
        Console.WriteLine(endKnightsKount);

        int number = 0;

        for (int i = 0; i < 8; i++)
        {
            string str = "";
            for (int l = 0; l < 8; l++)
            {
                str += field[i, l];
            }
            number += Convert.ToInt32(str, 2);
        }

        Console.WriteLine(number);

    }
}
