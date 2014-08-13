/*
 * Exercises:
 * 1) Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. Implement the ToString()
 * to enable printing a 3D point.
 * 2) Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
 * Add a static property to return the point O.
 * 3) Write a static class with a static method to calculate the distance between two points in the 3D space.
 * 4) Create a class Path to hold a sequence of points in the 3D space. Create a static class PathStorage with static methods
 * to save and load paths from a text file. Use a file format of your choice.
 * 5) Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. Keep the elements of the list
 * in an array with fixed capacity which is given as parameter in the class constructor. Implement methods for +adding element,
 * accessing element by index, removing element by index, inserting element at given position, clearing the list, finding element
 * by its value and ToString(). Check all input parameters to avoid accessing elements at invalid positions.
 * 6) Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.
 * 7) Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  GenericList<T>.
 * You may need to add a generic constraints for the type T.
 * 8) Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 
 * 9) Implement an indexer this[row, col] to access the inner matrix cells.
 * 10) Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication.
 * Throw an exception when the operation cannot be performed. Implement the true operator (check for non-zero elements).
 * 11) Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods
 * and holds a version in the format major.minor (e.g. 2.11). Apply the version attribute to a sample class and display its version at runtime.
 */

using System;

namespace _3DPointProgram
{
    class Tests
    {
        static void Main(string[] args) // JUST PRESS F5!!! :)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("TEST 1 \"Point3D\":");
            Console.ResetColor();
            Console.WriteLine();

            Point3D A = new Point3D(2, 8, 6);
            Point3D B = new Point3D(5, 3, 5);

            Console.WriteLine("Printing Points A and B:");
            Console.WriteLine(A);
            Console.WriteLine(B);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("END TEST 1 \"Point3D\"");
            Console.WriteLine();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("TEST 2 \"DistanceFinder\":");
            Console.ResetColor();
            Console.WriteLine();

            Console.Write("Distance: ");
            Console.WriteLine(DistanceFinder.CalcDistance(A, B));

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("END TEST 2 \"DistanceFinder\"");
            Console.WriteLine();
            Console.ResetColor();

            Path newLine = new Path();
            newLine.AddPoint(A);
            newLine.AddPoint(B);
            newLine.AddPoint(new Point3D(9, 6, 5));
            
            Point3D C = newLine.PathPoints[2];

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("TEST 3 \"Load Points from file\":");
            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine("Loaded points from file \"LoadFile.txt\":");
            Path loadedPath = PathStorage.LoadPath();
            foreach (Point3D point in loadedPath.PathPoints)
            {
                Console.WriteLine(point);
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("END TEST 3 \"Load Points from file\"");
            Console.WriteLine();
            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("TEST 4 \"Save Points to file\":");
            Console.ResetColor();
            Console.WriteLine();

            PathStorage.SavePath(newLine);
            Console.WriteLine("Points A, B and C are saved in SaveFile.txt");
            
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("END TEST 4 \"Save Points to file\"");
            Console.WriteLine();
            Console.ResetColor();

            GenericList<string> theList = new GenericList<string>();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("TEST 5 \"GenericList\":");
            Console.ResetColor();
            Console.WriteLine();

            theList.AddElement("1");
            theList.AddElement("3");
            Console.Write("Printed elements from \"TheList\": ");
            Console.WriteLine(theList);
            Console.WriteLine();
            Console.WriteLine("Adding \"2\" in position 1!");
            theList.InsertElement(1, "2");
            Console.Write("Printed elements from \"TheList\": ");
            Console.WriteLine(theList);
            Console.WriteLine();
            Console.WriteLine("Removing element with index 1!");
            theList.RemoveElementAtIndex(1);
            Console.Write("Printed elements from \"TheList\": ");
            Console.WriteLine(theList);
            Console.WriteLine();
            Console.WriteLine("Clearing \"TheList\"!");
            theList.Clear();
            Console.Write("Printed elements from \"TheList\": ");
            Console.WriteLine(theList);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("END TEST 5 \"GenericList\"");
            Console.WriteLine();
            Console.ResetColor();

            Console.Write("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
