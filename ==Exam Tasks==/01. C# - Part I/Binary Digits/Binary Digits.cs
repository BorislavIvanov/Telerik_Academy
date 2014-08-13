using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int inputNum = int.Parse(Console.ReadLine());

        string bitValue = Convert.ToString(inputNum, 2);

        if (bitValue.Length < 16)
        {
            List<char> moreBits = new List<char>(bitValue);

            for (int i = 0; i < 16 - bitValue.Length; i++)
            {
                moreBits.Insert(0, '0');
            }

            bitValue = string.Join("", moreBits.ToArray());
        }
        else if (bitValue.Length > 16)
        {
            List<char> cutTheBits = new List<char>(bitValue);

            cutTheBits.RemoveRange(0, cutTheBits.Count - 16);

            bitValue = string.Join("", cutTheBits.ToArray());
        }

        string[,] output = new string[4, 63];

        int printPositionRow = 0;
        int printPositionCol = 0;
        
        for (int i = 0; i < bitValue.Length; i++)
        {
            if (bitValue[i] == '1')
            {
                output[printPositionRow, printPositionCol] = ".";
                output[printPositionRow, printPositionCol + 1] = "#";
                output[printPositionRow, printPositionCol + 2] = ".";
                output[printPositionRow + 1, printPositionCol] = "#";
                output[printPositionRow + 1, printPositionCol + 1] = "#";
                output[printPositionRow + 1, printPositionCol + 2] = ".";
                output[printPositionRow + 2, printPositionCol] = ".";
                output[printPositionRow + 2, printPositionCol + 1] = "#";
                output[printPositionRow + 2, printPositionCol + 2] = ".";
                output[printPositionRow + 3, printPositionCol] = "#";
                output[printPositionRow + 3, printPositionCol + 1] = "#";
                output[printPositionRow + 3, printPositionCol + 2] = "#";

                if (i != bitValue.Length - 1)
                {
                    output[printPositionRow, printPositionCol + 3] = ".";
                    output[printPositionRow + 1, printPositionCol + 3] = ".";
                    output[printPositionRow + 2, printPositionCol + 3] = ".";
                    output[printPositionRow + 3, printPositionCol + 3] = ".";

                    printPositionCol += 4;

                    continue;
                }
            }
            else if (bitValue[i] == '0')
            {
                output[printPositionRow, printPositionCol] = "#";
                output[printPositionRow, printPositionCol + 1] = "#";
                output[printPositionRow, printPositionCol + 2] = "#";
                output[printPositionRow + 1, printPositionCol] = "#";
                output[printPositionRow + 1, printPositionCol + 1] = ".";
                output[printPositionRow + 1, printPositionCol + 2] = "#";
                output[printPositionRow + 2, printPositionCol] = "#";
                output[printPositionRow + 2, printPositionCol + 1] = ".";
                output[printPositionRow + 2, printPositionCol + 2] = "#";
                output[printPositionRow + 3, printPositionCol] = "#";
                output[printPositionRow + 3, printPositionCol + 1] = "#";
                output[printPositionRow + 3, printPositionCol + 2] = "#";

                if (i != bitValue.Length - 1)
                {
                    output[printPositionRow, printPositionCol + 3] = ".";
                    output[printPositionRow + 1, printPositionCol + 3] = ".";
                    output[printPositionRow + 2, printPositionCol + 3] = ".";
                    output[printPositionRow + 3, printPositionCol + 3] = ".";

                    printPositionCol += 4;

                    continue;
                }
            }
        }

        for (int r = 0; r < 4; r++)
        {
            for (int c = 0; c < 63; c++)
            {
                Console.Write(output[r,c]);
            }
            Console.WriteLine();
        }
    }
}