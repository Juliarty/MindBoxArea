using NUnit.Framework;
using System;

namespace MindBoxArea.Test
{
    [TestFixture]
    public class CircleTests
    {
        private const double _doubleNumberPrecision = 0.0000001;

        [TestCase(1.0000000, Math.PI)]
        [TestCase(2.0000000, 12.5663706)]
        [TestCase(3.5000000, 38.4845100)]
        public void Area_PositiveRadius_RightAnswer(double radius, double expectedArea)
        {
            var circle = new Circle(radius);
            Assert.Less(Math.Abs(expectedArea - circle.Area()), _doubleNumberPrecision);
        }

        [TestCase(0)]
        [TestCase(-1.3)]
        public void Area_NotPositiiveRadius_ArgumentOutOfRangeException(double radius)
        {
            Assert.That(() => { new Circle(radius); }, Throws.ArgumentException);
        }
    }
}
