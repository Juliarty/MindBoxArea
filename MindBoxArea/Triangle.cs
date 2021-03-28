using System;
using System.Collections.Generic;

namespace MindBoxArea
{
    public class Triangle : AbstractFigure
    {
        public double Side1 { get; }
        public double Side2 { get; }
        public double Side3 { get; }


        /// <summary>
        /// Checks whether the triangle is right.
        /// </summary>
        public bool IsRight
        {
            get
            {
                var sortedListSideToSideSquares = new SortedList<double, double>()
                { 
                    { Side1, Math.Pow(Side1, 2) },
                    { Side2, Math.Pow(Side2, 2) },
                    { Side3, Math.Pow(Side3, 2) } 
                };

                return sortedListSideToSideSquares.Values[0] + sortedListSideToSideSquares.Values[1] == sortedListSideToSideSquares.Values[2];
            }
        }

        /// <summary>
        /// Creates a triangle with specified sides.
        /// Note: it's not possible to create a degenerate triangle using this method.
        /// </summary>
        /// <param name="side1">A side of the triangle</param>
        /// <param name="side2">A side of the triangle</param>
        /// <param name="side3">A side of the triangle</param>
        /// <exception cref="System.ArgumentException">Thrown when side1, side2, or side3 is not a positive real number. 
        /// Also thrown when the sides don't correspond to triangle inequality or when the result triangle will be degenerate.  </exception>
        public Triangle(double side1, double side2, double side3) : base("Triangle")
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0) throw new ArgumentException("All sides of triangle must be positive real numbers.");

            // https://en.wikipedia.org/wiki/Triangle_inequality
            // The triangle inequality states that the sum of the lengths of any two sides of a triangle must be greater than or equal to the length of the third side.
            if (side1 + side2 <= side3 ||
               side1 + side3 <= side2 ||
               side2 + side3 <= side1) throw new ArgumentException("Values of sides violate triangle inequality. There is no triangle with passed sides.");

            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }
        public override double Area()       // (p(p - a)(p - b)(p - c))^(1/2), where p = (a + b + c)/2
        {
            var p = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }
    }
}
