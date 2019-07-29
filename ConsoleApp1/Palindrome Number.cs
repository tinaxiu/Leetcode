using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Palindrome_Number
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            
            string s = x.ToString();
            int i = 0, j = s.Length-1;
            while(i < j)
            {
                if (s[i] != s[j])
                    return false;
                else
                {
                    i++;
                    j--;
                }
            }
            return true;

        }
    }
}
