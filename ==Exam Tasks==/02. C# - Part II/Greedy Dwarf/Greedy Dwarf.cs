using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class GreedyDwarf
{
    static long bestSum = long.MinValue;

    static void Main()
    {
        string[] valey = Regex.Split(Console.ReadLine(), ", ");

        int numberOfPatterns = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPatterns; i++)
        {
            string[] steps = Regex.Split(Console.ReadLine(), ", ");

            bool[] markedPlace = new bool[valey.Length];

            int currentPosition = 0;
            int currentStep = 0;
            long sum = 0;

            while (markedPlace[currentPosition] == false && currentPosition >= 0 && currentPosition < valey.Length - 1)
            {
                sum += int.Parse(valey[currentPosition]);
                markedPlace[currentPosition] = true;
                currentPosition += int.Parse(steps[currentStep]);
                if (currentPosition < 0)
                {
                    break;
                }
                else if (currentPosition > valey.Length - 1)
                {
                    break;
                }
                currentStep++;
                if (currentStep >= steps.Length)
                {
                    currentStep = 0;
                }
            }

            if (sum > bestSum)
            {
                bestSum = sum;
            }
        }

        Console.WriteLine(bestSum);
    }
}