using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _268
    {
        public int MissingNumber(int[] nums)
        {
            int l = (nums.Length+1) * nums.Length /2;
            int t = 0;
            foreach(int n in nums)
            {
                t += n;
            }
            return l - t;
        }
    }
}
