using System;
using System.Text;

namespace _3DPointProgram
{
    public struct Point3D // Task 1
    {
        private double x;
        private double y;
        private double z;

        static private Point3D point0 = new Point3D(0, 0, 0); // Task 2

        public Point3D(double x, double y, double z) : this() // Task 1
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X // Task 1
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public double Y // Task 1
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

        public double Z // Task 1
        {
            get
            {
                return this.z;
            }
            set
            {
                this.z = value;
            }
        }

        public static Point3D Point0 // Task 2
        {
            get
            {
                return point0;
            }
        }

        public override string ToString() // Task 1
        {
            StringBuilder print = new StringBuilder();

            print.Append("X: ");
            print.Append(this.X);
            print.Append(", Y: ");
            print.Append(this.Y);
            print.Append(", Z: ");
            print.Append(this.Z);
            print.Append(";");

            return print.ToString();
        }
    }
}
