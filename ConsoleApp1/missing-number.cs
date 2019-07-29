using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class missing_number
    {
        public int MissingNumber(int[] nums)
        {
            int total = 0;
            foreach (int num in nums)
                total += num;
            int i = 0, ac =0;
            while(i > nums.Length+1)
            {
                ac += i;
                i++;
            }

            return ac - total;
        }
    }
}
