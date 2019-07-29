using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class majority_element
    {
        public int MajorityElement(int[] nums)
        {
            int l = nums.Length / 2;
            int res = 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            
            foreach (int num in nums)
            {
                if (dic.ContainsKey(num))
                {
                    dic[num]++;
                    if (dic[num] > l)
                        res = dic[num];
                }
                else
                    dic.Add(num, 1);
            }

            return res;

        }
    }
}
