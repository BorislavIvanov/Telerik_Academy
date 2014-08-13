//Declare a character variable and assign it with the symbol that has Unicode code 72.
//Hint: first use the Windows Calculator to find the hexadecimal representation of 72.

using System;

class UnicodeSymbol
{
    static void Main()
    {
        Console.Title = "UnicodeSymbol";

        char symbol = '\u0048';
        Console.WriteLine(symbol);

        // ... or ... Console.WriteLine((char)0x48);

    }
}

