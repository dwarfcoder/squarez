using System;

namespace squarez.lib
{
    public class Circle : IFigure
    {
        public int Radius { get; private set; }
        
        public Circle(int radius)
        {
            Radius = radius;
        }

        public double GetArea() => Math.PI * Radius * Radius;
    }
}