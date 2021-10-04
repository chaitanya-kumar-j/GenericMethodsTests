using GenericsTests;
using NUnit.Framework;

namespace TestProject
{
    public class Tests
    {
        int num1 = 30, num2 = 20, num3 = 10;
        float number1 = 33.33f, number2 = 22.22f, number3 = 11.11f;
        string a = "October", b = "June", c = "May";
        [Test]
        public void GivenMaxInFirst_WhenMaxIntCheck_ReturnFirst()
        {
            MaxFinder<int> intMaxFinder = new GenericsTests.MaxFinder<int>();
            int intResult = intMaxFinder.FindMaxGeneric(num1, num2, num3);
            Assert.AreEqual(num1, intResult);
        }
        [Test]
        public void GivenMaxInFirst_WhenMaxFloatCheck_ReturnFirst()
        {
            MaxFinder<float> floatMaxFinder = new GenericsTests.MaxFinder<float>();
            float floatResult = floatMaxFinder.FindMaxGeneric(number1, number2, number3);
            Assert.AreEqual(number1, floatResult);
        }
        [Test]
        public void GivenMaxInFirst_WhenMaxStringCheck_ReturnFirst()
        {
            MaxFinder<string> stringMaxFinder = new GenericsTests.MaxFinder<string>();
            string stringResult = stringMaxFinder.FindMaxGeneric(a, b, c);
            Assert.AreEqual(a, stringResult);
        }
        [Test]
        public void GivenMaxInSecond_WhenMaxIntCheck_ReturnSecond()
        {
            MaxFinder<int> intMaxFinder = new GenericsTests.MaxFinder<int>();
            int intResult = intMaxFinder.FindMaxGeneric(num2, num1, num3);
            Assert.AreEqual(num1, intResult);
        }
        [Test]
        public void GivenMaxInSecond_WhenMaxFloatCheck_ReturnSecond()
        {
            MaxFinder<float> floatMaxFinder = new GenericsTests.MaxFinder<float>();
            float floatResult = floatMaxFinder.FindMaxGeneric(number2, number1, number3);
            Assert.AreEqual(number1, floatResult);
        }
        [Test]
        public void GivenMaxInSecond_WhenMaxStringCheck_ReturnSecond()
        {
            MaxFinder<string> stringMaxFinder = new GenericsTests.MaxFinder<string>();
            string stringResult = stringMaxFinder.FindMaxGeneric(b, a, c);
            Assert.AreEqual(a, stringResult);
        }
        [Test]
        public void GivenMaxInLast_WhenMaxIntCheck_ReturnLast()
        {
            MaxFinder<int> intMaxFinder = new GenericsTests.MaxFinder<int>();
            int intResult = intMaxFinder.FindMaxGeneric(num3, num2, num1);
            Assert.AreEqual(num1, intResult);
        }
        [Test]
        public void GivenMaxInLast_WhenMaxFloatCheck_ReturnLast()
        {
            MaxFinder<float> floatMaxFinder = new GenericsTests.MaxFinder<float>();
            float floatResult = floatMaxFinder.FindMaxGeneric(number3, number2, number1);
            Assert.AreEqual(number1, floatResult);
        }
        [Test]
        public void GivenMaxInLast_WhenMaxStringCheck_ReturnLast()
        {
            MaxFinder<string> stringMaxFinder = new GenericsTests.MaxFinder<string>();
            string stringResult = stringMaxFinder.FindMaxGeneric(c, b, a);
            Assert.AreEqual(a, stringResult);
        }
    }
}