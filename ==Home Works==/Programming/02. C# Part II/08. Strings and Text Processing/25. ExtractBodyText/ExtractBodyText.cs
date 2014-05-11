//25. Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

using System;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

class ExtractBodyText
{
    static void Main()
    {
        try
        {
            StreamReader inputFileReader = new StreamReader(@"..\..\InputFile.txt");
            using (inputFileReader)
            {
                string fileContent = inputFileReader.ReadToEnd();
                string content = Regex.Replace(fileContent, "<(.*?)>", " ");
                string[] splitTheContent = content.Split();
                Console.WriteLine("Result: ");
                Console.WriteLine(content);
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

