namespace Generics;
class Program
{
    static void Main(string[] args)
    {
        string x, y, z;
        Console.WriteLine("Enter three strings:");
        x = Console.ReadLine();
        y = Console.ReadLine();
        z = Console.ReadLine();
        string maxString = Utility.GetMaximum("a", "a", "a" );
        Console.WriteLine($"The maximum string is: {maxString}");
        Console.ReadLine();
    }


}

