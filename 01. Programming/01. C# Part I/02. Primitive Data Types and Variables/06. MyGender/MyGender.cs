//Declare a boolean variable called isFemale and assign an appropriate value corresponding to your gender.

using System;

class MyGender
{
    static void Main()
    {
        Console.Title = "MyGender";

        bool isFemale = false;

        switch (isFemale)
        {
            case true:
                Console.WriteLine("I am woman!");
                break;

            case false:
                Console.WriteLine("I am man!");
                break;
        }


    }
}

