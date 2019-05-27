using System;

namespace tpzslaba9_3_
{
    class Circle
    {
        public double SquareCircle(double radius)
        {

            return Math.PI * Math.Pow(radius, 2);

        }

        public double LengthCircle(double radius)
        {

            return 2 * Math.PI * radius;

        }

        public double CapacitySphere(double radius)
        {

            return ((double)4 / 3) * Math.PI * Math.Pow(radius, 3);

        }
    }
}
