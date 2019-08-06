using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _16
    {

        public void runCode()
        {
            int[] nums = new int[] {1,2,4,8,16,32,64,128 };
            int target = 82;

            ThreeSumClosest(nums, target);
        }
        public int ThreeSumClosest(int[] nums, int target)
        {
            
            IList<IList<int>> res = new List<IList<int>>();

            Array.Sort(nums);
            int max = 0;

            max = nums[0] + nums[1] + nums[2];
            for (int i =0; i< nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;
                else
                {
                    int j = i + 1, k = nums.Length - 1;
                   
                    while (j<k)
                    {
                        int cur = nums[j] + nums[k] + nums[i];
                        if (Math.Abs(max - target) > Math.Abs( cur - target))
                        {
                            max = cur;
                            if (j < k && nums[j] == nums[j + 1]) j++;
                            if (j < k && nums[k] == nums[k - 1]) k--;
                        }
                        if (cur < target) j++;
                        else if (cur > target) k--;
                        else return target;
                    }

                }
            }

            return max;
        }
    }
}
