﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryLibrary.Shapes;
using GeometryLibrary;

namespace GeometryTests
{
    [TestClass]
    public class GeometryFacadeTests
    {
        [TestMethod]
        public void AreaTest()
        {
            double triangleArea = 2143.2;

            Shape triangle = new Triangle(125, 55, 88.88);

            Assert.AreEqual(triangleArea, Math.Round(Geometry.Area(triangle), 2));
        }

        [TestMethod]
        public void PerimeterTest()
        {
            double trianglePerimeter = 88.88;

            Shape triangle = new Triangle(44.22, 22.44, 22.22);

            Assert.AreEqual(trianglePerimeter, Math.Round(Geometry.Perimeter(triangle), 2));
        }
    }
}
