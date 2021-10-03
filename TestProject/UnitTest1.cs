using GenericsTests;
using NUnit.Framework;

namespace TestProject
{
    public class Tests
    {
        [Test]
        public void GivenMaxInFirst_WhenMaxFloatCheck_ReturnFirst()
        {
            int a = 30, b = 20, c = 10;
            MaxFinder finder = new MaxFinder();
            float result = finder.FindMaxInt(a, b, c);
            Assert.AreEqual(a, result);
        }
        [Test]
        public void GivenMaxInSecond_WhenMaxFloatCheck_ReturnSecond_()
        {
            int a = 30, b = 20, c = 10;
            MaxFinder finder = new MaxFinder();
            int result = finder.FindMaxInt(b, a, c);
            Assert.AreEqual(a, result);
        }
        [Test]
        public void GivenMaxInLast_WhenMaxFloatCheck_ReturnLast()
        {
            int a = 30, b = 20, c = 10;
            MaxFinder finder = new MaxFinder();
            int result = finder.FindMaxInt(c, b, a);
            Assert.AreEqual(a, result);
        }
    }
}