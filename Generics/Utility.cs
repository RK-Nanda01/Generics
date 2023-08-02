using System;
namespace Generics
{
    public class GenericUtility<T> where T : IComparable<T>
    {
        public static T GreatestInArray(T[] arr)
        {
            Array.Sort(arr);
            int sizeOfArray = arr.Length;
            T maxElement = arr[sizeOfArray - 1];
            return maxElement;

        }

        
    }
}
