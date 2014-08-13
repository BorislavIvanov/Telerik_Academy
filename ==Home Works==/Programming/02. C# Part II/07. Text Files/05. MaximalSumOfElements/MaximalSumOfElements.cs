//05. Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2 x 2
//    with a maximal sum of its elements. The first line in the input file contains the size of matrix N.
//    Each of the next N lines contain N numbers separated by space. The output should be a single number in a separate text file.
//     
//    Example:
//    4
//    2 3 3 4
//    0 2 3 4	 ===> 17
//    3 7 1 2
//    4 3 3 2


using System;
using System.IO;

    class MaximalSumOfElements
    {
        static void Main()
        {
            try
            {
                StreamReader inputTextFileReader = new StreamReader(@"..\..\InputTextFile.txt");
                using (inputTextFileReader)
                {
                    string lineOfInputTextFileReader = inputTextFileReader.ReadLine();
                    int theSize = int.Parse(lineOfInputTextFileReader);
                    int[,] matrix = new int[theSize, theSize];
                    int matrixline = 0;

                    while (matrixline + 1 <= theSize)
                    {
                        lineOfInputTextFileReader = inputTextFileReader.ReadLine();
                        string[] splitLine = lineOfInputTextFileReader.Split();

                        for (int i = 0; i < theSize; i++)
                        {
                            matrix[matrixline, i] = int.Parse(splitLine[i]);
                        }

                        matrixline++;
                    }

                    int result = int.MinValue;
                    int maxResult = int.MinValue;

                    for (int row = 0; row < theSize - 1; row++)
                    {
                        for (int col = 0; col < theSize - 1; col++)
                        {
                            int calculation = matrix[row, col] + matrix[row, col + 1]
                                            + matrix[row + 1, col] + matrix[row + 1, col + 1];

                            if (calculation > result)
                            {
                                result = calculation;

                                if (result > maxResult)
                                {
                                    maxResult = result;
                                }
                            }
                        }
                    }

                    StreamWriter outputTextFileWriter = new StreamWriter(@"..\..\OutputTextFile.txt");

                    using (outputTextFileWriter)
                    {
                        outputTextFileWriter.WriteLine(maxResult);
                    }
                }

                Console.WriteLine("Finding Maximal sum of Elements...\n");
                Console.Write("Result (Printing OutputTextFile): ");

                StreamReader outputTextFileReader = new StreamReader(@"..\..\OutputTextFile.txt");
                using (outputTextFileReader)
                {
                    string lineOfOutputTextFileReader = outputTextFileReader.ReadLine();
                    Console.WriteLine(lineOfOutputTextFileReader);
                }
                Console.WriteLine();
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("File Not Found!!!");
            }
            catch (DirectoryNotFoundException)
            {
                Console.Error.WriteLine("Directory Not Found!!!");
            }
            catch (DriveNotFoundException)
            {
                Console.Error.WriteLine("Drive Not Found!!!");
            }
            catch (IOException)
            {
                Console.Error.WriteLine("Input/Output Operation Error!!!");
            }
            catch (UnauthorizedAccessException)
            {
                Console.Error.WriteLine("UnauthorizedAccess");
            }
            catch (OutOfMemoryException)
            {
                Console.Error.WriteLine("Out Of Memory!!!");
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Fatal Error!!!");
            }
        }
    }

