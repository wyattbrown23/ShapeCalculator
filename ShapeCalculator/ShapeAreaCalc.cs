using System;

namespace ShapeCalculator
{
    public class ShapeAreaCalc
    {
        public double shapeLength { get; set; }
        public double shapeWidth { get; set; }
        public double shapeRadius { get; set; }
        public double shapeBase { get; set; }
        public double shapeHeight { get; set; }
        public double sideLength { get; set; }

        public double squareArea(double sideLength)
        {
            return sideLength * sideLength;
        }
        public double rectangleArea(double shapeLength, double shapeWidth)
        {
            return shapeLength * shapeWidth;
        }
        public double circleArea(double shapeRadius)
        {
            return 3.14*shapeRadius*shapeRadius;
        }
        public double triangleArea(double shapeBase,double shapeHeight)
        {
            return .5 * shapeBase * shapeHeight;
        }
        public double pentagonArea(double sideLength)
        {
            double result = .25 * (Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5)))) * sideLength * sideLength;
            return Math.Round(result, 2);
        }
    }
}
