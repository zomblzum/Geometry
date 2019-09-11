using System;
using GeometryLibrary.Calculators;
using GeometryLibrary.Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryTests
{
    [TestClass]
    public class AreaCalculatorTests
    {
        [TestMethod]
        public void CalculateCircleAreaTest()
        {
            double circleArea = 94.985;

            Shape circle = new Circle(5.5);
            Calculator calculator = new AreaCalculator();

            Assert.AreEqual(circleArea, calculator.Calculate(circle));
        }

        [TestMethod]
        public void CalculateTriangleAreaTest()
        {
            double triangleArea = 2143.2;

            Shape triangle = new Triangle(125, 55, 88.88);
            Calculator calculator = new AreaCalculator();

            Assert.AreEqual(triangleArea, Math.Round(calculator.Calculate(triangle),2));
        }

        [TestMethod]
        public void CalculateRectangleAreaTest()
        {
            double triangleArea = 256;

            Shape rectangle = new Rectangle(32, 8);
            Calculator calculator = new AreaCalculator();

            Assert.AreEqual(triangleArea, Math.Round(calculator.Calculate(rectangle), 2));
        }

        [TestMethod]
        public void CalculateSquareAreaTest()
        {
            double triangleArea = 64;

            Shape square = new Square(8);
            Calculator calculator = new AreaCalculator();

            Assert.AreEqual(triangleArea, Math.Round(calculator.Calculate(square), 2));
        }
    }
}
