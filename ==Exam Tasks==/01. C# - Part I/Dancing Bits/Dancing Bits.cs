using System;

class Program
{
    static void Main()
    {
        int K = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());

        string allBits = "";

        for (int i = 0; i < N; i++)
        {
            int number = int.Parse(Console.ReadLine());

            allBits += Convert.ToString(number, 2);
        }

        int lenghtOfSequence = 0;
        char previousBit = '2';
        int result = 0;
        for (int i = 0; i < allBits.Length; i++)
        {
            if (allBits[i] == previousBit)
            {
                lenghtOfSequence += 1;
            }
            else
            {
                if (lenghtOfSequence == K)
                {
                    result += 1;
                }
                lenghtOfSequence = 1;
            }
            previousBit = allBits[i];
        }
        if (lenghtOfSequence == K)
        {
            result += 1;
        }
        Console.WriteLine(result);
    }
}