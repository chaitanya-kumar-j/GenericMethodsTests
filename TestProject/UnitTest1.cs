using GenericsTests;
using NUnit.Framework;

namespace TestProject
{
    public class Tests
    {
        [Test]
        public void GivenMaxInFirst_WhenMaxFloatCheck_ReturnFirst()
        {
            float a = 30.16f, b = 20.29f, c = 10.30f;
            MaxFinder finder = new MaxFinder();
            float result = finder.FindMaxFloat(a, b, c);
            Assert.AreEqual(a, result);
        }
        [Test]
        public void GivenMaxInSecond_WhenMaxFloatCheck_ReturnSecond_()
        {
            float a = 30.16f, b = 20.29f, c = 10.30f;
            MaxFinder finder = new MaxFinder();
            float result = finder.FindMaxFloat(b, a, c);
            Assert.AreEqual(a, result);
        }
        [Test]
        public void GivenMaxInLast_WhenMaxFloatCheck_ReturnLast()
        {
            float a = 30.16f, b = 20.29f, c = 10.30f;
            MaxFinder finder = new MaxFinder();
            float result = finder.FindMaxFloat(c, b, a);
            Assert.AreEqual(a, result);
        }
    }
}