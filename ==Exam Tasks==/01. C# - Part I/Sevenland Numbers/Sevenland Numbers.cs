using System;

class SevenlandNumbers
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        int output = int.MinValue;

        if (input < 10)
        {
            if (input % 10 != 6)
            {
                output = input + 1;
            }
            else
            {
                output = input + 4;
            }
        }
        else if (input < 100)
        {
            if (input % 100 == 66 )
            {
                output = input + 34;
            }
            else if (input % 10 == 6)
            {
                output = input + 4;
            }
            else
            {
                output = input + 1;
            }
        }
        else if (input < 1000)
        {
            if (input % 1000 == 666)
            {
                output = input + 334;
            }
            else if (input % 100 == 66)
            {
                output = input + 34;
            }
            else if (input % 10 == 6)
            {
                output = input + 4;
            }
            else
            {
                output = input + 1;
            }
        }

        Console.WriteLine(output);
    }
}
