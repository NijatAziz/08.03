using System;

namespace Homework
{
    internal static class Extension
    {
        public static bool CustomContains(this string mainText, string searchText)
        {
            string mainLower = mainText.ToLower();
            string searchLower = searchText.ToLower();

            int index = 0;
            foreach (char c in mainLower)
            {
                if (c == searchLower[index])
                {
                    index++;
                    if (index == searchLower.Length)
                        return true;
                }
                else
                {
                    index = 0;
                }
            }

            return false;
        }
    }


}
