//08. Modify the solution of the previous problem to replace only whole words (not substrings).

using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class ReplaceOnlyWholeWords
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
                    string patern = @"\bstart\b";
                    string replace = "finish";
                    while (lineOfInputTextFile != null)
                    {
                        string replacing = Regex.Replace(lineOfInputTextFile, patern, replace);
                        outputTextFileReader.WriteLine(replacing);
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

