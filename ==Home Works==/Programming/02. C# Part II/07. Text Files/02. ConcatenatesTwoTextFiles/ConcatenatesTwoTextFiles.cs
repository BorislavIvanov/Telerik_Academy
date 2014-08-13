//02. Write a program that concatenates two text files into another text file.

using System;
using System.IO;

class ConcatenatesTwoTextFiles
{
    static void Main()
    {
        try
        {
            StreamReader textFileOneReader = new StreamReader(@"..\..\TextFileOne.txt");
            
            using (textFileOneReader)
            {
                StreamWriter textFileThreeWriter = new StreamWriter(@"..\..\TextFileThree.txt", false);
                using (textFileThreeWriter)
                {
                    string lineInDocumentOne = textFileOneReader.ReadLine();

                    while (lineInDocumentOne != null)
                    {
                        textFileThreeWriter.WriteLine(lineInDocumentOne);
                        lineInDocumentOne = textFileOneReader.ReadLine();
                    }
                }
            }

            
            StreamReader textFileTwoReader = new StreamReader(@"..\..\TextFileTwo.txt");

            using (textFileTwoReader)
            {
                StreamWriter textFileThreeWriter = new StreamWriter(@"..\..\TextFileThree.txt", true);
                using (textFileThreeWriter)
                {
                    string lineInDocumentTwo = textFileTwoReader.ReadLine();

                    while (lineInDocumentTwo != null)
                    {
                        textFileThreeWriter.WriteLine(lineInDocumentTwo);
                        lineInDocumentTwo = textFileTwoReader.ReadLine();
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Result (Print TextFileThree): ");
            Console.WriteLine();

            StreamReader textFileThreeReader = new StreamReader(@"..\..\TextFileThree.txt");

            using (textFileThreeReader)
            {
                string lineInDocumentThree = textFileThreeReader.ReadLine();

                while (lineInDocumentThree != null)
                {
                    Console.WriteLine(lineInDocumentThree);
                    lineInDocumentThree = textFileThreeReader.ReadLine();
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

