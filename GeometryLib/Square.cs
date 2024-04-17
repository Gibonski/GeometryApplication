using System;

namespace GeometryLib
{
    public class Square : IShape
    {
        private double side;

        public double Side
        {
            get { return side; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Side length must be greater than zero.");
                side = value;
            }
        }

        public Square(double side)
        {
            Side = side;
        }

        public double CalculateArea()
        {
            return Side * Side;
        }

        public double CalculatePerimeter()
        {
            return 4 * Side;
        }
    }
}
