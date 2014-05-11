using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        FirstTask();
        SecondTask();
        ThirdTask();
    }

    private static void FirstTask()
    {
        string[] points = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

        int winner = default(int);
        int winnerPoints = default(int);

        for (int i = 0; i < points.Length; i++)
        {
            int playerPoints = int.Parse(points[i]);

            if (playerPoints <= 21)
            {
                if (playerPoints > winnerPoints)
                {
                    winner = i;
                    winnerPoints = playerPoints;
                }
                else if (playerPoints == winnerPoints)
                {
                    winner = -1;
                }
            }
        }

        Console.WriteLine(winner);
    }

    private static void SecondTask()
    {
        string[] inputCakes = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        int friendsCount = int.Parse(Console.ReadLine());

        int[] cakes = new int[inputCakes.Length];

        for (int c = 0; c < inputCakes.Length; c++)
        {
            cakes[c] = int.Parse(inputCakes[c]);
        }

        Array.Sort(cakes);
        Array.Reverse(cakes);

        int cakeBites = default(int);

        for (int i = 0; i < cakes.Length; i += (friendsCount + 1))
        {
            cakeBites += cakes[i];
        }

        Console.WriteLine(cakeBites);
    }

    private static void ThirdTask()
    {
        string[] inputValues = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int G1 = int.Parse(inputValues[0]);
        int S1 = int.Parse(inputValues[1]);
        int B1 = int.Parse(inputValues[2]);
        int G2 = int.Parse(inputValues[3]);
        int S2 = int.Parse(inputValues[4]);
        int B2 = int.Parse(inputValues[5]);

        int operations = 0;

        while (true)
        {
            int operationsInCycle = operations;

            if (S1 - S2 >= 11 && G1 - G2 < 0)
            {
                S1 -= 11;
                G1 += 1;

                operations++;
            }
            else if (S1 - S2 >= 1 && B1 - B2 < 0)
            {
                S1 -= 1;
                B1 += 9;

                operations++;
            }
            else if (G1 - G2 >= 1 && (S1 - S2 < 0 || B1 - B2 < 0))
            {
                G1 -= 1;
                S1 += 9;

                operations++;
            }
            else if (B1 - B2 >= 11 && (S1 - S2 < 0 || G1 - G2 < 0))
            {
                B1 -= 11;
                S1 += 1;

                operations++;
            }

            if (operationsInCycle == operations) { break; }
        }

        if (G1 >= G2 && S1 >= S2 && B1 >= B2)
        {
            Console.WriteLine(operations);
        }
        else
        {
            Console.WriteLine("-1");
        }
    }
}