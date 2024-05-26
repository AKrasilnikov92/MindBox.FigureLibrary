using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureLibrary.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Square_10_Return314_16()
        {
            Circle circle = new("����", 10);
            double expected = 314.16;

            double result = circle.CalcSquare();

            Assert.AreEqual(expected, result,"������� ������ ���� ���� ����� 314,16.");
        }

        [TestMethod]
        public void Square_NotExist()
        {
            Circle circle = new("����", -5);

            Assert.ThrowsException<Exception>(() => circle.CalcSquare());
        }
    }
}