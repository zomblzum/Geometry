using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryLibrary.Shapes;
using GeometryLibrary.Calculators;

namespace GeometryTests
{
    [TestClass]
    public class PerimeterCalculatorTest
    {
        [TestMethod]
        public void CalculateCirclePerimeterTest()
        {
            double circleArea = 34.54;

            Shape circle = new Circle(5.5);
            Calculator calculator = new PerimeterCalculator();

            Assert.AreEqual(circleArea, calculator.Calculate(circle));
        }

        [TestMethod]
        public void CalculateTrianglePerimeterTest()
        {
            double triangleArea = 268.88;

            Shape triangle = new Triangle(125, 55, 88.88);
            Calculator calculator = new PerimeterCalculator();

            Assert.AreEqual(triangleArea, Math.Round(calculator.Calculate(triangle), 2));
        }

        [TestMethod]
        public void CalculateRectanglePerimeterTest()
        {
            double triangleArea = 80;

            Shape rectangle = new Rectangle(32, 8);
            Calculator calculator = new PerimeterCalculator();

            Assert.AreEqual(triangleArea, Math.Round(calculator.Calculate(rectangle), 2));
        }

        [TestMethod]
        public void CalculateSquarePerimeterTest()
        {
            double triangleArea = 32;

            Shape square = new Square(8);
            Calculator calculator = new PerimeterCalculator();

            Assert.AreEqual(triangleArea, Math.Round(calculator.Calculate(square), 2));
        }
    }
}
