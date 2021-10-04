using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsTests
{
    public class MaxFinder<T> where T : IComparable
    {
        public T FindMaxGeneric(T first,T second,T third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
                return first;
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
                return second;
            if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
                return third;
            return default;
        }
    }
}