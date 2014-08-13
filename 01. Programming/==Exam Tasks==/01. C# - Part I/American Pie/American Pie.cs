using System;

class Program
{
    static void Main(string[] args)
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal c = decimal.Parse(Console.ReadLine());
        decimal d = decimal.Parse(Console.ReadLine());

        decimal calcOne = a / b;
        decimal calcTwo = c / d;

        decimal calcOnePlusTwo = calcOne + calcTwo;

        if (calcOnePlusTwo < 1)
        {
            Console.WriteLine("{0:F20}", calcOnePlusTwo);
        }
        else
        {
            Console.WriteLine("{0}", (int)calcOnePlusTwo);
        }

        decimal calcThree = b * c;
        decimal calcFour = d * a;
        decimal calcThreePlusFour = calcThree + calcFour;

        decimal calcFive = b * d;

        Console.WriteLine("{0}/{1}", calcThreePlusFour, calcFive);
    }
}