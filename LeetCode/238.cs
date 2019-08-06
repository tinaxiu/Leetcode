using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _238
    {
        public void runCode()
        {
            int[] nums = { 1,2,0,4};
            ProductExceptSelf(nums);
        }
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] res = new int[nums.Length];
            int total = 1;
            int isZero = -1;
            int zeroCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                    total *= nums[i];
                else if (zeroCount == 0)
                {
                    isZero = i;
                    zeroCount++;
                }
                else
                {
                    Array.Clear(nums, 0, nums.Length);
                    return nums;
                }
                    
                   
            }

            if(isZero == -1)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = total / nums[i];
                }
                return nums;
            }
            else
            {
                Array.Clear(nums, 0, nums.Length);
                nums[isZero] = total;
                return nums;
            }           
        }
    }
}
