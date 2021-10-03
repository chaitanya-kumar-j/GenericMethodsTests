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
    }
}