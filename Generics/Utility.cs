using System;
namespace Generics
{
	public class Utility
	{
        public static string GetMaximumString(string[] strings)
        {
            string maxString = strings[0];
            for (int i = 1; i < strings.Length; i++)
            {
                if (string.Compare(strings[i], maxString) > 0)
                {
                    maxString = strings[i];
                }
            }
            return maxString;
        }
    }
}
