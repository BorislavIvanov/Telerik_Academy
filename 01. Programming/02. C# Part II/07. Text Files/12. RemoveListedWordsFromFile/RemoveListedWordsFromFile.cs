//12. Write a program that removes from a text file all words listed in given another text file.
//    Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class RemoveListedWordsFromFile
{
    static void Main()
    {
        List<string> remakedLines = new List<string>();

        try
        {
            StreamReader inputFileReader = new StreamReader(@"..\..\InputFile.txt");
            using (inputFileReader)
            {
                string lineOfInputFile = inputFileReader.ReadLine();
                while (lineOfInputFile != null)
                {
                    StreamReader WordsListReader = new StreamReader(@"..\..\WordsList.txt");
                    using (WordsListReader)
                    {
                        string wordFromWordsList = WordsListReader.ReadLine();

                        string line = lineOfInputFile;
                        string remakedLine = "";

                        while (wordFromWordsList != null)
                        {
                            string patern = @"\b" + wordFromWordsList + @"\b";
                            string replace = "";

                            remakedLine = Regex.Replace(line, patern, replace);
                            line = remakedLine;

                            wordFromWordsList = WordsListReader.ReadLine();
                        }

                        remakedLines.Add(remakedLine);

                        lineOfInputFile = "";

                        lineOfInputFile = inputFileReader.ReadLine();
                    }

                }

            }

            StreamWriter outputFileWriter = new StreamWriter(@"..\..\OutputFile.txt", false);
            using (outputFileWriter)
            {
                foreach (string line in remakedLines)
                {
                    outputFileWriter.WriteLine(line);
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
