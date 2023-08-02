namespace Generics;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter three strings:");
        string[] strings = new string[3];
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"String {i + 1}: ");
            strings[i] = Console.ReadLine();
        }

        string maxString = Utility.GetMaximumString(strings);

        Console.WriteLine($"The maximum string is: {maxString}");
        Console.ReadLine();
    }


}

