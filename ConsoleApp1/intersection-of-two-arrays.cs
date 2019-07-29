using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class intersection_of_two_arrays
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            List<int> res = new List<int>(); 
            int l1 = nums1.Length;
            int l2 = nums2.Length;

            int length = l1 > l2 ? l1 : l2;

            for (int i = 0; i<l1; i++)
            {
                if(!dic.ContainsKey(nums1[i]) )
                {
                    dic.Add(nums1[i],0);
                    
                }
                
            }

            for(int j = 0; j<l2;j++)
            {
                if(dic.ContainsKey(nums2[j]) && dic[nums2[j]] == 0)
                {
                    res.Add (nums2[j]);
                    dic[nums2[j]]++;
                }
            }
            return res.ToArray();

        }
    }
}
