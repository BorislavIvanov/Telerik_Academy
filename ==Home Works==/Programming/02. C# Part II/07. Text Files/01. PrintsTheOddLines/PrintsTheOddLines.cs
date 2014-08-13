//01. Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;
using System.Collections;

class PrintsTheOddLines
{
    static void Main()
    {
        try
        {
            StreamReader textFileReader = new StreamReader(@"..\..\For Exercise 01.txt");

            Console.WriteLine("Result:\n");
            using (textFileReader)
            {
                int lineNumber = 1;
                string line = textFileReader.ReadLine();

                while (line != null)
                {
                    if (lineNumber % 2 != 0)
                    {
                        Console.WriteLine("Line{0}: {1}", lineNumber, line);
                    }

                    line = textFileReader.ReadLine();
                    lineNumber++;
                }
                Console.WriteLine();
            }
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

