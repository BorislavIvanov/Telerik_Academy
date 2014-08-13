//07. Write a program that encodes and decodes a string using given encryption key (cipher).
//    The key consists of a sequence of characters. The encoding/decoding is done by performing
//    XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc.
//    When the last key character is reached, the next is the first.

using System;
using System.Text;

class EncodeAndDecodeAString
{
    static void Main()
    {
        Console.Write("Please enter a Word: ");
        string inputWord = Console.ReadLine();

        Console.Write("Please enter a Cipher: ");
        string inputCipher = Console.ReadLine();

        StringBuilder encodedString = new StringBuilder();
        StringBuilder decodedString = new StringBuilder();

        int chiferElement = 0;

        // Encoding
        for (int i = 0; i < inputWord.Length; i++)
        {
            encodedString.Append((char)(inputWord[i] ^ inputCipher[chiferElement]));
            chiferElement++;

            if (chiferElement == inputCipher.Length)
            {
                chiferElement = 0;
            }
        }

        Console.WriteLine();

        Console.WriteLine("Encoded rezult: {0}", encodedString.ToString());

        chiferElement = 0;

        // Decoding
        for (int i = 0; i < encodedString.Length; i++)
        {
            decodedString.Append((char)(encodedString[i] ^ inputCipher[chiferElement]));
            chiferElement++;

            if (chiferElement == inputCipher.Length)
            {
                chiferElement = 0;
            }
        }

        Console.WriteLine("Decoded rezult: {0}", decodedString.ToString());

        Console.WriteLine();
    }
}

