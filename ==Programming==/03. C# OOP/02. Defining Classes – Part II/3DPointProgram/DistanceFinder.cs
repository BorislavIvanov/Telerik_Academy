using System;

namespace _3DPointProgram
{
    static class DistanceFinder // Task 3
    {
        static public double CalcDistance(Point3D pointOne, Point3D pointTwo) // Task 3
        {
            double distance;

            distance = 
                Math.Sqrt(Math.Pow(pointOne.X - pointTwo.X, 2) + Math.Pow(pointOne.Y - pointTwo.Y, 2) + Math.Pow(pointOne.Z - pointTwo.Z, 2));

            return distance;
        }
    }
}
