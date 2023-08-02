namespace Generics;
class Program
{
    static void Main(string[] args)
    {
        float x, y, z;

        Console.WriteLine("Welcome to Generics!");
        Console.WriteLine("Enter x");
        x = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Enter y");
        y = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Enter z");
        z = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine($"Maximum integer is {Utility.LargestFloat(x, y, z)}");
        Console.ReadLine();
    }
}

