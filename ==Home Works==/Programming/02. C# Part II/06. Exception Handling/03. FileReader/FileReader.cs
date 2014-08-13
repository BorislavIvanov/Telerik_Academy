// 03. Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini),
//     reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…).
//     Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;

class FileReader
{
    static void Main()
    {
        Console.Write("Enter the Full File Path: ");
        string filePath = Console.ReadLine();

        Console.WriteLine("\n");

        try
        {
            Console.WriteLine(File.ReadAllText(filePath));
            Console.WriteLine();
        }
        // I can't find FileFormatException and i don't know why?!?!?!
        catch (DriveNotFoundException)
        {
            Console.WriteLine("Drive Not Found!!!\n");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory NOT Found!!!\n");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File NOT Found!!!\n");
        }
        catch (InvalidDataException)
        {
            Console.WriteLine("Invalid Data!!!\n");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Path is Too Long!!!\n");
        }
        catch (FileLoadException)
        {
            Console.WriteLine("File Load Error!!!\n");
        }
        catch (IOException)
        {
            Console.WriteLine("Problem whit The File Reading");
        }
    }
}

