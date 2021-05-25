using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class ShapeTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Rectangle re = new Rectangle();

            int x = 120, y = 90, width = 100, height = 100;
            re.set(x, y, width, height);
            Assert.AreEqual(200, re.x);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Circle rec = new Circle();

            int x = 10, y = 50, radius = 10;
            rec.set(x, y, radius);
            Assert.AreEqual(00, rec.radius);
        }
    }
}
