//Declare two string variables and assign them with “Hello” and “World”.
//Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval).
//Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

using System;

class DeclareVariables
{
    static void Main()
    {
        Console.Title = "DeclareVariables";

        string wordOne = "Hello";
        string wordTwo = "World";
        object wordsOnePlusTwo = (wordOne + " " + wordTwo + " !!!");
        string objVariable = ((string)wordsOnePlusTwo);
        Console.WriteLine("WordOne - {0}\nWordTwo - {1}\nOne+Two - {2}\nObjVariable - {3}", wordOne, wordTwo, wordsOnePlusTwo, objVariable);
    }
}

