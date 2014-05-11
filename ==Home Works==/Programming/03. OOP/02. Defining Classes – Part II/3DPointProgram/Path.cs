using System;
using System.Collections.Generic;

namespace _3DPointProgram
{
    class Path // Task 4
    {
        private List<Point3D> pathPoints = new List<Point3D>();

        public void AddPoint(Point3D point) // Task 4
        {
            pathPoints.Add(point);
        }

        public void ClearPathPoints() // Task 4
        {
            pathPoints.Clear();
        }

        public List<Point3D> PathPoints
        {
            get
            {
                return this.pathPoints;
            }
        }
    }
}
