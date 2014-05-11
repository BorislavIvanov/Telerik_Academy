using System;

class CartesianCoordinateSystem
{
    static void Main()
    {

        double pointX = double.Parse(Console.ReadLine());

        double pointY = double.Parse(Console.ReadLine());

        if (pointX == 0 && pointY == 0)
        {
            Console.WriteLine(0);
        }
        else if (pointX == 0)
        {
            Console.WriteLine(5);
        }
        else if (pointY == 0)
        {
            Console.WriteLine(6);
        }
        else if (pointX > 0 && pointY > 0)
        {
            Console.WriteLine(1);
        }
        else if (pointX < 0 && pointY > 0)
        {
            Console.WriteLine(2);
        }
        else if (pointX < 0 && pointY < 0)
        {
            Console.WriteLine(3);
        }
        else // if (X > 0 && Y < 0)
        {
            Console.WriteLine(4);
        }

    }
}


        //if (pointX == 0 && pointY == 0)
        //{
        //    Console.WriteLine("0");
        //}
        //if (pointX > 0 && pointY > 0)
        //{
        //    Console.WriteLine("1");
        //}
        //if (pointX < 0 && pointY > 0)
        //{
        //    Console.WriteLine("2");
        //}
        //if (pointX < 0 && pointY < 0)
        //{
        //    Console.WriteLine("3");
        //}
        //if (pointX > 0 && pointY < 0)
        //{
        //    Console.WriteLine("4");
        //}
        //if (pointX == 0 && pointY > int.MinValue && pointY != 0)
        //{
        //    Console.WriteLine("5");
        //}
        //if (pointX > int.MinValue && pointY == 0 && pointX != 0)
        //{
        //    Console.WriteLine("6");
        //}
