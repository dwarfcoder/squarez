using System;

namespace squarez.lib
{
    public class Triangle : IFigure
    {
        public double[] sides = new double[3];

        private readonly bool is90Degree;

        public double A => sides[0];

        public double B => sides[1];

        public double C => sides[2];

        public Triangle(double a, double b, double c)
        {
            sides[0] = a;
            sides[1] = b;
            sides[2] = c;

            Array.Sort(sides);

            var hypSqr = Math.Round(C * C, 4);
            if(hypSqr == A * A + B * B)
            {
                is90Degree = true;
            }
        }

        public double GetArea()
        {
            if(is90Degree)
            {
                // прямоугольный
                return A * B / 2;
            }

            // считаем по алгоритму Герона
            return GetAreaHeroWay(A, B, C);
        }

        private double GetAreaHeroWay(double a, double b, double c)
        {
            double sp = (a + b + c) / 2; // semiperimeter

            double l1 = sp - a;
            double l2 = sp - b;
            double l3 = sp - c;

            return Math.Round(Math.Sqrt(sp * l1 * l2 * l3), 4);
        }
    }
}