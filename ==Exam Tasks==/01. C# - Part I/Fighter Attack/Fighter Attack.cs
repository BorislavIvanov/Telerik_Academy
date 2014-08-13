using System;

class Program
{
    static void Main()
    {
        int Px1 = int.Parse(Console.ReadLine());
        int Py1 = int.Parse(Console.ReadLine());
        int Px2 = int.Parse(Console.ReadLine());
        int Py2 = int.Parse(Console.ReadLine());
        int Fx = int.Parse(Console.ReadLine());
        int Fy = int.Parse(Console.ReadLine());
        int D = int.Parse(Console.ReadLine());

        int racketCentralX = Fx + D;
        int racketCentralY = Fy;

        int racketFrontX = Fx + D + 1;
        int racketFrontY = Fy;

        int racketLeftX = Fx + D;
        int racketLeftY = Fy + 1;

        int racketRightX = Fx + D;
        int racketRightY = Fy - 1;

        int upSide = 0;
        int downSide = 0;
        int leftSide = 0;
        int rightSide = 0;

        int damage = 0;

        if (Px1 > Px2)
        {
            leftSide = Px2;
            rightSide = Px1;
        }
        else
        {
            leftSide = Px1;
            rightSide = Px2;
        }

        if (Py1 > Py2)
        {
            downSide = Py2;
            upSide = Py1;
        }
        else
        {
            downSide = Py1;
            upSide = Py2;
        }

        // 100% DMG
        if (racketCentralX >= leftSide && racketCentralX <= rightSide && racketCentralY >= downSide && racketCentralY <= upSide)
        {
            damage += 100;
        }
        // 75% DMG
        if (racketFrontX >= leftSide && racketFrontX <= rightSide && racketFrontY >= downSide && racketFrontY <= upSide)
        {
            damage += 75;
        }
        // 50% DMG
        if (racketLeftX >= leftSide && racketLeftX <= rightSide && racketLeftY >= downSide && racketLeftY <= upSide)
        {
            damage += 50;
        }
        // 50% DMG
        if (racketRightX >= leftSide && racketRightX <= rightSide && racketRightY >= downSide && racketRightY <= upSide)
        {
            damage += 50;
        }

        Console.Write("{0}%", damage);
    }
}