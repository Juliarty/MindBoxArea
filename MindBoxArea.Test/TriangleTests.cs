using NUnit.Framework;
using System;

namespace MindBoxArea.Test
{
    class TriangleTests
    {
        private const double _doubleNumberPrecision = 0.0000001; 
        [TestCase(3, 4, 5, 6)]
        [TestCase(3.1515151, 4.99999999, 5.123123123, 7.5736554)]
        public void Area_PositiveRadius_RightAnswer(double side1, double side2, double side3, double expectedArea)
        {
            var triangle = new Triangle(side1, side2, side3);
            Assert.Less(Math.Abs(expectedArea - triangle.Area()), _doubleNumberPrecision);
        }

        [TestCase(-3, 4, 5)]
        [TestCase(3, -4, 5)]
        [TestCase(3, 4, -5)]
        [TestCase(3, -4, -5)]
        [TestCase(-3, -4, -5)]
        public void Area_NotPositiiveSides_ArgumentException(double side1, double side2, double side3)
        {
            Assert.That(() => { new Triangle(side1, side2, side3); }, Throws.ArgumentException);
        }

        [TestCase(1, 2, 3)]
        [TestCase(1, 3, 2)]
        [TestCase(2, 1, 3)]
        [TestCase(2, 3, 1)]
        [TestCase(3, 1, 2)]
        [TestCase(3, 2, 1)]
        public void Area_ImpossibleTriangle_ArgumentException(double side1, double side2, double side3)
        {
            Assert.That(() => { new Triangle(side1, side2, side3); }, Throws.ArgumentException);
        }

        [TestCase(3, 4, 5)]
        [TestCase(3, 5, 4)]
        [TestCase(4, 3, 5)]
        [TestCase(4, 5, 3)]
        [TestCase(5, 3, 4)]
        [TestCase(5, 4, 3)]
        public void IsRight_RightTriangleSides_True(double side1, double side2, double side3)
        {
            Assert.IsTrue(new Triangle(side1, side2, side3).IsRight);
        }

        [TestCase(3, 4, 5.1)]
        [TestCase(3, 5.1, 4)]
        [TestCase(4, 3, 5.1)]
        [TestCase(4, 5.1, 3)]
        [TestCase(5.1, 3, 4)]
        [TestCase(5.1, 4, 3)]
        public void IsRight_NotRightTriangleSides_False(double side1, double side2, double side3)
        {
            Assert.IsFalse(new Triangle(side1, side2, side3).IsRight);
        }
    }
}
