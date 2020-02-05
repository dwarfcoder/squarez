using System;
using squarez.lib;
using Xunit;

namespace squarez.tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(5)]
        [InlineData(0)]
        [InlineData(-10)]
        public void TestArea(int radius)
        {
            var circle = new Circle(radius);
            
            Assert.Equal(GetExpected(radius), circle.GetArea());
        }

        private double GetExpected(int r) => Math.PI * r * r;
    }
}
