namespace Generics;
class Program
{
    static void Main(string[] args)
    {
        int n, y, z;
        Console.WriteLine("Enter size of array");
        n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        for(int i =0; i<n; i++)
        {
            arr[i] =Convert.ToInt32(Console.ReadLine());
        }

        GenericUtility<int> obj = new GenericUtility<int>();
        Console.WriteLine($"The maximum value is: {GenericUtility<int>.GreatestInArray(arr)}");
        Console.ReadLine();
    
    }


}

