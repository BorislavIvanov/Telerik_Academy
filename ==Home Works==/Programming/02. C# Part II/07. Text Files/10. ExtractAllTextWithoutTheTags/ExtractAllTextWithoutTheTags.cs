//10. Write a program that extracts from given XML file all the text without the tags.
//
//    Example:
//    <?xml version="1.0"><student><name>Pesho</name>
//    <age>21</age><interests count="3"><interest> 
//    Games</instrest><interest>C#</instrest><interest> 
//    Java</instrest></interests></student>

using System;
using System.IO;
using System.Text.RegularExpressions;

class ExtractAllTextWithoutTheTags
{
    static void Main()
    {
        try
        {
            StreamReader inputFileReader = new StreamReader(@"..\..\InputFile.txt");
            using (inputFileReader)
            {
                StreamWriter outputFileWriter = new StreamWriter(@"..\..\OutputFile.txt", false);
                using (outputFileWriter)
                {
                    string fileContent = inputFileReader.ReadToEnd();
                    string content = Regex.Replace(fileContent, "<(.*?)>", " ");
                    string[] splitTheContent = content.Split();
                    outputFileWriter.WriteLine(content);
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

