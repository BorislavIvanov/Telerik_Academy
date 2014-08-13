//* We are given an array of integers and a number S. Write a program to find if there exists a subset of the elements
//of the array that has a sum S. 
//Example: arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)

using System;
using System.Text;

class SubsetOfTheElements
{
    static void Main()
    {
        //int[] myArray = { 2, 1, 2, 4, 3, 5, 2, 6 };
        //int wantedSum = 14;

        Console.Write("Please enter a count of the numbers: ");
        string numberNEntr = Console.ReadLine();
        int numberN;
        while (!int.TryParse(numberNEntr, out numberN) || numberN < 1)
        {
            Console.Write("Type correct value: ");
            numberNEntr = Console.ReadLine();
        }

        Console.WriteLine();

        int[] myArray = new int[numberN];

        for (int i = 0; i < numberN; i++)
        {
            Console.Write("Enter number " + (i+1) + ": ");
            string myArrayEntr = Console.ReadLine();
            while (!int.TryParse(myArrayEntr, out myArray[i]))
            {
                Console.Write("Type correct value: ");
                myArrayEntr = Console.ReadLine();
            }
        }

        Console.WriteLine();

        Console.Write("Enter the wanted sum: ");
        string wantedSumEntr = Console.ReadLine();
        int wantedSum;
        while (!int.TryParse(wantedSumEntr, out wantedSum))
        {
            Console.Write("Type correct value: ");
            wantedSumEntr = Console.ReadLine();
        }

        Console.WriteLine();

        int count = (int)Math.Pow(2, myArray.Length);

        StringBuilder builder = new StringBuilder();
        int testSum = 0;
        bool isExist = false;
        for (int i = 1; i <= count; i++)
        {
            for (int j = 0; j < myArray.Length; j++)
            {
                if ((i >> j & 1) == 1)
                {
                    if (testSum == 0)
                    {
                        builder.Append(myArray[j]);
                    }
                    else
                    {
                        builder.Append("+").Append(myArray[j]);
                    }
                    testSum += myArray[j];
                }
            }
            if (testSum == wantedSum)
            {
                Console.WriteLine("Yes({0})", builder);
                isExist = true;
            }
            else
            {
                testSum = 0;
                builder.Clear();
            }
        }
        if (isExist == false)
        {
            Console.WriteLine("Sum not exist");
        }

        Console.WriteLine();
    }
}

