using Geometry.Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void RightTriangleTest()
        {
            Triangle triangle = new Triangle(5, 4, 3);
            Assert.IsTrue(triangle.IsRightTriangle());
        }
    }
}
