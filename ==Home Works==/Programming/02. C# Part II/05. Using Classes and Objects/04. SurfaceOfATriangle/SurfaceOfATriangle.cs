// 04. Write methods that calculate the surface of a triangle by given:
// -Side and an altitude to it;
// -Three sides; 
// -Two sides and an angle between them.
// Use System.Math.

using System;

class SurfaceOfATriangle
{
    static double SideAndAltitude(double side, double altitude)
    {
        double calculation = ((side * altitude) / 2);

        return calculation;
    }

    static double ThreeSides(double firstSide, double secondSide, double thirdSide)
    {
        double semiPerimeter = (firstSide + secondSide + thirdSide) / 2;
        double calculation = Math.Sqrt(semiPerimeter * (semiPerimeter - firstSide)
                                                     * (semiPerimeter - secondSide)
                                                     * (semiPerimeter - thirdSide));
        return calculation;
    }

    static double TwoSidesAndAnAngle(double firstSide, double secondSide, double angle)
    {
        double calculation = (firstSide * secondSide * Math.Sin(Math.PI * angle / 180)) / 2;
        return calculation;
    }

    static void Main()
    {
        Console.WriteLine("For Surface of a Triangle by Side and an altitude to it - Enter \"1\"");
        Console.WriteLine("For Surface of a Triangle by Three sides - Enter \"2\"");
        Console.WriteLine("For Surface of a Triangle by Two sides and an angle between them - Enter \"3\"");
        Console.WriteLine(new string('=', 76));

        Console.Write("Please choose method: ");
        byte theMethod = byte.Parse(Console.ReadLine());
        Console.WriteLine();

        if (theMethod == 1)
        {
            Console.Write("Please enter The One: ");
            double theSide = double.Parse(Console.ReadLine());
            Console.Write("Please enter The Altitude: ");
            double altitude = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Result: " + SideAndAltitude(theSide, altitude));
            Console.WriteLine();
        }

        else if (theMethod == 2)
        {
            Console.Write("Please enter Side One: ");
            double sideOne = double.Parse(Console.ReadLine());
            Console.Write("Please enter Side Two: ");
            double sideTwo = double.Parse(Console.ReadLine());
            Console.Write("Please enter Side Three: ");
            double sideThree = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Result: " + ThreeSides(sideOne, sideTwo, sideThree));
            Console.WriteLine();
        }


        else if (theMethod == 3)
        {
            Console.Write("Please enter Side One: ");
            double sideOne = double.Parse(Console.ReadLine());
            Console.Write("Please enter Side Two: ");
            double sideTwo = double.Parse(Console.ReadLine());
            Console.Write("Please enter the Angle between Them: ");
            double angle = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Result: " + TwoSidesAndAnAngle(sideOne, sideTwo, angle));
            Console.WriteLine();
        }

        else
        {
            Console.WriteLine("Incorect Value!!!");
            Console.WriteLine();
        }
    }
}


