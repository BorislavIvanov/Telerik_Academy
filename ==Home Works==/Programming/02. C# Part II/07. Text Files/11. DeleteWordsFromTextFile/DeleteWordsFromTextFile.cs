//11. Write a program that deletes from a text file all words that start with the prefix "test".
//    Words contain only the symbols 0...9, a...z, A…Z, _.

using System;
using System.IO;
using System.Text.RegularExpressions;

class DeleteWordsFromTextFile
{
    static void Main()
    {
        try
        {
            StreamReader inputFileReader = new StreamReader(@"..\..\InputFile.txt");
            using (inputFileReader)
            {
                StreamWriter outputFileReader = new StreamWriter(@"..\..\OutputFile.txt");
                using (outputFileReader)
                {
                    string lineOfInputFile = inputFileReader.ReadLine();
                    string patern = @"\btest";
                    string replace = "";
                    while (lineOfInputFile != null)
                    {
                        string replacing = Regex.Replace(lineOfInputFile, patern, replace);
                        outputFileReader.WriteLine(replacing);
                        lineOfInputFile = inputFileReader.ReadLine();
                    }
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

