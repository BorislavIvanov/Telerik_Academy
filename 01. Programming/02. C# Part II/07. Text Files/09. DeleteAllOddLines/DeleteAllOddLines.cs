//09. Write a program that deletes from given text file all odd lines. The result should be in the same file.

using System;
using System.IO;
using System.Collections.Generic;

class DeleteAllOddLines
{
    static void Main()
    {
        try
        {
            List<string> listOfEvenLines = new List<string>();

            StreamReader theTextFileReader = new StreamReader(@"..\..\TheTextFile.txt");
            using (theTextFileReader)
            {
                int lineNumber = 1;
                string lineOfTheTextFileReader = theTextFileReader.ReadLine();

                while (lineOfTheTextFileReader != null)
                {
                    if (lineNumber % 2 == 0)
                    {
                        listOfEvenLines.Add(lineOfTheTextFileReader);
                    }
                    lineNumber++;
                    lineOfTheTextFileReader = theTextFileReader.ReadLine();
                }
            }

            StreamWriter theTextFileWriter = new StreamWriter(@"..\..\TheTextFile.txt", false);
            using (theTextFileWriter)
            {
                foreach (string line in listOfEvenLines)
                {
                    theTextFileWriter.WriteLine(line);
                }
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

