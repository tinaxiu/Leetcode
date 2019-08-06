using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _3
    {
        public void runCode()
        {
            string s = "abcabcbb";
            LengthOfLongestSubstring(s);
        }
        public int LengthOfLongestSubstring(string s)
        {
            HashSet<char> map = new HashSet<char>();
            int max = 0;
            int i = 0, j = 0;
            while(i<s.Length && j<s.Length)
            {
                if(!map.Contains(s[j]))
                {
                    map.Add(s[j++]);
                    max = Math.Max(max, j - i);
                }
                else
                {
                    map.Remove(s[i++]);
                }
            }

            return max;

            
        }
    }
}
