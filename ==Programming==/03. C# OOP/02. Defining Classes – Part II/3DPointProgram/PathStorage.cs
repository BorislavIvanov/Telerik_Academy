using System;
using System.IO;

namespace _3DPointProgram
{
    class PathStorage // Task 4
    {
        public static void SavePath(Path path) // Task 4
        {
            using (StreamWriter pathWriter = new StreamWriter(@"../../SaveFile.txt", false))
            {
                foreach (Point3D point in path.PathPoints)
                {
                    pathWriter.WriteLine(point);
                }
            }
        }

        public static Path LoadPath() // Task 4
        {
            Path loadedPath = new Path();
            using (StreamReader pathReader = new StreamReader(@"../../LoadFile.txt"))
            {
                string line = pathReader.ReadLine();
                while(line != null)
                {
                    Point3D point = new Point3D();

                    string[] points = line.Split(',');
                    point.X = double.Parse(points[0]);
                    point.Y = double.Parse(points[1]);
                    point.Z = double.Parse(points[2]);
                    loadedPath.AddPoint(point);

                    line = pathReader.ReadLine();
                }
            }
            return loadedPath;
        }
    }
}