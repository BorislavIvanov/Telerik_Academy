//04. Write a program that compares two text files line by line and prints the number of lines that are the same
//    and the number of lines that are different. Assume the files have equal number of lines.

using System;
using System.IO;

class ComparesTwoTextFiles
{
    static void Main()
    {
        try
        {
            int numberOfTheSameLines = 0;
            int numberOfDifferentLines = 0;

            StreamReader textFileOneReader = new StreamReader(@"..\..\TextFileOne.txt");
            using (textFileOneReader)
            {
                StreamReader textFileTwoReader = new StreamReader(@"..\..\TextFileTwo.txt");
                using (textFileTwoReader)
                {
                    string lineOfTextFileOne = textFileOneReader.ReadLine();
                    string lineOfTextFileTwo = textFileTwoReader.ReadLine();

                    while (lineOfTextFileOne != null || lineOfTextFileTwo != null)
                    {
                        int compareing = String.Compare(lineOfTextFileOne, lineOfTextFileTwo);
                        if (compareing == 0)
                        {
                            numberOfTheSameLines++;
                        }
                        else
                        {
                            numberOfDifferentLines++;
                        }

                        lineOfTextFileOne = textFileOneReader.ReadLine();
                        lineOfTextFileTwo = textFileTwoReader.ReadLine();
                    }
                }
            }
            Console.WriteLine("Comparing TextFileOne and TextFileTwo...");
            Console.WriteLine();
            Console.WriteLine("Result: ");
            Console.WriteLine();
            Console.WriteLine("Number of lines that are the same: {0}", numberOfTheSameLines);
            Console.WriteLine("Number of lines that are different: {0}", numberOfDifferentLines);
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

