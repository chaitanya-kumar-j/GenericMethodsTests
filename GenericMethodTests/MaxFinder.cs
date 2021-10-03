using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsTests
{
    public class MaxFinder
    {
        public int FindMaxInt(int a, int b, int c)
        {
            if (a > b && a > c && a != 0)
            {
                return a;
            }
            if (b > c && b > c)
            {
                return b;
            }
            return c;
        }
        public float FindMaxFloat(float a, float b, float c)
        {
            if (a > b && a > c && a != 0)
            {
                return a;
            }
            if (b > c && b > c)
            {
                return b;
            }
            return c;
        }
        public string FindMaxString(string string1, string string2, string string3)
        {
            Console.Write("The maximum among three string:");
            if (string1.CompareTo(string2) > 0 && string1.CompareTo(string3) > 0)
                return string1;
            if (string2.CompareTo(string1) > 0 && string2.CompareTo(string3) > 0)
                return string2;
            if (string3.CompareTo(string1) > 0 && string3.CompareTo(string2) > 0)
                return string3;
            return null;
        }
    }
}