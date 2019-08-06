using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _28
    {
        public int StrStr(string haystack, string needle)
        {
            int nl = needle.Length;
            for(int i =0; i<haystack.Length-nl; i++)
            {
                if (haystack.Substring(i, nl) == needle)
                    return i;
            }

            return -1;

        }
    }
}
