// 04. Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. 
//Override ToString() to display the information of a person and if age is not specified – to say so. 
//Write a program to test this functionality.

using System;

class TestApp
{
    static void Main()
    {
        Person mike = new Person("Mike", 24);
        Person andrei = new Person("Andrei");

        Console.WriteLine(mike);
        Console.WriteLine(andrei);
    }
}