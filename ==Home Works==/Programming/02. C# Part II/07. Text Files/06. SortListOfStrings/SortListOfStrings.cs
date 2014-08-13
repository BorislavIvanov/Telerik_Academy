//06. Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
//
//    Example:
//    Ivan			  George
//	  Peter     =>    Ivan
//	  Maria			  Maria
//	  George		  Peter


using System;
using System.IO;
using System.Collections.Generic;

class SortListOfStrings
{
    static void Main()
    {
        try
        {
            StreamReader inputStringListReader = new StreamReader(@"..\..\InputStringList.txt");
            using (inputStringListReader)
            {
                string lineOfInputStringList = inputStringListReader.ReadLine();
                List<string> listOfString = new List<string>();

                while (lineOfInputStringList != null)
                {
                    listOfString.Add(lineOfInputStringList);
                    lineOfInputStringList = inputStringListReader.ReadLine();
                }

                listOfString.Sort();

                StreamWriter outputStringListWriter = new StreamWriter(@"..\..\OutputStringList.txt");
                using (outputStringListWriter)
                {
                    foreach (string line in listOfString)
                    {
                        outputStringListWriter.WriteLine(line);
                    }
                }
            }

            Console.WriteLine("Sorting InputStringList and printing in OutputStringList...\n");
            Console.WriteLine("Result (Print OutputStringList.txt):");
            Console.WriteLine();

            StreamReader outputStringListReader = new StreamReader(@"..\..\OutputStringList.txt", false);
            using (outputStringListReader)
            {
                string lineOfOutpurStringListReader = outputStringListReader.ReadLine();

                while (lineOfOutpurStringListReader != null)
                {
                    Console.WriteLine(lineOfOutpurStringListReader);
                    lineOfOutpurStringListReader = outputStringListReader.ReadLine();
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

