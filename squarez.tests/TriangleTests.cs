using System;
using squarez.lib;
using Xunit;

namespace squarez.tests
{
    public class TriangleTests
    {

        [Theory]
        [InlineData(2.0, 2.0, 2.8284271)]
        [InlineData(2, 2, 2)]
        [InlineData(15, 5, 8)]
        public void TestArea(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);

            var area = triangle.GetArea();
            var expected = GetExpected(a, b, c);
            Assert.Equal(expected, area);
        }

        private double GetExpected(double a, double b, double c)
        {
            double sp = (a + b + c) / 2; // semiperimeter

            double l1 = sp - a;
            double l2 = sp - b;
            double l3 = sp - c;

            return Math.Round(Math.Sqrt(sp * l1 * l2 * l3), 4);
        }
    }
}