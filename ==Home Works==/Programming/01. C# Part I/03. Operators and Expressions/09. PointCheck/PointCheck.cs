//Write an expression that checks for given point (x, y)
//if it is within the circle K( (1,1), 3) and out of the
//rectangle R(top=1, left=-1, width=6, height=2).

using System;

class PointCheck
{
    static void Main()
    {
        Console.Title = "Point Check";

        Console.Write("Type Value X: ");
        double valueX = double.Parse(Console.ReadLine());

        Console.Write("Type Value Y: ");
        double valueY = double.Parse(Console.ReadLine());

        double circleRadius = 3;
        double circleCenterX = 1;
        double circleCenterY = 1;

        bool withinTheCircle = (((valueX - circleCenterX) * (valueX - circleCenterX)) +
                                ((valueY - circleCenterY) * (valueY - circleCenterY)) <= (circleRadius * circleRadius));

        bool withinTheRectangle = (valueX >= -1 && valueX <= 5) && (valueY >= -1 && valueY <= 1);

        if (withinTheCircle && withinTheRectangle)
        {
            Console.WriteLine("The point is within Circle and Rectangle");
        }
        else if (withinTheCircle && !withinTheRectangle)
        {
            Console.WriteLine("The point is within Circle and out of Rectangle");
        }
        else if (!withinTheCircle && withinTheRectangle)
        {
            Console.WriteLine("The point is out of Circle and within Rectangle");
        }
        else
        {
            Console.WriteLine("The point is out of Circle and Rectangle");
        }

    }
}

