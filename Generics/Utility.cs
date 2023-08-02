using System;
namespace Generics
{
	public class Utility
	{
		public static float LargestFloat(float x, float y, float z)
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

