using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ExistingPathInLabyrinth
{
    class Program
    {
        private static Random randomGenerator = new Random();
        private static List<char> path = new List<char>();
        private static int countOfSolutions = 0;

        private static int rowsCount = 5;
        private static int columnsCount = 5;
        private static int blockadesCount = 8;
        private static int[] startPoint = { 0, 0 };
        private static int[] exitPoint = { 4, 4 };

        static void Main(string[] args)
        {
            char[,] matrix = new char[rowsCount, columnsCount];
            matrix[exitPoint[0], exitPoint[1]] = 'E';

            GeneratePathBlockades(matrix, startPoint, exitPoint, blockadesCount);

            Console.WriteLine("The labyrinth:");
            PrintTheMatrix(matrix);

            bool pathExists = false;

            FindPathToTheExit(0, 0, 'S', matrix, ref pathExists);

            if (countOfSolutions == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("No Exit from this labyrinth :(");
                Console.ResetColor();
            }
        }

        private static void GeneratePathBlockades(char[,] matrix, int[] startPoint, int[] exitPoint, int countOfBlockades)
        {
            for (int i = 0; i < countOfBlockades; i++)
            {
                int randomRow = default(int);
                int randomCol = default(int);

                do
                {
                    randomRow = randomGenerator.Next(0, matrix.GetLength(0));
                    randomCol = randomGenerator.Next(0, matrix.GetLength(1));
                } while ((randomRow == startPoint[0] && randomCol == startPoint[1]) ||
                    (randomRow == exitPoint[0] && randomCol == exitPoint[1]));

                matrix[randomRow, randomCol] = 'X';
            }
        }

        private static void PrintTheMatrix(char[,] matrix)
        {
            Console.WriteLine(new string('-', (matrix.GetLength(1) * 2) + 3));

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                Console.Write("|");

                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (r == startPoint[0] && c == startPoint[1])
                    {
                        Console.Write(" S");
                    }
                    else if (matrix[r, c] == 0)
                    {
                        Console.Write(" -");
                    }
                    else if (matrix[r, c] == 'X')
                    {
                        Console.Write(" X");
                    }
                    else if (matrix[r, c] == 'E')
                    {
                        Console.Write(" E");
                    }
                    else
                    {
                        Console.Write(" " + matrix[r, c]);
                    }
                }

                Console.WriteLine(" |");
            }

            Console.WriteLine(new string('-', (matrix.GetLength(1) * 2) + 3));
            Console.WriteLine();
        }

        private static void FindPathToTheExit(int row, int col, char direction, char[,] matrix, ref bool pathExists)
        {
            if (pathExists == true)
            {
                return;
            }

            if (!IsInRange(row, col, matrix))
            {
                return;
            }

            path.Add(direction);

            if (matrix[row, col] == 'E')
            {
                countOfSolutions++;
                pathExists = true;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Path exists! :D");
                Console.ResetColor();
            }

            if (matrix[row, col] == 0)
            {
                matrix[row, col] = direction;

                // Recursively explore all possible directions
                FindPathToTheExit(row, col - 1, 'L', matrix, ref pathExists); // left
                FindPathToTheExit(row - 1, col, 'U', matrix, ref pathExists); // up
                FindPathToTheExit(row, col + 1, 'R', matrix, ref pathExists); // right
                FindPathToTheExit(row + 1, col, 'D', matrix, ref pathExists); // down

                matrix[row, col] = '\0';
            }

            path.RemoveAt(path.Count - 1);
        }

        private static bool IsInRange(int row, int col, char[,] matrix)
        {
            bool rowIsInTheMatrix = row >= 0 && row < matrix.GetLength(0);
            bool colIsInTheMatrix = col >= 0 && col < matrix.GetLength(1);

            if (rowIsInTheMatrix && colIsInTheMatrix)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void PrintThePath(List<char> path)
        {
            Console.WriteLine(String.Join(">", path));
        }
    }
}