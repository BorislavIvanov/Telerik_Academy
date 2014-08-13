//string value = Convert.ToString(number, 2);
//int binary = int.Parse(value);

using System;
using System.Numerics;

class BinaryDigitsCount
{
    static void Main()
    {
        int digitB = int.Parse(Console.ReadLine());
        long numberN = long.Parse(Console.ReadLine());

        for (int i = 0; i < numberN; i++)
        {
            if (digitB == 1)
            {
                long number = long.Parse(Console.ReadLine());

                //From Decimal to Binary
                string value = Convert.ToString(number, 2);
                BigInteger binary = BigInteger.Parse(value);

                BigInteger calculation = 0;
                BigInteger sum = 0;

                for (BigInteger j = 0; binary > 0; j++)
                {
                    calculation = binary % 10;
                    binary = binary / 10;

                    if (calculation == 1)
                    {
                        sum += 1;
                    }
                }

                Console.WriteLine(sum);
            }

            if (digitB == 0)
            {
                long number = long.Parse(Console.ReadLine());

                string value = Convert.ToString(number, 2);
                BigInteger binary = BigInteger.Parse(value);

                BigInteger calculation = 0;
                BigInteger sum = 0;

                for (BigInteger j = 0; binary > 0; j++)
                {
                    calculation = binary % 10;
                    binary = binary / 10;

                    if (calculation == 0)
                    {
                        sum += 1;
                    }
                }

                Console.WriteLine(sum);
            }
        }
    }
}

