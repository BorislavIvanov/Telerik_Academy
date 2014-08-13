//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class ExchangeBits
{
    static void Main()
    {
        Console.Title = "Exchange Bits";

        Console.Write("Enter Unsigned Integer number( from 0 to 256): ");
        uint number = uint.Parse(Console.ReadLine());

        uint firstMask = 56;        //56 = 0000 0000 0000 0000 0000 0000 0011 1000
        uint secondMask = 117440512;  //117440512 = 0000 0111 0000 0000 0000 0000 0000 0000

        Console.WriteLine(new string ('-', 10));

        Console.WriteLine("The number in binary is: " + Convert.ToString(number, 2));

        Console.WriteLine(new string('-', 10));

        uint firstBits = number & firstMask;
        uint secondBits = number & secondMask;

        firstBits = firstBits << 21;
        secondBits = secondBits >> 21;

        number = number & (~firstMask);
        number = number & (~secondMask);

        number = number | firstBits;
        number = number | secondBits;

        Console.WriteLine("Result: " + number);
    }
}

