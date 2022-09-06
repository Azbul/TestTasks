using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AreaTriangleSquareLibrary.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Triangle_Is_Shape()
        {
            var triangle = new Triangle();
            Assert.IsInstanceOfType(triangle, typeof(Triangle));
        }

        [TestMethod]
        public void Triangle_Area_Is_18_33()
        {
            var triangle = new Triangle(5, 8, 11);

            var area = Math.Round(triangle.Area, 3);

            Assert.AreEqual(18.330, area);
        }
        
        [TestMethod]
        public void Triangle_Is_Right()
        {
            var triangle = new Triangle(3, 4, 5);

            double hypotenusePow = triangle.C * triangle.C;
            double legsPowSum = triangle.A * triangle.A + triangle.B * triangle.B;

            Assert.IsTrue(hypotenusePow == legsPowSum);
        }
    }
}
