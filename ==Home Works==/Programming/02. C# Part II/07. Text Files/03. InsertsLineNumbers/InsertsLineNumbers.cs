//03. Write a program that reads a text file and inserts line numbers in front of each of its lines. 
//    The result should be written to another text file.

using System;
using System.IO;

class InsertsLineNumbers
{
    static void Main()
    {
        try
        {
            StreamReader textFileOneReader = new StreamReader(@"..\..\TextFileOne.txt");

            using (textFileOneReader)
            {
                StreamWriter textFileTwoWriter = new StreamWriter(@"..\..\TextFileTwo.txt", false);

                using (textFileTwoWriter)
                {
                    int lineNumber = 1;
                    string lineOfTextFileOne = textFileOneReader.ReadLine();

                    while (lineOfTextFileOne != null)
                    {
                        textFileTwoWriter.WriteLine("Line {0}: {1}", lineNumber, lineOfTextFileOne);
                        lineOfTextFileOne = textFileOneReader.ReadLine();
                        lineNumber++;
                    }
                }

                Console.WriteLine("Information in TextFileOne was Remaked and Copyed in TextFileTwo!");
            }
            Console.WriteLine();
            Console.WriteLine("Result (Print TextFileTwo): ");
            Console.WriteLine();

            StreamReader textFileTwoReader = new StreamReader(@"..\..\TextFileTwo.txt");

            using (textFileTwoReader)
            {
                string lineOfTextFileTwo = textFileTwoReader.ReadLine();

                while (lineOfTextFileTwo != null)
                {
                    Console.WriteLine(lineOfTextFileTwo);
                    lineOfTextFileTwo = textFileTwoReader.ReadLine();
                }
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

