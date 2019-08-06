using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _1
    {
       public void runCode()
        {
            int [] nums  = { 3,3};

            TwoSum(nums,6);
        }
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i< nums.Length; i++)
            {
                int k = target - nums[i];
                if (map.ContainsKey(k))
                    return new int[] { map[k], i };
                if(!map.ContainsKey(nums[i]))
                    map.Add(nums[i], i);
            }

            return new int[] { };
        }
                   


        }
    }
