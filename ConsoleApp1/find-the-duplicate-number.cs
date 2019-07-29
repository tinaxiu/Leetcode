using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class find_the_duplicate_number
    {
        public int FindDuplicate(int[] nums)
        {
            //Array.Sort(nums);
            //int res = 0;
            //for (int i =1; i<nums.Length; i++)
            //{
            //    if (nums[i] == nums[i - 1])
            //        res = nums[i];
            //}

            //return res;

            List<int> list = new List<int>();
            int res = 0;
            foreach(int num in nums)
            {
                if (list.Contains(num))
                    res = num;
                else
                    list.Add(num);
            }

            return res;
        }
    }
}
