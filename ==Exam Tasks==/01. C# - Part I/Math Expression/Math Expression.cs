using System;

class MathExpression
{
    static void Main()
    {
        double numberN = double.Parse(Console.ReadLine());
        double numberM = double.Parse(Console.ReadLine());
        double numberP = double.Parse(Console.ReadLine());
        double numberOne = 1337d;
        double numberTwo = 128.523123123d;

        double calculation1 = (numberN * numberN) + (1 / (numberM * numberP)) + numberOne;
        double calculation2 = numberN - (numberTwo * numberP);
        double calculation3 = Math.Sin((int)numberM % 180);
        double result = (calculation1 / calculation2) + calculation3;

        Console.WriteLine("{0:0.000000}",result);
    }
}
