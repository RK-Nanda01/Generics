using System;
namespace Generics
{
    public class GenericUtility<T> where T : IComparable<T>
    {
        public static void GreatestInArray(T[] arr)
        {
            Array.Sort(arr);
            int sizeOfArray = arr.Length;
            T maxElement = arr[sizeOfArray - 1];
            PrintMax(maxElement);

        }

        public static void PrintMax(T maxElement)
        {
            Console.WriteLine($"The Maximum Element is {maxElement}");
        }

        
    }
}
