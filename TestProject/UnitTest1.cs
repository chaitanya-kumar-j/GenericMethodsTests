using GenericsTests;
using NUnit.Framework;

namespace TestProject
{
    public class Tests
    {
        [Test]
        public void GivenMaxInFirst_WhenMaxStringCheck_ReturnFirst()
        {
            string a = "October", b = "June", c = "May";
            MaxFinder finder = new MaxFinder();
            string result = finder.FindMaxString(a, b, c);
            Assert.AreEqual(a, result);
        }
        [Test]
        public void GivenMaxInSecond_WhenMaxStringCheck_ReturnSecond_()
        {
            string a = "October", b = "June", c = "May";
            MaxFinder finder = new MaxFinder();
            string result = finder.FindMaxString(b, a, c);
            Assert.AreEqual(a, result);
        }
        [Test]
        public void GivenMaxInLast_WhenMaxStringCheck_ReturnLast()
        {
            string a = "October", b = "June", c = "May";
            MaxFinder finder = new MaxFinder();
            string result = finder.FindMaxString(c, b, a);
            Assert.AreEqual(a, result);
        }
    }
}