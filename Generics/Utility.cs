using System;
namespace Generics
{
    public class GenericUtility<T> where T : IComparable<T>
    {
        private T a, b, c;

        public GenericUtility(T val1, T val2, T val3)
        {
            a = val1;
            b = val2;
            c = val3;

        }
        public T TestMaximum()
        {
            return GetMaximum(a, b, c);
        }

        public static T GetMaximum(T a, T b, T c) 
        {
            T max = a;
            if (b.CompareTo(max) > 0)
            {
                max = b;
            }
            if (c.CompareTo(max) > 0)
            {
                max = c;
            }
            return max;
        }

        
    }
}
