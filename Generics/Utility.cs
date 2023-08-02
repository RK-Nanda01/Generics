using System;
namespace Generics
{
	public class Utility
	{
		public static int LargestInt(int x, int y, int z)
		{
            
                if (x >= y)
                {
                    if (x >= z)
                    {
                        return x;
                    }
                    else
                    {

                        return z;

                    }

                }

                else
                {
                    if (y >= z)
                    {
                        return y;
                    }
                    else
                    {
                        return z;
                    }
                }
        }
	}
}

