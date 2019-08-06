using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _5
    {
        public void runCode()
        {
            string s = "cbbd";
            LongestPalindrome(s);
        }
        public string LongestPalindrome(string s)
        {
            if (s == "" || s.Length < 1) return "";
            int start = 0, end = 0;
            for(int i = 0; i<s.Length; i++)
            {
                int[] l1 = Rec(s, i, i);
                int[] l2 = Rec(s, i, i + 1);                   
                
                if (Math.Max(l1[1] - l1[0], l2[1] - l2[0]) > end - start)
                {
                    if (l1[1] - l1[0] > l2[1] - l2[0])
                    {
                        start = l1[0];
                        end = l1[1];
                    }
                    else
                    {
                        start = l2[0];
                        end = l2[1];
                    }
                }
            }
            if (start == end)
                return s[start].ToString();
            return s.Substring(start, end-start+1);
        }

        int[] Rec(string s,int l,int r)
        {
            int L = l, R = r;
            if(!(L >= 0 && R < s.Length && s[L] == s[R]))
                return new int[] {L,L };

            while (L >= 0 && R < s.Length && s[L] == s[R])
            {
                L--;
                R++;
            }
            return new int[] { ++L, --R };
        }
    }
}
