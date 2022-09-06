using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AreaTriangleSquareLibrary.Tests
{
    [TestClass]
    public class CiriceTests
    {
        [TestMethod]
        public void Circle_Is_Shape()
        {
            var circle = new Circle(5);
            Assert.IsInstanceOfType(circle, typeof(Shape));
        }

        [TestMethod]
        public void Circle_Area_Is_314_159()
        {
            var circle = new Circle(10);

            double area = Math.Round(circle.Area, 3);

            Assert.AreEqual(314.159, area);
        }
    }
}
