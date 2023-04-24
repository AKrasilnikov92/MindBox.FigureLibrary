using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureLibrary.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Square_10_Return314_16()
        {
            Circle circle = new("Круг", 10);
            double expected = 314.16;

            double result = circle.Square();

            Assert.AreEqual(expected, result,"Площадь должна была быть равна 314,16.");
        }
    }
}