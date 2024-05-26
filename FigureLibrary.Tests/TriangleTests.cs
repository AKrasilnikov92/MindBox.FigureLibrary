using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureLibrary.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void IsRectangularTriangle_ReturnTrue()
        {
            Triangle triangle = new("Треугольник", 3, 4, 5);

            bool result = triangle.IsRectangularTriangle();

            Assert.IsTrue(result, "Треугольник должен быть прямоугольным.");
        }

        [TestMethod]
        public void IsRectangularTriangle_ReturnFalse()
        {
            Triangle triangle = new("Треугольник", 10, 10, 6);

            bool result = triangle.IsRectangularTriangle();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Square_10and10and6_Return95_53()
        {
            Triangle triangle = new("Треугольник", 10, 10, 6);

            double expected = 95.53;
            double result = triangle.CalcSquare();
            Assert.AreEqual(expected, result, "Площадь треугольника должна была быть равна 95,63.");
        }
    }
}
