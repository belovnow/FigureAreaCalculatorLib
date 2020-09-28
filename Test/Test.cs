using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureAreaCalculatorLib;

namespace Test
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CorrectValue()
        {
            Assert.ThrowsException<ArgumentException>(() => new CircleArea(0));
            Assert.ThrowsException<ArgumentException>(() => new CircleArea(-1));
        }
    }

    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void CorrectValue()
        {
            Assert.ThrowsException<ArgumentException>(() => new TriangleArea(0, 0, 0));
            Assert.ThrowsException<ArgumentException>(() => new TriangleArea(1, 2, -1));
        }
        [TestMethod]
        public void TriangleExist()
        {
            Assert.ThrowsException<ArgumentException>(() => new TriangleArea(1, 2, 3));
        }

        public void TriangleIsRight()
        {
            Assert.AreEqual(new TriangleArea(3, 4, 5).IsRightTriangle, true);
        }

        [TestMethod]
        public void ArbitraryTriangleRightArea()
        {
            TriangleArea triangle = new TriangleArea(6, 4, 5);
            double p = (6 + 4 + 5) * 0.5;
            double rightArea = Math.Sqrt(p * (p - 6) * (p - 4) * (p - 5));

            Assert.AreEqual(rightArea, triangle.Area);
        }

        [TestMethod]
        public void ArbitraryTriangleIsNotRight()
        {
            Assert.AreEqual(false, new TriangleArea(6, 4, 5).IsRightTriangle);
        }

        [TestMethod]
        public void RightTriangleRightArea()
        {
            double rightArea = (4 * 3) * 0.5;

            Assert.AreEqual(rightArea, new TriangleArea(4, 3, 5).Area);
        }

        [TestMethod]
        public void RightTriangleIsRight()
        {
            Assert.AreEqual(true, new TriangleArea(4, 3, 5).IsRightTriangle);
        }

        [TestMethod]
        public void IsoscelesTriangleRightArea()
        {
            double p = (7 + 7 + 5) * 0.5;
            double rightArea = Math.Sqrt(p * (p - 7) * (p - 7) * (p - 5));

            Assert.AreEqual(rightArea, new TriangleArea(7, 7, 5).Area);
        }

        [TestMethod]
        public void IsoscelesTriangleIsNotRight()
        {
            Assert.AreEqual(false, new TriangleArea(7, 7, 5).IsRightTriangle);
        }

        [TestMethod]
        public void EquilateralTriangleRightArea()
        {
            double p = (13 * 3) * 0.5;
            double rightArea = Math.Sqrt(p * (p - 13) * (p - 13) * (p - 13));

            Assert.AreEqual(rightArea, new TriangleArea(13, 13, 13).Area);
        }

        [TestMethod]
        public void EquilateralTriangleIsNotRight()
        {
            Assert.AreEqual(false, new TriangleArea(7, 7, 5).IsRightTriangle);
        }
    }
}

