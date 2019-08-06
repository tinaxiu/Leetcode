using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _659
    {
        public void runCode()
        {
            IsPossible(nums);
        }
        int[] nums = new int[] { 1, 2, 3, 3, 4, 5 };
        public bool IsPossible(int[] nums)
        {
            if (nums.Length == 0) return true;
            if (nums.Length < 2) return false;

            List<List<int>> list =new List<List<int>>();
            int curList = 0;
            foreach(int num in nums)
            {
                if(list.Count == 0)
                {
                    list.Add(new List<int>(num));
                    continue;
                }
                while (list[curList][list[curList].Count - 1] + 1 == num)
                {
                    curList++;
                }

                if(curList <= list.Count)
                {
                    list[curList].Add(num);
                }
                else
                {
                    list.Add(new List<int>(num));
                }
                curList = 0;
            }

            foreach (List<int> ls in list)
            {
                if (ls.Count < 3) return false;
            }

            return true;
        }
    }
}
