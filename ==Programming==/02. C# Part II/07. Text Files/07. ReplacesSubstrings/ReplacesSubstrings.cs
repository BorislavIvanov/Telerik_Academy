//07. Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file.
//    Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;
using System.Text;

class ReplacesSubstrings
{
    static void Main()
    {
        try
        {
            StreamReader inputTextFileReader = new StreamReader(@"..\..\InputTextFile.txt");
            using (inputTextFileReader)
            {
                StreamWriter outputTextFileReader = new StreamWriter(@"..\..\OutputTextFile.txt");
                using (outputTextFileReader)
                {
                    string lineOfInputTextFile = inputTextFileReader.ReadLine();
                    while (lineOfInputTextFile != null)
                    {
                        StringBuilder stringFromTheFile = new StringBuilder();
                        stringFromTheFile.Append(lineOfInputTextFile);
                        stringFromTheFile.Replace("start", "finish");
                        stringFromTheFile.ToString();
                        outputTextFileReader.WriteLine(stringFromTheFile);
                        lineOfInputTextFile = inputTextFileReader.ReadLine();
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

