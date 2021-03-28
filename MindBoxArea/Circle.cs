using System;

namespace MindBoxArea
{
    public class Circle: AbstractFigure
    {
        public double Radius { get; }

        /// <summary>
        /// Creates a circle with specified radius.
        /// </summary>
        /// <param name="radius">Circle's radius</param>
        /// <exception cref="System.ArgumentException">Thrown when passed radius is not a positive real number. </exception>
        public Circle(double radius): base("Circle")
        {
            if (radius <= 0) throw new ArgumentException("Radius must be a positive real number");
            Radius = radius;
        }

        public override double Area() => Math.PI * Math.Pow(Radius, 2);     // pi * r^2
        
    }
}
