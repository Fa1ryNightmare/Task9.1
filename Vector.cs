using System;

namespace Task9_1
{
    class Vector
    {
        private double aX = 0;
        private double aY = 0;
        private double aZ = 0;

        private double bX;
        private double bY;
        private double bZ;

        public Vector(double x, double y, double z)
        {
            bX = x;
            bY = y;
            bZ = z;
        }

        public double CoordinateX
        {
            get
            {
                return bX - aX;
            }
        }

        public double CoordinateY
        {
            get
            {
                return bY - aY;
            }
        }

        public double CoordinateZ
        {
            get
            {
                return bZ - aZ;
            }
        }

        public double Length()
        {
            return Math.Sqrt(Math.Pow(CoordinateX, 2) + Math.Pow(CoordinateY, 2) + Math.Pow(CoordinateZ, 2));
        }

        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.CoordinateX + b.CoordinateX, a.CoordinateY + b.CoordinateY, a.CoordinateZ + b.CoordinateZ);
        }

        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.CoordinateX - b.CoordinateX, a.CoordinateY - b.CoordinateY, a.CoordinateZ - b.CoordinateZ);
        }

        public override string ToString()
        {
            return $"Длинна вектора: {Length()}" + $"\nКоординаты вектора: ({CoordinateX},{CoordinateY},{CoordinateZ})";
        }
    }
}
