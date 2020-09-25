using NUnit.Framework;
using ShapeCalculator;

namespace ShapeCalculator.Test
{
    public class Tests
    {
        ShapeAreaCalc shapeCalc;
        [SetUp]
        public void Setup()
        {
            shapeCalc = new ShapeAreaCalc();
        }

        [Test]
        public void SquareArea4()
        {
            Assert.AreEqual(4, shapeCalc.squareArea(2));
        }

        [Test]
        public void RectangleArea36()
        {
            Assert.AreEqual(36, shapeCalc.rectangleArea(3,12));
        }
        [Test]
        public void CircleArea()
        {
            Assert.AreEqual(78.5, shapeCalc.circleArea(5));
        }
        [Test]
        public void TriangleArea()
        {
            Assert.AreEqual(144, shapeCalc.triangleArea(12, 24));
        }
        [Test]
        public void PentagonArea()
        {
            Assert.AreEqual(5204.44, shapeCalc.pentagonArea(55));
        }

    }
}