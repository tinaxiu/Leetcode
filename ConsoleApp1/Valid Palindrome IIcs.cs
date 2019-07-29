using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Valid_Palindrome_IIcs
    {
        public static void runCode()
        {
            string s = "abdca";
            validPalindrome(s);
        }
        public static bool isPlalinfromeRange(string s, int i, int j)
        {
            for (int k = i; k <= i + (j - i) / 2; k++)
            {
                if (s[k] != s[j - k + i])
                    return false;
            }
            return true;

        }
        public static bool validPalindrome(String s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] != s[s.Length-1-i])
                {
                    int j = s.Length - 1 - i;

                    isPlalinfromeRange(s, i + 1, j);
                    isPlalinfromeRange(s, i, j - 1);
                    return (isPlalinfromeRange(s, i + 1, j) || isPlalinfromeRange(s, i, j - 1));
                }
            }
            return true;
        }
    }
}
