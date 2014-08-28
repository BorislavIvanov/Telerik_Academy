﻿using System;
using System.IO;

class Program
{
    public static void DisplayExeFiles(string sourceDirectory)
    {
        var exeFiles = Directory.EnumerateFiles(sourceDirectory, "*.exe");
        foreach (var file in exeFiles)
        {
            Console.WriteLine(file);
        }

        var directories = Directory.EnumerateDirectories(sourceDirectory);
        foreach (var directory in directories)
        {
            try
            {
                DisplayExeFiles(directory);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    static void Main()
    {
        string sourceDirectory = @"C:\Windows";

        try
        {
            DisplayExeFiles(sourceDirectory);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}