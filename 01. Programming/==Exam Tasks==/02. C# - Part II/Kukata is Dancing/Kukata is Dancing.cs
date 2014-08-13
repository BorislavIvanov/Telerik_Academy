using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int linesCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < linesCount; i++)
        {
            string[,] dancing = { { "RED", "BLUE", "RED" }, { "BLUE", "GREEN", "BLUE" }, { "RED", "BLUE", "RED" } };

            string steps = Console.ReadLine();

            int positionRow = 1;
            int positionCol = 1;

            string headPosition = "Up";

            for (int s = 0; s < steps.Length; s++)
            {
                switch (steps[s])
                {
                    case 'L':
                        switch (headPosition)
                        {
                            case "Up": headPosition = "Left"; break;
                            case "Right": headPosition = "Up"; break;
                            case "Down": headPosition = "Right"; break;
                            case "Left": headPosition = "Down"; break;
                            default: break;
                        }
                        break;

                    case 'R':
                        switch (headPosition)
                        {
                            case "Up": headPosition = "Right"; break;
                            case "Right": headPosition = "Down"; break;
                            case "Down": headPosition = "Left"; break;
                            case "Left": headPosition = "Up"; break;
                            default: break;
                        }
                        break;

                    case 'W':
                        switch (headPosition)
                        {
                            case "Up": positionRow--; break;
                            case "Right": positionCol++; break;
                            case "Down": positionRow++; break;
                            case "Left": positionCol--; break;
                            default: break;
                        }
                        break;
                }

                if (positionRow < 0) { positionRow = 2; }
                else if (positionRow > 2) { positionRow = 0; }

                if (positionCol < 0) { positionCol = 2; }
                else if (positionCol > 2) { positionCol = 0; }
            }
            Console.WriteLine(dancing[positionRow, positionCol]);
        }
    }
}