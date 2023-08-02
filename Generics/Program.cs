namespace Generics;
class Program
{
    static void Main(string[] args)
    {
        
        int option;
        bool flag = true;

        while(flag)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1.Max Of 3 Integers");
            Console.WriteLine("2.Max Of 3 Float");
            Console.WriteLine("3.Max Of 3 Strings");
            Console.WriteLine("0.Exit");
            option = Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 0:
                    {
                        flag = false;
                        break;
                    }

                case 1:
                    {
                        int x, y, z;
                        Console.WriteLine("Enter x");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter y");
                        y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter z");
                        z = Convert.ToInt32(Console.ReadLine());
                        GenericUtility<int> obj = new GenericUtility<int>(x, y, z);
                        Console.WriteLine($"The maximum value is: {obj.TestMaximum()}");
                        break;

                    }
                case 2:
                    {
                        float x, y, z;
                        Console.WriteLine("Enter x");
                        x = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Enter y");
                        y = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Enter z");
                        z = Convert.ToSingle(Console.ReadLine());
                        GenericUtility<float> obj = new GenericUtility<float>(x, y, z);
                        Console.WriteLine($"The maximum value is: {obj.TestMaximum()}");
                        break;

                    }
                case 3:
                    {
                        string x, y, z;
                        Console.WriteLine("Enter x");
                        x = Console.ReadLine();
                        Console.WriteLine("Enter y");
                        y = Console.ReadLine();
                        Console.WriteLine("Enter z");
                        z = Console.ReadLine();
                        GenericUtility<string> obj = new GenericUtility<string>(x, y, z);
                        Console.WriteLine($"The maximum value is: {obj.TestMaximum()}");
                        break;

                    }
            }
        }

    }


}

