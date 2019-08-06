using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    class _15
    {
        public void runCode()
        {
            int[] nums = new int[] { -4,-1,-1,0,1,2 };
            ThreeSum(nums);

        }
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> res = new List<IList<int>>();
            Array.Sort(nums);
            for (int i = 0; i + 2 < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {              // skip same result
                    continue;
                }
                int j = i + 1, k = nums.Length - 1;
                int target = -nums[i];
                while (j < k)
                {
                    if (nums[j] + nums[k] == target)
                    {
                        res.Add(new List<int> { nums[i], nums[j], nums[k] });
                        j++;
                        k--;
                        while (j < k && nums[j] == nums[j - 1]) j++;  // skip same result
                        while (j < k && nums[k] == nums[k + 1]) k--;  // skip same result
                    }
                    else if (nums[j] + nums[k] > target)
                    {
                        k--;
                    }
                    else
                    {
                        j++;
                    }
                }
            }
            return res;
        }
    }
}
