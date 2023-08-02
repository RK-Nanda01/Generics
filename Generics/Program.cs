namespace Generics;
class Program
{
    static void Main(string[] args)
    {
        int x, y, z,res;

        Console.WriteLine("Welcome to Generics!");
        Console.WriteLine("Enter x");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter y");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter z");
        z = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Maximum integer is {Utility.LargestInt(x, y, z)}");
        Console.ReadLine();
    }
}

