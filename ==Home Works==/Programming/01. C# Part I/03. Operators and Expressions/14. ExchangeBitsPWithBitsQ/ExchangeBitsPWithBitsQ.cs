using System;

class ExchangeBitsPWithBitsQ
{
    static void Main()
    {

        Console.Title = "Exchange Bits P With Bits Q";

        Console.Write("Enter number: ");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine(
  Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.Write("Please enter start position P: ");
        byte p = byte.Parse(Console.ReadLine());
        Console.Write("Please enter start position Q: ");
        byte q = byte.Parse(Console.ReadLine());
        Console.Write("Please enter length K: ");
        byte k = byte.Parse(Console.ReadLine());
        
        for (byte i = 0; i < k; i++)
        {
            bool bitA = findBitInt(number, (byte)(p + i));
            bool bitB = findBitInt(number, (byte)(q + i));
            insertBit(ref number, (byte)(p + i), bitB);
            insertBit(ref number, (byte)(q + i), bitA);
        }
        Console.WriteLine(
  Convert.ToString(number, 2).PadLeft(32, '0'));
    }
    static bool findBitInt(uint number, byte bitNumber)
    {

        uint mask = (uint)(1 << bitNumber);        
        uint nAndMask = (number & mask);  
        uint bit = nAndMask >> bitNumber;  
        return bit == 1;
       
    }
    static void insertBit(ref uint number, byte bitPosition, bool bitValue)
    {
        
        if (!bitValue)
        {
            uint mask = (uint)(~(1 << bitPosition));
            number = (number & mask);
        }

        

        else
        {
            uint mask = (uint)(1 << bitPosition);
            number = (number | mask);
        }

    }
}

